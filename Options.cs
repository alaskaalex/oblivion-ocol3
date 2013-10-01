using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Xml.Serialization;

namespace OCOL
{
    public partial class Options : Form {

        public DataView iniDV;


        public Options() {
            InitializeComponent();
        }


        void Options_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e) {
            iniDV = null;
            Preloaded = false;
        }

        private void cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e) {
            applyB_Click(null, null);
            this.Close();
        }

        private void dxdiag_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("dxdiag.exe");
        }


        public void preLoadINI(String pathToINI) {

            if (!File.Exists(pathToINI)) {
                DialogResult dr = MessageBox.Show("Video settings not configured! OCOL will detect and set them for you now.");
                File.Create(pathToINI).Close();
                restoreDefaultINI_Click(null, null);
                this.loadGraphics();
                preset_medium_Click(null, null);
                applyB_Click(null, null);
                Preloaded = false;
                this.ShowDialog();
                return;
            }

            DataTable iniTable;
            String[] iniLines = File.ReadAllLines(pathToINI);


            iniTable = new DataTable();
            iniTable.Columns.Add("Property");
            iniTable.Columns[0].ReadOnly = true;
            iniTable.Columns.Add("Value");


            foreach (String line in iniLines) {
                if (line.Contains("[") && line.Contains("]")) {
                    String[] o = new String[2];
                    o[0] = line;
                    iniTable.Rows.Add(o);
                    continue;
                }


                String[] pair = { line, "" };

                try {
                    pair[0] = line.Substring(0, line.IndexOf("="));
                    pair[1] = line.Substring(line.IndexOf("=") + 1);
                } catch { }

                iniTable.Rows.Add(pair);
            }
            iniDV = iniTable.DefaultView;


        }






        private bool saveINI(String pathToSaveINI) {

            try {
                StreamWriter fw = new StreamWriter(pathToSaveINI, false);

                String key;
                String value;
                foreach (DataRow dv in iniDV.Table.Rows) {
                    key = (String)dv[0];
                    if (!(dv[1] is System.DBNull))
                        value = (String)dv[1];
                    else
                        value = null;

                    if (value == null || value.Length < 1) {
                        fw.WriteLine(key);
                        continue;
                    }
                    fw.WriteLine(key + "=" + value);

                }

                fw.Close();

                return true;
            } catch (Exception e) {
                MessageBox.Show("OCOL encountered a fatal error writing file: \n" + pathToSaveINI
                    + "\nEnsure that the directory has the correct permissions and try again. \n Error Message: " + e.Message, "INI File Write Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

        }

        private String getIniValue(String key) {
            foreach (DataGridViewRow row in iniLV.Rows) {
                if (((String)row.Cells[0].Value).Contains(key)) {
                    return ((String)row.Cells[1].Value);
                }
            }
            return null;
        }

        private void setIniValue(String key, String value) {
            /*for (DataRow row in iniDV.Table.Rows) {
                if (((String)row.ItemArray[0]).Contains(key)) {
                    row.ItemArray[1] = value;
                }

            }*/

            for (int i = 0; i < iniDV.Table.Rows.Count; i++) {
                if (((String)iniDV.Table.Rows[i].ItemArray[0]).Contains(key)) {
                    iniDV.Table.Rows[i]["Value"] = value;
                }
            }


            /*foreach (DataGridViewRow row in iniLV.Rows) {
                if (((String)row.Cells[0].Value).Contains(key)) {
                    row.Cells[1].Value = value;
                }
            }*/
        }


        private bool Preloaded = false;
        public void Options_Preload() {
            if (!Preloaded) {
                preLoadINI(Main.oblivionINIPath);
                Preloaded = true;
            }
        }

        private void Options_Load(object sender, EventArgs e) {

            if (!Preloaded) {
                preLoadINI(Main.oblivionMyGames + "oblivion.ini");
                Preloaded = true; //just for good measure
            }
            iniLV.DataSource = iniDV;
            iniLV.Columns[0].Width = iniLV.Width / 2 - 15;
            iniLV.Columns[1].Width = iniLV.Width / 2 - 5;

            loadGraphics();
            loadOCOLOptions();
        }


        private void optionTabControl_SelectedIndexChanged(object sender, EventArgs e) {
            if (optionTabControl.SelectedTab.Name.Equals("iniEditTab")) {
                iniLV.Select();
                iniLV.Focus();
            } else if (optionTabControl.SelectedTab.Name.Equals("graphics")) {
                filterBox.Text = "";
                loadGraphics();
            } else if (optionTabControl.SelectedTab.Name.Equals("ocolOptions")) {
                loadOCOLOptions();
            }
        }

        private void iniLV_DoubleClick(object sender, EventArgs e) {
            DataGridViewRow drv = iniLV.SelectedRows[0];
            if (drv.Visible) {
                drv.Selected = false;
                drv.Cells[1].Selected = true;
                iniLV.BeginEdit(true);
            }
        }


        private void iniLV_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.F) {
                filterBox.Focus();
            }

        }


        private void filterBox_TextChanged(object sender, EventArgs e) {
            if (filterBox.Text.Equals("Filter")) {
                iniDV.RowFilter = null;
                return;
            }


            iniDV.RowFilter = "Property LIKE '*" + filterBox.Text + "*'";


        }



        private void filterBox_GotFocus(object sender, EventArgs e) {
            if (filterBox.Text.Equals("Filter")) {
                filterBox.Text = "";
                filterBox.ForeColor = System.Drawing.SystemColors.WindowText;
                return;
            }

            filterBox.SelectAll();
        }


        private void filterBox_LostFocus(object sender, EventArgs e) {
            if (filterBox.Text.Equals("")) {
                filterBox.ForeColor = System.Drawing.SystemColors.GrayText;
                filterBox.Text = "Filter";
                return;
            }
        }

        private void applyB_Click(object sender, EventArgs e) {
            if (iniDV.RowFilter != null)
                iniDV.RowFilter = null;
            saveINI(Main.oblivionINIPath);
            saveOCOLOptions();
        }

        private void restoreDefaultINI_Click(object sender, EventArgs e) {
            preLoadINI(Main.oblivionFolder + "Oblivion_default.ini");
            iniLV.DataSource = iniDV;
        }

        private void loadGraphics() {
            long[] currentAdapter = new long[4];

            adapterCB.Items.Clear();
            resolutionCB.Items.Clear();
            //antialiasingCB.SelectedIndex = 0;

            if (getIniValue("uVideoDeviceIdentifierPart1") != null && getIniValue("uVideoDeviceIdentifierPart1").Length > 0) {
                currentAdapter[0] = Int64.Parse(getIniValue("uVideoDeviceIdentifierPart1"));
                currentAdapter[1] = Int64.Parse(getIniValue("uVideoDeviceIdentifierPart2"));
                currentAdapter[2] = Int64.Parse(getIniValue("uVideoDeviceIdentifierPart3"));
                currentAdapter[3] = Int64.Parse(getIniValue("uVideoDeviceIdentifierPart4"));
            }

            foreach (AdapterInformation a in Manager.Adapters) {
                MyAdapterInformation mai = new MyAdapterInformation(a);
                adapterCB.Items.Add(mai);                                   //Add each adapter to the combo box.
                bool equal = true;
                for (int i = 0; i < currentAdapter.Length; i++) {
                    if (!mai.GetIntegerUUID()[i].Equals(currentAdapter[i])) {       //If our UUID's are the same, select that one.
                        equal = false;
                        break;
                    }
                }
                if (equal) {
                    adapterCB.SelectedItem = mai;
                } else {
                    adapterCB.SelectedIndex = 0;
                }
            }


            int samples = Int32.Parse(getIniValue("iMultiSample"));
            switch (samples) {
                case 0:
                    antialiasingCB.SelectedIndex = 0;
                    break;
                case 2:
                    antialiasingCB.SelectedIndex = 1;
                    break;
                case 4:
                    antialiasingCB.SelectedIndex = 2;
                    break;
                case 8:
                    antialiasingCB.SelectedIndex = 3;
                    break;
                default:
                    antialiasingCB.SelectedIndex = 0;
                    break;
            }

            if (getIniValue("bFull Screen").Equals("1")) {
                mode_fullscreen.Checked = true;
            } else {
                mode_windowed.Checked = true;
            }

            if (getIniValue("iPresentInterval").Equals("1")) {
                mode_vSync.Checked = true;
            } else {
                mode_vSync.Checked = false;
            }

            if (getIniValue("bDoHighDynamicRange").Equals("1")) {
                effects_HDR.Checked = true;
            } else {
                effects_none.Checked = true;
            }

            if (getIniValue("bDisplayLODLand").Equals("1")) {
                dist_landscape.Checked = true;
                dist_buildings.Enabled = true;
                dist_trees.Enabled = true;
            } else {
                dist_landscape.Checked = false;
                dist_buildings.Enabled = false;
                dist_trees.Enabled = false;
            }

            if (getIniValue("bDisplayLODBuildings").Equals("1")) {
                dist_buildings.Checked = true;
            } else {
                dist_buildings.Checked = false;
            }

            if (getIniValue("bDisplayLODTrees").Equals("1")) {
                dist_trees.Checked = true;
            } else {
                dist_trees.Checked = false;
            }




        }

        private void loadOCOLOptions() {

            OCOLOptions settings;
            try {
                XmlSerializer serializer = new XmlSerializer(typeof(OCOLOptions));
                TextReader myReader = new StreamReader(Main.OCOLOptionsPath);
                settings = (OCOLOptions)serializer.Deserialize(myReader);
                myReader.Close();
            } catch {
                settings = new OCOLOptions();
            }

            launchPathTB.Text = settings.oblivionLauncherPath;
            launchArgsTB.Text = settings.oblivionLauncherArgs;

            csPathTB.Text = settings.CSPath;
            csArgsTB.Text = settings.CSArgs;

            checkForOCOLUpdates.Checked = settings.checkForOCOLUpdates;

            oblivionFolderPathTB.Text = settings.oblivionFolder;

            oblivionUserDirTB.Text = settings.oblivionMyGames;

        }

        private void saveOCOLOptions() {
            OCOLOptions settings = new OCOLOptions();

            settings.oblivionLauncherPath = launchPathTB.Text;
            settings.oblivionLauncherArgs = launchArgsTB.Text;

            settings.CSPath = csPathTB.Text;
            settings.CSArgs = csArgsTB.Text;

            settings.checkForOCOLUpdates = checkForOCOLUpdates.Checked;

            settings.oblivionFolder = oblivionFolderPathTB.Text;

            settings.oblivionMyGames = oblivionUserDirTB.Text;

            XmlSerializer serializer = new XmlSerializer(typeof(OCOLOptions));
            TextWriter myWriter = new StreamWriter(Main.OCOLOptionsPath);
            serializer.Serialize(myWriter, settings);
            myWriter.Close();

        }

        private void adapterCB_SelectedIndexChanged(object sender, EventArgs e) {
            MyAdapterInformation mai = (MyAdapterInformation)adapterCB.SelectedItem;
            resolutionCB.Items.Clear();
            foreach (DisplayMode dm in mai.GetDisplayModes()) {
                MyDisplayMode mdm = new MyDisplayMode(dm);
                bool add = true;
                foreach (MyDisplayMode other in resolutionCB.Items) {
                    if (mdm.SameResolution(other)) {
                        add = false;
                        break;
                    }
                }
                if (add) {
                    resolutionCB.Items.Add(mdm);
                }
                if (mdm.GetWidth().Equals(Int32.Parse(getIniValue("iSize W"))) && mdm.GetHeight().Equals(Int32.Parse(getIniValue("iSize H")))) {
                    resolutionCB.SelectedItem = mdm;
                }
            }


            setIniValue("uVideoDeviceIdentifierPart1", "" + mai.GetIntegerUUID()[0]);
            setIniValue("uVideoDeviceIdentifierPart2", "" + mai.GetIntegerUUID()[1]);
            setIniValue("uVideoDeviceIdentifierPart3", "" + mai.GetIntegerUUID()[2]);
            setIniValue("uVideoDeviceIdentifierPart4", "" + mai.GetIntegerUUID()[3]);

        }

        private void dist_landscape_CheckedChanged(object sender, EventArgs e) {
            if (!dist_landscape.Checked) {
                dist_buildings.Checked = false;
                dist_trees.Checked = false;
                dist_buildings.Enabled = false;
                dist_trees.Enabled = false;
                setIniValue("bDisplayLODLand", "0");
            } else {
                dist_buildings.Enabled = true;
                dist_trees.Enabled = true;
                setIniValue("bDisplayLODLand", "1");
            }
        }

        private void resolutionCB_SelectedIndexChanged(object sender, EventArgs e) {
            setIniValue("iSize W", "" + ((MyDisplayMode)resolutionCB.SelectedItem).GetWidth());
            setIniValue("iSize H", "" + ((MyDisplayMode)resolutionCB.SelectedItem).GetHeight());
        }

        private void antialiasingCB_SelectedIndexChanged(object sender, EventArgs e) {

            if (antialiasingCB.SelectedIndex != 0 && effects_HDR.Checked) {
                MessageBox.Show("HDR and Antialiasing cannot be enabled at the same time. Disabling HDR...");
                effects_none.Checked = true;
            }

            switch (antialiasingCB.SelectedIndex) {
                case 0:
                    setIniValue("iMultiSample", "0");
                    break;
                case 1:
                    setIniValue("iMultiSample", "2");
                    break;
                case 2:
                    setIniValue("iMultiSample", "4");
                    break;
                case 3:
                    setIniValue("iMultiSample", "8");
                    break;
                default:
                    setIniValue("iMultiSample", "0");
                    break;
            }
        }

        private void mode_windowed_CheckedChanged(object sender, EventArgs e) {
            if (mode_windowed.Checked) {
                setIniValue("bFull Screen", "0");
            }
        }

        private void mode_fullscreen_CheckedChanged(object sender, EventArgs e) {
            if (mode_fullscreen.Checked) {
                setIniValue("bFull Screen", "1");
            }
        }

        private void mode_vSync_CheckedChanged(object sender, EventArgs e) {
            if (mode_vSync.Checked) {
                setIniValue("iPresentInterval", "1");
            } else {
                setIniValue("iPresentInterval", "0");
            }

        }

        private void effects_none_CheckedChanged(object sender, EventArgs e) {
            if (effects_none.Checked) {
                setIniValue("bDoHighDynamicRange", "0");
            }
        }

        private void effects_HDR_CheckedChanged(object sender, EventArgs e) {
            if (effects_HDR.Checked) {
                if (antialiasingCB.SelectedIndex > 0) {
                    MessageBox.Show("HDR and Antialiasing cannot be enabled at the same time. Disabling antialiasing...");
                    antialiasingCB.SelectedIndex = 0;
                }
                setIniValue("bDoHighDynamicRange", "1");
            }
        }

        private void dist_buildings_CheckedChanged(object sender, EventArgs e) {
            if (dist_buildings.Checked) {
                setIniValue("bDisplayLODBuildings", "1");
            } else {
                setIniValue("bDisplayLODBuildings", "0");
            }
        }

        private void dist_trees_CheckedChanged(object sender, EventArgs e) {
            if (dist_trees.Checked) {
                setIniValue("bDisplayLODTrees", "1");
            } else {
                setIniValue("bDisplayLODTrees", "0");
            }
        }

        private void effects_bloom_CheckedChanged(object sender, EventArgs e) {
            if (effects_bloom.Checked) {
                setIniValue("bDoHighDynamicRange", "0");
            }
        }

        private void preset_vlow_Click(object sender, EventArgs e) {
            mode_vSync.Checked = true;
            effects_none.Checked = true;
            dist_landscape.Checked = false;
            dist_buildings.Checked = false;
            dist_trees.Checked = false;
            antialiasingCB.SelectedIndex = 0;
        }

        private void preset_low_Click(object sender, EventArgs e) {
            mode_vSync.Checked = true;
            effects_none.Checked = true;
            dist_landscape.Checked = false;
            dist_buildings.Checked = false;
            dist_trees.Checked = false;
            antialiasingCB.SelectedIndex = 1;
        }

        private void preset_medium_Click(object sender, EventArgs e) {
            mode_vSync.Checked = true;
            effects_bloom.Checked = true;
            dist_landscape.Checked = true;
            dist_buildings.Checked = false;
            dist_trees.Checked = false;
            antialiasingCB.SelectedIndex = 2;
        }

        private void preset_high_Click(object sender, EventArgs e) {
            mode_vSync.Checked = true;
            effects_bloom.Checked = true;
            dist_landscape.Checked = true;
            dist_buildings.Checked = true;
            dist_trees.Checked = true;
            antialiasingCB.SelectedIndex = 3;
        }

        private void preset_uhigh_Click(object sender, EventArgs e) {
            mode_vSync.Checked = true;
            antialiasingCB.SelectedIndex = 0;
            effects_HDR.Checked = true;
            dist_landscape.Checked = true;
            dist_buildings.Checked = true;
            dist_trees.Checked = true;
        }

        private void launchBrowseB_Click(object sender, EventArgs e) {
            DialogResult dr = browseDialog.ShowDialog();
            if (dr == DialogResult.OK) {
                launchPathTB.Text = browseDialog.FileName;
            }
        }

        private void csBrowseB_Click(object sender, EventArgs e) {
            DialogResult dr = browseDialog.ShowDialog();
            if (dr == DialogResult.OK) {
                csPathTB.Text = browseDialog.FileName;
            }
        }

        private void checkForUpdates_Click(object sender, EventArgs e) {
            if (!Main.checkForUpdates()) {
                MessageBox.Show("OCOL is up to date!");
            }
        }

        private void aboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("http://ocol.alexstek.com");
        }

        private void browseOblivionDirB_Click(object sender, EventArgs e) {
            oblivionFolderBrowser.ShowNewFolderButton = false;
            oblivionFolderBrowser.SelectedPath = oblivionFolderPathTB.Text;
            do {
                if (DialogResult.OK != oblivionFolderBrowser.ShowDialog()) {
                    return;
                }
                if (!File.Exists(oblivionFolderBrowser.SelectedPath + "\\Oblivion.exe")) {
                    MessageBox.Show("That folder does not contain a valid Oblivion installation! Try again.");
                }
            } while (!File.Exists(oblivionFolderBrowser.SelectedPath + "\\Oblivion.exe"));
            oblivionFolderPathTB.Text = oblivionFolderBrowser.SelectedPath + "\\";

        }

        private void oblivionUserDirectoryBrowseB_Click(object sender, EventArgs e) {
            oblivionFolderBrowser.ShowNewFolderButton = false;
            oblivionFolderBrowser.SelectedPath = oblivionUserDirTB.Text;
            if (DialogResult.OK != oblivionFolderBrowser.ShowDialog()) {
                return;
            }
            oblivionFolderPathTB.Text = oblivionFolderBrowser.SelectedPath + "\\";
        }

    }

}
