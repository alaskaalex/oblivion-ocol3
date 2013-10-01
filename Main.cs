using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.Xml.Serialization;
using System.Reflection;
using Microsoft.Win32;
using System.Media;
using System.Diagnostics;

namespace OCOL {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        public static String oblivionFolder = "";
        public static String dataFolder = oblivionFolder + "Data\\";
        public static String userDir = Environment.ExpandEnvironmentVariables("%USERPROFILE%") +"\\";
        public static String tempPath = System.IO.Path.GetTempPath();
        public static String oblivionLocal = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Oblivion\\");
        public static String oblivionMyGames = userDir + "Documents\\My Games\\Oblivion\\";
        public static String oblivionINIPath = oblivionMyGames + "oblivion.ini";
        public static String OCOLOptionsPath = oblivionMyGames + "OCOLOptions.xml";
        public static String launcherSavePath = oblivionMyGames + "OCOLUtilityLauncherConfig.xml";
        private static Options options = new Options();

        private OCOLOptions settings;

        private bool checkedForUpdates = false;


        public static bool checkForUpdates() {
                StringBuilder sb = new StringBuilder();

                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://ocol.alexstek.com/version.xml");

                HttpWebResponse response;
                try {
                    response = (HttpWebResponse)req.GetResponse();
                } catch (System.Net.WebException) {
                    return false;
                }

                Stream resStream = response.GetResponseStream();

                XmlSerializer serializer = new XmlSerializer(typeof(OCOLVersion));
                OCOLVersion newVersion = (OCOLVersion)serializer.Deserialize(resStream);


                if (!newVersion.isCurrentVersion()) {
                    DialogResult dr = MessageBox.Show("OCOL has been updated. Would you like to download and install the new version?", "OCOL New Version", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                    if (dr == DialogResult.Yes) {
                        VersionDownloader versionDownloader = new VersionDownloader(newVersion.url);
                        versionDownloader.ShowDialog();
                        return true;
                    }
                }
                return false;

        }

        public void loadAndValidateProperties() {

            /*XmlSerializer serializeaaa = new XmlSerializer(typeof(OCOLVersion));
            TextWriter myWriter = new StreamWriter(userDir + "ocolversion.xml");
            Assembly assem = Assembly.GetEntryAssembly();
            AssemblyName assemName = assem.GetName();
            OCOLVersion myVersion = new OCOLVersion(assemName.Version, "myUrl.exe");
            serializeaaa.Serialize(myWriter, myVersion);
            myWriter.Close();*/

            //If we're on XP or before, oblvionMyGames won't be in %USERPROFILE%\\Documents, it will be in %USERPROFILE%\\My Documents.
            if (!Directory.Exists(oblivionMyGames)) {
                oblivionMyGames = userDir + "My Documents\\My Games\\Oblivion\\";
                oblivionINIPath = oblivionMyGames + "oblivion.ini";
                OCOLOptionsPath = oblivionMyGames + "OCOLOptions.xml";
                launcherSavePath = oblivionMyGames + "OCOLUtilityLauncherConfig.xml";
            }
            
            XmlSerializer serializer = new XmlSerializer(typeof(OCOLOptions));

            try {
                //try to deserialize
                TextReader myReader = new StreamReader(OCOLOptionsPath);
                settings = (OCOLOptions)serializer.Deserialize(myReader);
                myReader.Close();

                oblivionFolder = settings.oblivionFolder;
                oblivionMyGames = settings.oblivionMyGames;
            } catch {
                //if we don't have a file or can't deserialize, start from scratch.
                settings = new OCOLOptions();

                RegistryKey myKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Bethesda Softworks\Oblivion");
                if (myKey != null) {
                    oblivionFolder = (String)myKey.GetValue("Installed Path");
                }
            }





            if (!Directory.Exists(oblivionLocal)) {
                if (Directory.Exists(Environment.ExpandEnvironmentVariables("%USERPROFILE%\\Local Settings\\Application Data\\Oblivion\\"))){
                    //XP fix, does not have %LOCALAPPDATA%
                    oblivionLocal = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\Local Settings\\Application Data\\Oblivion\\");
                } else {
                    MessageBox.Show("Directory " + oblivionLocal + " does not exist!");
                }
            }
            if (!File.Exists(oblivionFolder + "Oblivion.exe")) {
                locateOblivionFolder();
            }

            if (!Directory.Exists(oblivionMyGames)) {
                MessageBox.Show("Oblivion User Directory " + oblivionMyGames + " does not exist! Locate it now...\n(the directory which contains oblivion.ini)");
                oblivionFolderBrowser.ShowDialog();
                if (Directory.Exists(oblivionFolderBrowser.SelectedPath)) {
                    settings.oblivionMyGames = oblivionFolderBrowser.SelectedPath + "\\";
                } else {
                    MessageBox.Show("To use OCOL you must specify a valid path to the directory which contains your Oblivion.ini file");
                    Application.Exit();
                }
            }


            oblivionMyGames = settings.oblivionMyGames;
            oblivionFolder = settings.oblivionFolder;
            dataFolder = settings.oblivionFolder + "Data\\";

            TextWriter myWriter = new StreamWriter(OCOLOptionsPath);
            serializer.Serialize(myWriter, settings);
            myWriter.Close();


            System.Environment.CurrentDirectory = oblivionFolder;
        }

        private void locateOblivionFolder() {
            if (File.Exists(System.Environment.CurrentDirectory + "\\Oblivion.exe")) {
                settings.oblivionFolder = System.Environment.CurrentDirectory + "\\";
                return;
            }

            RegistryKey myKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Bethesda Softworks\Oblivion");
            if (myKey != null) {
                String possibleOF = (String)myKey.GetValue("Installed Path");
                if (File.Exists(possibleOF + "\\Oblivion.exe")) {
                    settings.oblivionFolder = possibleOF;
                    if (!settings.oblivionFolder.EndsWith("\\")) {
                        settings.oblivionFolder = settings.oblivionFolder + "\\";
                    }
                    return;
                }
            }



            MessageBox.Show("Oblivion Folder as specified: \n\"" + oblivionFolder + "\" \ndoes not exist or is not a valid Oblivion install! Browse to your Oblivion folder to continue using OCOL.");
            oblivionFolderBrowser.ShowNewFolderButton = false;
            do {
                if (DialogResult.OK != oblivionFolderBrowser.ShowDialog()) {
                    MessageBox.Show("To use OCOL you must specify an Oblivion directory!");
                    this.Close();
                } else if (!File.Exists(oblivionFolderBrowser.SelectedPath + "\\Oblivion.exe")) {
                    MessageBox.Show("The path you specified was not a valid Oblivion install.");
                }
            } while (!File.Exists(oblivionFolderBrowser.SelectedPath + "\\Oblivion.exe"));
            settings.oblivionFolder = oblivionFolderBrowser.SelectedPath + "\\";
        }

        private void main_Load(object sender, EventArgs e) {

            loadAndValidateProperties();

            Version currentVersion = Assembly.GetEntryAssembly().GetName().Version;
            VersionCounter.Text = "OCOL " + currentVersion.ToString();

            FileVersionInfo oblivionFileInfo = FileVersionInfo.GetVersionInfo(oblivionFolder + "Oblivion.exe");
            OblivionVersionCounter.Text = "Oblivion " + oblivionFileInfo.ProductVersion;


            if (File.Exists(oblivionFolder + "obse_loader.exe")) {
                FileVersionInfo obseFileInfo = FileVersionInfo.GetVersionInfo(oblivionFolder + "obse_loader.exe");
                obseVersionCounter.Text = "OBSE v00" + obseFileInfo.ProductBuildPart;
            } else {
                obseVersionCounter.Text = "OBSE Not Installed";
            }

            try {
                SoundPlayer launcherMusic = new SoundPlayer(oblivionFolder + "launcherMusic.wav");
                launcherMusic.Play();
            } catch {
                //do nothing, so what?
            }
            if (!Preloader.IsBusy) {
                Preloader.RunWorkerAsync();
            }
        }

        private void main_Activated(object sender, EventArgs e) {
            if (!Preloader.IsBusy) {
                Preloader.RunWorkerAsync();
            }
        }


        private bool windowDragInitialized = false;
        private Point windowDragPt;
        private void main_MouseDown(object sender, MouseEventArgs e) {
            windowDragInitialized = true;
            windowDragPt = PointToScreen(e.Location);
        }

        private void main_MouseUp(object sender, MouseEventArgs e) {
            windowDragInitialized = false;
        }

        private void main_MouseMove(object sender, MouseEventArgs e) {
            if (windowDragInitialized) {
                if (!windowDragPt.Equals(PointToScreen(e.Location))) {
                    Point absLoc = PointToScreen(e.Location);
                    int xPosition = this.DesktopLocation.X + (absLoc.X - windowDragPt.X);
                    int yPosition = this.DesktopLocation.Y + (absLoc.Y - windowDragPt.Y);
                    this.SetDesktopLocation(xPosition, yPosition);
                    windowDragPt = absLoc;
                }
            }
        }


        private void playButton_MouseEnter(object sender, EventArgs e) {
            playButton.Image = OCOL.Properties.Resources.playHover;
        }

        private void playButton_MouseLeave(object sender, EventArgs e) {
            playButton.Image = OCOL.Properties.Resources.playOff;
        }

        private void playButton_Click(object sender, EventArgs e) {
            if (File.Exists(settings.oblivionLauncherPath)) {
                System.Diagnostics.Process.Start(settings.oblivionLauncherPath, settings.oblivionLauncherArgs);
            } else if (File.Exists("Oblivion.exe")) {
                System.Diagnostics.Process.Start("Oblivion.exe");
            } else {
                return;
            }
            this.Close();
        }


        private void dataButton_MouseEnter(object sender, EventArgs e) {
            dataButton.Image = OCOL.Properties.Resources.dataHover;
        }

        private void dataButton_MouseLeave(object sender, EventArgs e) {
            dataButton.Image = OCOL.Properties.Resources.dataOff;
        }

        private void dataButton_Click(object sender, EventArgs e) {
            DataFiles f = new DataFiles();
            f.ShowDialog();
        }

        private void optionsButton_MouseEnter(object sender, EventArgs e) {
            optionsButton.Image = OCOL.Properties.Resources.optionsHover;
        }
        private void optionsButton_MouseLeave(object sender, EventArgs e) {
            optionsButton.Image = OCOL.Properties.Resources.optionsOff;
        }

        private void optionsButton_Click(object sender, EventArgs e) {
            options.ShowDialog();
            loadAndValidateProperties();
        }

        private void csButton_MouseEnter(object sender, EventArgs e) {
            csButton.Image = OCOL.Properties.Resources.csHover;
        }
        private void csButton_MouseLeave(object sender, EventArgs e) {
            csButton.Image = OCOL.Properties.Resources.csOff;
        }

        private void csButton_Click(object sender, EventArgs e) {
            if (File.Exists(settings.CSPath)) {
                System.Diagnostics.Process.Start(settings.CSPath, settings.CSArgs);
            } else if (File.Exists("TESConstructionSet.exe")) {
                System.Diagnostics.Process.Start("TESConstructionSet.exe");
            } else {
                return;
            }
        }

        private void utilitiesButton_MouseEnter(object sender, EventArgs e) {
            utilitiesButton.Image = OCOL.Properties.Resources.utilitiesHover;
        }
        private void utilitiesButton_MouseLeave(object sender, EventArgs e) {
            utilitiesButton.Image = OCOL.Properties.Resources.utilitiesOff;
        }

        private void utilitiesButton_Click(object sender, EventArgs e) {
            new Utilities().ShowDialog();
        }

        private void uninstallButton_MouseEnter(object sender, EventArgs e) {
            uninstallButton.Image = OCOL.Properties.Resources.uninstallHover;
        }

        private void uninstallButton_MouseLeave(object sender, EventArgs e) {
            uninstallButton.Image = OCOL.Properties.Resources.uninstallOff;
        }

        private void uninstallButton_Click(object sender, EventArgs e) {
            String uninstallerPath;
            try {
                RegistryKey myKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{35CB6715-41F8-4F99-8881-6FC75BF054B0}");
                if (myKey == null) {
                    return;
                }

                uninstallerPath = (String)myKey.GetValue("UninstallString");

                System.Diagnostics.Process.Start(uninstallerPath.Substring(0, uninstallerPath.IndexOf(' ')), uninstallerPath.Substring(uninstallerPath.IndexOf(' ')));
            } catch (Exception exn) {
                MessageBox.Show("Could not start uninstaller. \n" + exn.Message);
                return;
            }

            this.Close();


        }


        private void exitButton_MouseEnter(object sender, EventArgs e) {
            exitButton.Image = OCOL.Properties.Resources.exitHover;
        }
        private void exitButton_MouseLeave(object sender, EventArgs e) {
            exitButton.Image = OCOL.Properties.Resources.exitOff;
        }

        private void exitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Preloader_DoWork(object sender, DoWorkEventArgs e) {

            if (settings.checkForOCOLUpdates && !checkedForUpdates) {
                checkForUpdates();
                checkedForUpdates = true;
            }
            options.Options_Preload();
        }

        

        private void Preloader_RunWorkerCompleted( object sender,  RunWorkerCompletedEventArgs e) {
        }












    }

    [Serializable]
    public class OCOLVersion {
        public int Build { get; set; }
        public int Major { get; set; }
        public int MajorRevision { get; set; }
        public int Minor { get; set; }
        public int MinorRevision { get; set; }
        public int Revision { get; set; }
        public String url;

        public OCOLVersion(){}

        public OCOLVersion(Version version, String url) {
            this.Build = version.Build;
            this.Major = version.Major;
            this.MajorRevision = version.MajorRevision;
            this.Minor = version.Minor;
            this.MinorRevision = version.MinorRevision;
            this.Revision = version.Revision;
            this.url = url;
        }

        public bool isCurrentVersion(){
            Assembly assem = Assembly.GetEntryAssembly();
            AssemblyName assemName = assem.GetName();
            if (Build == assemName.Version.Build && Major == assemName.Version.Major && MajorRevision == assemName.Version.MajorRevision && Minor == assemName.Version.Minor && MinorRevision == assemName.Version.MinorRevision && Revision == assemName.Version.Revision){
                return true;
            } else {
                return false;
            }
        }
    }

}