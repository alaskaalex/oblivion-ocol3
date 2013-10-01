using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OCOL {
    public partial class Utilities : Form {

        public bool editing = false;
        public const int BUTTON_COUNT = 10;

        public List<Launcher> launchers;


        public Launcher selectedLauncher;

        public Utilities() {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(423, 235);
            this.Size = new System.Drawing.Size(423, 235);
            this.SuspendLayout();
            LauncherGB.SuspendLayout();

            bool deserializationFailed = false;
            try {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Launcher>));
                TextReader myReader = new StreamReader(Main.launcherSavePath);
                launchers = (List<Launcher>)serializer.Deserialize(myReader);
                myReader.Close();
            } catch {
                deserializationFailed = true;
                launchers = new List<Launcher>();
            }


            for (int i = 0; i < BUTTON_COUNT; i++) {

                if (deserializationFailed) {
                    launchers.Add(new Launcher());
                }

                Launcher launcher = launchers[i];

                launcher.launcherButton = new ButtonAction(launcher);

                launcher.launcherButton.BackgroundImage = global::OCOL.Properties.Resources.button_bg;
                launcher.launcherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                launcher.launcherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                launcher.launcherButton.Location = new System.Drawing.Point(6 + (76 * (int)(i % (BUTTON_COUNT / (BUTTON_COUNT / 5)))), 19 + (76 * (int)(i / (BUTTON_COUNT / (BUTTON_COUNT / 5)))));
                launcher.launcherButton.Size = new System.Drawing.Size(70, 70);
                launcher.launcherButton.TabIndex = 0;
                launcher.launcherButton.Text = launcher.Name;
                launcher.launcherButton.UseVisualStyleBackColor = true;
                launcher.launcherButton.Click += new EventHandler(Launcher_Click);

                LauncherGB.Controls.Add(launcher.launcherButton);

            }


            if (deserializationFailed) {

                //MessageBox.Show("DEBUG: Deserialization failed.");
                int p = 0;
                foreach (String f in Directory.GetFiles(Main.oblivionFolder, "*.exe", SearchOption.AllDirectories)) {

                    if (f.EndsWith("Oblivion.exe") || f.EndsWith("OCOLHelper.exe") || f.EndsWith("OblivionLauncher.exe") || f.EndsWith("obse_loader.exe") || f.Contains("unins") || f.EndsWith("OCOL.exe") || f.EndsWith("lame.exe") || f.EndsWith("7z.exe") || f.EndsWith("7za.exe") || f.EndsWith("OBG.exe")) {
                        continue;
                    }

                    if (p > 9) {
                        break;
                    }
                    int shortIndex;
                    if ((shortIndex = f.LastIndexOfAny("/\\".ToCharArray())) > -1) {
                        launchers[p].SetName(f.Substring(shortIndex + 1));
                    }

                    if (launchers[p].Name.Contains("TESConstructionSet.exe")) {
                        launchers[p].SetName("Construction Set (non-OBSE)");
                    }
                    launchers[p].Action = f;
                    p++;
                }


                //TODO: test this with WX
                string bashPath = Main.oblivionFolder + "Mopy\\Wrye Bash Launcher.pyw";
                if (File.Exists(bashPath) && p < 10) {
                    int shortIndex;
                    if ((shortIndex = bashPath.LastIndexOfAny("/\\".ToCharArray())) > -1) {
                        launchers[p].SetName(bashPath.Substring(shortIndex + 1));
                    }
                    launchers[p].Action = bashPath;
                    p++;
                }
            }
            
            LauncherGB.ResumeLayout(false);
            LauncherGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        

        private void switchEditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (!editing) {
                editing = true;
                this.MinimumSize = new System.Drawing.Size(615, 352);
                this.Size = new System.Drawing.Size(615, 352);
                switchEditLink.Text = "Hide Edit Options...";
            } else {
                editing = false;
                this.MinimumSize = new System.Drawing.Size(423, 235);
                this.Size = new System.Drawing.Size(423, 235);
                switchEditLink.Text = "Show Edit Options...";
            }
        }

        private void SaveB_Click(object sender, EventArgs e) {
            if (selectedLauncher == null) {
                MessageBox.Show("No application launcher is currently selected! Click on one to save over it.");
                return;
            }

            selectedLauncher.SetName(nameTB.Text);
            selectedLauncher.Action = utilityPathTB.Text;
            selectedLauncher.Args = argumentTB.Text;

            MessageBox.Show("Application Launcher Saved!");
       }


        private void Launcher_Click(object sender, EventArgs e) {
            selectedLauncher = ((ButtonAction)sender).launcher;
            if (!editing) {
                if (selectedLauncher.Action == "") {
                    return;
                }
                try {
                    System.Diagnostics.Process.Start(selectedLauncher.Action, selectedLauncher.Args);
                } catch {
                    MessageBox.Show("Could not start executable " + selectedLauncher.Action + ". The file was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            } else {
                utilityPathTB.Text = selectedLauncher.Action;
                argumentTB.Text = selectedLauncher.Args;
                nameTB.Text = selectedLauncher.Name;
            }
        }

        private void Utilities_Load(object sender, EventArgs e) {

        }

        private void Utilities_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e) {
            SerializeLaunchersToXML();
        }

        private void testB_Click(object sender, EventArgs e) {
            try {
                System.Diagnostics.Process.Start(utilityPathTB.Text, argumentTB.Text);
            } catch {
                MessageBox.Show("Could not start executable " + utilityPathTB.Text + ". The file was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void SerializeLaunchersToXML() {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Launcher>));
            TextWriter textWriter = new StreamWriter(Main.launcherSavePath);
            serializer.Serialize(textWriter, launchers);
            textWriter.Close();
        }

        private void browseB_Click(object sender, EventArgs e) {
            DialogResult dr = browseDialog.ShowDialog();
            if (dr == DialogResult.OK) {
                utilityPathTB.Text = browseDialog.FileName;
            }
        }


    }

    public class Launcher {
        public String Name;
        public String Action;
        public String Args;

        [XmlIgnore]
        public Button launcherButton;

        public void SetName(String Name) {
            this.Name = Name;
            launcherButton.Text = Name;
        }

        public Launcher(){}

    }

}
