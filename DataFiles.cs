using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;

namespace OCOL {
    public partial class DataFiles : Form {
        public DataFiles() {
            InitializeComponent();
        }

        private void DataFiles_Load(object sender, EventArgs e) {
            if (!File.Exists(Main.oblivionLocal + "plugins.txt")) {
                File.CreateText(Main.oblivionLocal + "plugins.txt");
            }

            String[] activePlugins = File.ReadAllLines(Main.oblivionLocal + "plugins.txt");


            List<ModFile> mf = new List<ModFile>();
            foreach (String f in Directory.GetFiles(Main.dataFolder)) {
                if (f.EndsWith("esp") || f.EndsWith("esm")) {
                    ModFile m = new ModFile(f.Substring(f.LastIndexOf("\\") + 1), File.GetLastWriteTime(f), File.GetLastAccessTime(f), activePlugins.Contains(f.Substring(f.LastIndexOf("\\") + 1)));

                    mf.Add(m);
                }
            }

            mf.Sort();

            foreach (ModFile m in mf) {
                filesCLB.Items.Add(m, m.active);
            }
        }


        bool mouseDown = false;
        object draggedItem;
        int draggedIndex = 0;
        bool draggedChecked = false;
        private void filesCLB_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button != System.Windows.Forms.MouseButtons.Left) {
                return;
            }

            draggedItem = filesCLB.SelectedItem;
            draggedIndex = filesCLB.SelectedIndex;
            draggedChecked = filesCLB.GetItemChecked(draggedIndex);
            mouseDown = true;

            ModFile m = (ModFile)filesCLB.SelectedItem;
            filename.Text = "File Name: " + m.name;
            modified.Text = "Modified: " + m.modified.ToString();
            created.Text = "Created: " + m.created.ToString();
            author.Text = "Author: " + m.getAuthor();
            description.Text = "Masters: \n";
            foreach (String mast in m.getMasters())
                description.Text += (mast + "\n");
            description.Text += "\nDescription: \n" + m.getDescription();
        }

        private void filesCLB_MouseMove(object sender, EventArgs e) {
            if (mouseDown && draggedIndex != filesCLB.SelectedIndex) {
                int sI = filesCLB.SelectedIndex;

                filesCLB.Items.RemoveAt(draggedIndex);
                filesCLB.Items.Insert(sI, draggedItem);
                filesCLB.SetItemChecked(sI, draggedChecked);

                filesCLB.SelectedItem = draggedItem;
                draggedIndex = sI;




                /*
                filesCLB.SelectedItem = null;
                if (draggedIndex > sI) {
                    filesCLB.Items.Insert(sI, draggedItem);
                    filesCLB.SetItemChecked(sI, draggedChecked);
                    filesCLB.Items.RemoveAt(draggedIndex + 1);
                } else {
                    filesCLB.Items.Insert(sI + 1, draggedItem);
                    filesCLB.SetItemChecked(sI + 1, draggedChecked);
                    filesCLB.Items.RemoveAt(sI - 1);
                }
                filesCLB.SelectedItem = draggedItem;
                draggedIndex = sI;
                 * */
            }
        }

        private void filesCLB_MouseUp(object sender, EventArgs e) {
            if (!mouseDown)
                return;
            filesCLB.SetItemChecked(filesCLB.SelectedIndex, draggedChecked);
            mouseDown = false;
        }

        private void filesCLB_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e) {
            if (e.NewValue == CheckState.Checked)
                ((ModFile)filesCLB.Items[e.Index]).active = true;
            else
                ((ModFile)filesCLB.Items[e.Index]).active = false;
        }

        private void filesCLB_SelectedIndexChanged(object sender, EventArgs e) {
            if (mouseDown)
                return;
            ModFile m = (ModFile)filesCLB.SelectedItem;
            if (m == null)
                return;
            filename.Text = "File Name: " + m.name;
            modified.Text = "Modified: " + m.modified.ToString();
            created.Text = "Created: " + m.created.ToString();
            author.Text = "Author: " + m.getAuthor();
            description.Text = "Masters: \n";
            foreach (String mast in m.getMasters())
                description.Text += (mast + "\n");
            description.Text += "\nDescription: \n" + m.getDescription();

        }


        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private Boolean checkMasters() {
            String toBeActivated = "\n";
            String toBeDeActivated = "";
            String missingMasters = "\n";
            foreach (ModFile m in filesCLB.Items) {
                if (!m.active)
                    continue;

                //iterate through mod's Masters
                foreach (String master in m.getMasters()) {
                    int loc;
                    if ((loc = (filesCLB.FindString(master))) > -1) { //if master exists in list
                        if (!((ModFile)filesCLB.Items[loc]).active) { //if master is not active
                            if (toBeActivated.IndexOf(master) < 0)
                                toBeActivated += master + "\n";//master is found and inactive
                        }
                    }//Else throw error, one of the masters is missing
                    else {
                        if (toBeDeActivated.IndexOf(m.name) < 0)
                            toBeDeActivated += m.name + ",  ";
                        if (missingMasters.IndexOf(master) < 0)
                            missingMasters += master + "\n";
                    }
                }
            }
            if (toBeDeActivated.Length > 5) {
                DialogResult question = MessageBox.Show("One or more plugin dependencies is MISSING. These dependencies are missing: " + missingMasters + "\n\nThe following are the files that rely on these dependencies: \n" + toBeDeActivated + "\n\nWould you like me to automatically deactivate these files for you? Alternatively, you could attempt to locate and load the missing dependencies yourself.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                if (question == DialogResult.Yes) {
                    String[] x = { ",  " };
                    foreach (String file in toBeDeActivated.Split(x, StringSplitOptions.RemoveEmptyEntries)) {
                        filesCLB.SetItemChecked(filesCLB.FindString(file.Trim()), false);
                    }
                    return true;
                } else
                    return false;
            }
            if (toBeActivated.Length > 5) {
                DialogResult question = MessageBox.Show("One or more plugin dependencies need to be satisfied. The following plugins need to be activated in order to continue: " + toBeActivated + "\nWould you like me to automatically activate them for you?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                if (question == DialogResult.Yes) {
                    char[] x = { '\n' };
                    foreach (String master in toBeActivated.Split(x)) {
                        filesCLB.SetItemChecked(filesCLB.FindString(master), true);
                    }
                    return true;
                } else
                    return false;
            } else
                return true;

        }

        bool needUACToWriteLoadOrder = false;

        private void acceptButton_Click(object sender, EventArgs e) {

            if (!checkMasters()) {
                return;
            }


            StreamWriter fw = new StreamWriter(Main.oblivionLocal + "plugins.txt", false);

            fw.WriteLine("# This file is used to tell Oblivion which data files to load." + fw.NewLine + "# Use the oblivion launcher, OCOL, or obmm to choose which files you want." + fw.NewLine + "# Please do not modify this file by hand." + fw.NewLine + fw.NewLine);
            DateTime LastModified = DateTime.MinValue;
            ModFile m;
            for (int i = 0; i < filesCLB.Items.Count; i++) {
                m = (ModFile)filesCLB.Items[i];
                if (m.active)
                    fw.WriteLine(m.name);
                
                if (LastModified.CompareTo(m.modified) >= 0) //if Date Modified for last entry is greater than or equal to Date Modified for this entry
                {
                    m.modified = LastModified.AddSeconds(10);
                    //this next line must run in UAC
                    if (!needUACToWriteLoadOrder) {
                        try {
                            File.SetLastWriteTime(Main.dataFolder + m.name, m.modified);
                        } catch (UnauthorizedAccessException) {
                            needUACToWriteLoadOrder = true;
                        }
                    }
                }
                LastModified = m.modified;
            }

            if (needUACToWriteLoadOrder) {
                MessageBox.Show("OCOL needs administrator rights to save your load order. Click \"Yes\" on the User Account Control prompt to save load order.");
                List<ModFile> myModFileList = new List<ModFile>();
                myModFileList.AddRange(filesCLB.Items.Cast<ModFile>());

                XmlSerializer serializer = new XmlSerializer(typeof(List<ModFile>));
                TextWriter myWriter = new StreamWriter(Main.oblivionLocal + "OCOLLoadOrder.xml");
                serializer.Serialize(myWriter, myModFileList);
                myWriter.Close();

                int failCode = 0;
                try {
                    Process myProcess = Process.Start("OCOLHelper.exe", "\"" + Main.oblivionLocal + "OCOLLoadOrder.xml\" \"" + Main.dataFolder + "");
                    myProcess.WaitForExit(5000);
                    if (myProcess.HasExited) {
                        failCode = myProcess.ExitCode;
                    }
                } catch {
                    failCode = 3;
                }
                if (failCode == 0) {
                    //MessageBox.Show("Load order saved successfully!");
                } else {
                    MessageBox.Show("Could not save load order!");
                    return;
                }



            }


            fw.Close();

            this.Close();
        }




        private void toggleEnabledToolStripMenuItem_Click(object sender, EventArgs e) {
            if (filesCLB.SelectedIndex == -1)
                return;
            filesCLB.SetItemChecked(filesCLB.SelectedIndex, !filesCLB.GetItemChecked(filesCLB.SelectedIndex));
        }

        private void moveToTopToolStripMenuItem_Click(object sender, EventArgs e) {
            if (filesCLB.SelectedIndex == -1) {
                return;
            }
            filesCLB.Items.Insert(0, filesCLB.SelectedItem);
            filesCLB.SetItemChecked(0, filesCLB.GetItemChecked(filesCLB.SelectedIndex));
            filesCLB.Items.RemoveAt(filesCLB.SelectedIndex);
            filesCLB.SetSelected(0, true);
        }

        private void moveToBottomToolStripMenuItem_Click(object sender, EventArgs e) {
            if (filesCLB.SelectedIndex == -1) {
                return;
            }
            filesCLB.Items.Insert(filesCLB.Items.Count, filesCLB.SelectedItem);
            filesCLB.SetItemChecked(filesCLB.Items.Count - 1, filesCLB.GetItemChecked(filesCLB.SelectedIndex));
            filesCLB.Items.RemoveAt(filesCLB.SelectedIndex);
            filesCLB.SetSelected(filesCLB.Items.Count - 1, true);
        }

        private void enableAllToolStripMenuItem_Click(object sender, EventArgs e) {
            for (int i = 0; i < filesCLB.Items.Count; i++) {
                filesCLB.SetItemChecked(i, true);
            }
        }

        private void disableAllToolStripMenuItem_Click(object sender, EventArgs e) {
            for (int i = 0; i < filesCLB.Items.Count; i++) {
                filesCLB.SetItemChecked(i, false);
            }
        }









    }
}
