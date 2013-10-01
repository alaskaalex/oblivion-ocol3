namespace OCOL
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.optionTabControl = new System.Windows.Forms.TabControl();
            this.graphics = new System.Windows.Forms.TabPage();
            this.dxdiag = new System.Windows.Forms.Button();
            this.vid_qual_presets_GB = new System.Windows.Forms.GroupBox();
            this.preset_uhigh = new System.Windows.Forms.Button();
            this.preset_high = new System.Windows.Forms.Button();
            this.preset_medium = new System.Windows.Forms.Button();
            this.preset_low = new System.Windows.Forms.Button();
            this.preset_vlow = new System.Windows.Forms.Button();
            this.distantLandscapeGB = new System.Windows.Forms.GroupBox();
            this.dist_trees = new System.Windows.Forms.CheckBox();
            this.dist_buildings = new System.Windows.Forms.CheckBox();
            this.dist_landscape = new System.Windows.Forms.CheckBox();
            this.screenEffectsGB = new System.Windows.Forms.GroupBox();
            this.effects_HDR = new System.Windows.Forms.RadioButton();
            this.effects_bloom = new System.Windows.Forms.RadioButton();
            this.effects_none = new System.Windows.Forms.RadioButton();
            this.modeGB = new System.Windows.Forms.GroupBox();
            this.mode_vSync = new System.Windows.Forms.CheckBox();
            this.mode_fullscreen = new System.Windows.Forms.RadioButton();
            this.mode_windowed = new System.Windows.Forms.RadioButton();
            this.gbAdapterResolution = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.antialiasingCB = new System.Windows.Forms.ComboBox();
            this.resolutionCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adapterCB = new System.Windows.Forms.ComboBox();
            this.iniEditTab = new System.Windows.Forms.TabPage();
            this.restoreDefaultINI = new System.Windows.Forms.Button();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.iniLV = new System.Windows.Forms.DataGridView();
            this.ocolOptions = new System.Windows.Forms.TabPage();
            this.oblivionUserDirectoryBrowseB = new System.Windows.Forms.Button();
            this.oblivionUserDirTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.browseOblivionDirB = new System.Windows.Forms.Button();
            this.oblivionFolderPathTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.aboutLink = new System.Windows.Forms.LinkLabel();
            this.checkForUpdates = new System.Windows.Forms.Button();
            this.checkForOCOLUpdates = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.csArgsTB = new System.Windows.Forms.TextBox();
            this.csBrowseB = new System.Windows.Forms.Button();
            this.csPathTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.launchArgsTB = new System.Windows.Forms.TextBox();
            this.launchBrowseB = new System.Windows.Forms.Button();
            this.launchPathTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.applyB = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.browseDialog = new System.Windows.Forms.OpenFileDialog();
            this.oblivionFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.optionTabControl.SuspendLayout();
            this.graphics.SuspendLayout();
            this.vid_qual_presets_GB.SuspendLayout();
            this.distantLandscapeGB.SuspendLayout();
            this.screenEffectsGB.SuspendLayout();
            this.modeGB.SuspendLayout();
            this.gbAdapterResolution.SuspendLayout();
            this.iniEditTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iniLV)).BeginInit();
            this.ocolOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionTabControl
            // 
            this.optionTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.optionTabControl.Controls.Add(this.graphics);
            this.optionTabControl.Controls.Add(this.iniEditTab);
            this.optionTabControl.Controls.Add(this.ocolOptions);
            this.optionTabControl.Location = new System.Drawing.Point(13, 13);
            this.optionTabControl.MinimumSize = new System.Drawing.Size(561, 345);
            this.optionTabControl.Name = "optionTabControl";
            this.optionTabControl.SelectedIndex = 0;
            this.optionTabControl.Size = new System.Drawing.Size(561, 345);
            this.optionTabControl.TabIndex = 0;
            this.optionTabControl.SelectedIndexChanged += new System.EventHandler(this.optionTabControl_SelectedIndexChanged);
            // 
            // graphics
            // 
            this.graphics.Controls.Add(this.dxdiag);
            this.graphics.Controls.Add(this.vid_qual_presets_GB);
            this.graphics.Controls.Add(this.distantLandscapeGB);
            this.graphics.Controls.Add(this.screenEffectsGB);
            this.graphics.Controls.Add(this.modeGB);
            this.graphics.Controls.Add(this.gbAdapterResolution);
            this.graphics.Location = new System.Drawing.Point(4, 22);
            this.graphics.Name = "graphics";
            this.graphics.Padding = new System.Windows.Forms.Padding(3);
            this.graphics.Size = new System.Drawing.Size(553, 319);
            this.graphics.TabIndex = 0;
            this.graphics.Text = "Graphics Options";
            this.graphics.UseVisualStyleBackColor = true;
            // 
            // dxdiag
            // 
            this.dxdiag.Location = new System.Drawing.Point(7, 284);
            this.dxdiag.Name = "dxdiag";
            this.dxdiag.Size = new System.Drawing.Size(170, 28);
            this.dxdiag.TabIndex = 5;
            this.dxdiag.Text = "Launch Direct X Diagnostic";
            this.dxdiag.UseVisualStyleBackColor = true;
            this.dxdiag.Click += new System.EventHandler(this.dxdiag_Click);
            // 
            // vid_qual_presets_GB
            // 
            this.vid_qual_presets_GB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.vid_qual_presets_GB.Controls.Add(this.preset_uhigh);
            this.vid_qual_presets_GB.Controls.Add(this.preset_high);
            this.vid_qual_presets_GB.Controls.Add(this.preset_medium);
            this.vid_qual_presets_GB.Controls.Add(this.preset_low);
            this.vid_qual_presets_GB.Controls.Add(this.preset_vlow);
            this.vid_qual_presets_GB.Location = new System.Drawing.Point(6, 223);
            this.vid_qual_presets_GB.Name = "vid_qual_presets_GB";
            this.vid_qual_presets_GB.Size = new System.Drawing.Size(540, 55);
            this.vid_qual_presets_GB.TabIndex = 5;
            this.vid_qual_presets_GB.TabStop = false;
            this.vid_qual_presets_GB.Text = "Video Quality Presets";
            // 
            // preset_uhigh
            // 
            this.preset_uhigh.Location = new System.Drawing.Point(431, 19);
            this.preset_uhigh.Name = "preset_uhigh";
            this.preset_uhigh.Size = new System.Drawing.Size(99, 28);
            this.preset_uhigh.TabIndex = 4;
            this.preset_uhigh.Text = "Ultra High";
            this.preset_uhigh.UseVisualStyleBackColor = true;
            this.preset_uhigh.Click += new System.EventHandler(this.preset_uhigh_Click);
            // 
            // preset_high
            // 
            this.preset_high.Location = new System.Drawing.Point(326, 19);
            this.preset_high.Name = "preset_high";
            this.preset_high.Size = new System.Drawing.Size(99, 28);
            this.preset_high.TabIndex = 3;
            this.preset_high.Text = "High";
            this.preset_high.UseVisualStyleBackColor = true;
            this.preset_high.Click += new System.EventHandler(this.preset_high_Click);
            // 
            // preset_medium
            // 
            this.preset_medium.Location = new System.Drawing.Point(221, 19);
            this.preset_medium.Name = "preset_medium";
            this.preset_medium.Size = new System.Drawing.Size(99, 28);
            this.preset_medium.TabIndex = 2;
            this.preset_medium.Text = "Medium";
            this.preset_medium.UseVisualStyleBackColor = true;
            this.preset_medium.Click += new System.EventHandler(this.preset_medium_Click);
            // 
            // preset_low
            // 
            this.preset_low.Location = new System.Drawing.Point(116, 19);
            this.preset_low.Name = "preset_low";
            this.preset_low.Size = new System.Drawing.Size(99, 28);
            this.preset_low.TabIndex = 1;
            this.preset_low.Text = "Low";
            this.preset_low.UseVisualStyleBackColor = true;
            this.preset_low.Click += new System.EventHandler(this.preset_low_Click);
            // 
            // preset_vlow
            // 
            this.preset_vlow.Location = new System.Drawing.Point(11, 19);
            this.preset_vlow.Name = "preset_vlow";
            this.preset_vlow.Size = new System.Drawing.Size(99, 28);
            this.preset_vlow.TabIndex = 0;
            this.preset_vlow.Text = "Very Low";
            this.preset_vlow.UseVisualStyleBackColor = true;
            this.preset_vlow.Click += new System.EventHandler(this.preset_vlow_Click);
            // 
            // distantLandscapeGB
            // 
            this.distantLandscapeGB.Controls.Add(this.dist_trees);
            this.distantLandscapeGB.Controls.Add(this.dist_buildings);
            this.distantLandscapeGB.Controls.Add(this.dist_landscape);
            this.distantLandscapeGB.Location = new System.Drawing.Point(367, 122);
            this.distantLandscapeGB.Name = "distantLandscapeGB";
            this.distantLandscapeGB.Size = new System.Drawing.Size(179, 94);
            this.distantLandscapeGB.TabIndex = 4;
            this.distantLandscapeGB.TabStop = false;
            this.distantLandscapeGB.Text = "Distant Landscape";
            // 
            // dist_trees
            // 
            this.dist_trees.AutoSize = true;
            this.dist_trees.Location = new System.Drawing.Point(6, 67);
            this.dist_trees.Name = "dist_trees";
            this.dist_trees.Size = new System.Drawing.Size(89, 17);
            this.dist_trees.TabIndex = 2;
            this.dist_trees.Text = "Distant Trees";
            this.dist_trees.UseVisualStyleBackColor = true;
            this.dist_trees.CheckedChanged += new System.EventHandler(this.dist_trees_CheckedChanged);
            // 
            // dist_buildings
            // 
            this.dist_buildings.AutoSize = true;
            this.dist_buildings.Location = new System.Drawing.Point(6, 43);
            this.dist_buildings.Name = "dist_buildings";
            this.dist_buildings.Size = new System.Drawing.Size(104, 17);
            this.dist_buildings.TabIndex = 1;
            this.dist_buildings.Text = "Distant Buildings";
            this.dist_buildings.UseVisualStyleBackColor = true;
            this.dist_buildings.CheckedChanged += new System.EventHandler(this.dist_buildings_CheckedChanged);
            // 
            // dist_landscape
            // 
            this.dist_landscape.AutoSize = true;
            this.dist_landscape.Location = new System.Drawing.Point(6, 20);
            this.dist_landscape.Name = "dist_landscape";
            this.dist_landscape.Size = new System.Drawing.Size(115, 17);
            this.dist_landscape.TabIndex = 0;
            this.dist_landscape.Text = "Distant Landscape";
            this.dist_landscape.UseVisualStyleBackColor = true;
            this.dist_landscape.CheckedChanged += new System.EventHandler(this.dist_landscape_CheckedChanged);
            // 
            // screenEffectsGB
            // 
            this.screenEffectsGB.Controls.Add(this.effects_HDR);
            this.screenEffectsGB.Controls.Add(this.effects_bloom);
            this.screenEffectsGB.Controls.Add(this.effects_none);
            this.screenEffectsGB.Location = new System.Drawing.Point(182, 122);
            this.screenEffectsGB.Name = "screenEffectsGB";
            this.screenEffectsGB.Size = new System.Drawing.Size(179, 94);
            this.screenEffectsGB.TabIndex = 3;
            this.screenEffectsGB.TabStop = false;
            this.screenEffectsGB.Text = "Screen Effects";
            // 
            // effects_HDR
            // 
            this.effects_HDR.AutoSize = true;
            this.effects_HDR.Location = new System.Drawing.Point(6, 66);
            this.effects_HDR.Name = "effects_HDR";
            this.effects_HDR.Size = new System.Drawing.Size(49, 17);
            this.effects_HDR.TabIndex = 2;
            this.effects_HDR.TabStop = true;
            this.effects_HDR.Text = "HDR";
            this.effects_HDR.UseVisualStyleBackColor = true;
            this.effects_HDR.CheckedChanged += new System.EventHandler(this.effects_HDR_CheckedChanged);
            // 
            // effects_bloom
            // 
            this.effects_bloom.AutoSize = true;
            this.effects_bloom.Location = new System.Drawing.Point(6, 43);
            this.effects_bloom.Name = "effects_bloom";
            this.effects_bloom.Size = new System.Drawing.Size(54, 17);
            this.effects_bloom.TabIndex = 1;
            this.effects_bloom.TabStop = true;
            this.effects_bloom.Text = "Bloom";
            this.effects_bloom.UseVisualStyleBackColor = true;
            this.effects_bloom.CheckedChanged += new System.EventHandler(this.effects_bloom_CheckedChanged);
            // 
            // effects_none
            // 
            this.effects_none.AutoSize = true;
            this.effects_none.Location = new System.Drawing.Point(7, 20);
            this.effects_none.Name = "effects_none";
            this.effects_none.Size = new System.Drawing.Size(51, 17);
            this.effects_none.TabIndex = 0;
            this.effects_none.TabStop = true;
            this.effects_none.Text = "None";
            this.effects_none.UseVisualStyleBackColor = true;
            this.effects_none.CheckedChanged += new System.EventHandler(this.effects_none_CheckedChanged);
            // 
            // modeGB
            // 
            this.modeGB.Controls.Add(this.mode_vSync);
            this.modeGB.Controls.Add(this.mode_fullscreen);
            this.modeGB.Controls.Add(this.mode_windowed);
            this.modeGB.Location = new System.Drawing.Point(6, 122);
            this.modeGB.Name = "modeGB";
            this.modeGB.Size = new System.Drawing.Size(170, 94);
            this.modeGB.TabIndex = 1;
            this.modeGB.TabStop = false;
            this.modeGB.Text = "Mode";
            // 
            // mode_vSync
            // 
            this.mode_vSync.AutoSize = true;
            this.mode_vSync.Location = new System.Drawing.Point(7, 67);
            this.mode_vSync.Name = "mode_vSync";
            this.mode_vSync.Size = new System.Drawing.Size(63, 17);
            this.mode_vSync.TabIndex = 2;
            this.mode_vSync.Text = "V. Sync";
            this.mode_vSync.UseVisualStyleBackColor = true;
            this.mode_vSync.CheckedChanged += new System.EventHandler(this.mode_vSync_CheckedChanged);
            // 
            // mode_fullscreen
            // 
            this.mode_fullscreen.AutoSize = true;
            this.mode_fullscreen.Location = new System.Drawing.Point(7, 43);
            this.mode_fullscreen.Name = "mode_fullscreen";
            this.mode_fullscreen.Size = new System.Drawing.Size(73, 17);
            this.mode_fullscreen.TabIndex = 1;
            this.mode_fullscreen.TabStop = true;
            this.mode_fullscreen.Text = "Fullscreen";
            this.mode_fullscreen.UseVisualStyleBackColor = true;
            this.mode_fullscreen.CheckedChanged += new System.EventHandler(this.mode_fullscreen_CheckedChanged);
            // 
            // mode_windowed
            // 
            this.mode_windowed.AutoSize = true;
            this.mode_windowed.Location = new System.Drawing.Point(7, 20);
            this.mode_windowed.Name = "mode_windowed";
            this.mode_windowed.Size = new System.Drawing.Size(76, 17);
            this.mode_windowed.TabIndex = 0;
            this.mode_windowed.TabStop = true;
            this.mode_windowed.Text = "Windowed";
            this.mode_windowed.UseVisualStyleBackColor = true;
            this.mode_windowed.CheckedChanged += new System.EventHandler(this.mode_windowed_CheckedChanged);
            // 
            // gbAdapterResolution
            // 
            this.gbAdapterResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAdapterResolution.Controls.Add(this.label3);
            this.gbAdapterResolution.Controls.Add(this.label2);
            this.gbAdapterResolution.Controls.Add(this.antialiasingCB);
            this.gbAdapterResolution.Controls.Add(this.resolutionCB);
            this.gbAdapterResolution.Controls.Add(this.label1);
            this.gbAdapterResolution.Controls.Add(this.adapterCB);
            this.gbAdapterResolution.Location = new System.Drawing.Point(6, 7);
            this.gbAdapterResolution.Name = "gbAdapterResolution";
            this.gbAdapterResolution.Size = new System.Drawing.Size(540, 108);
            this.gbAdapterResolution.TabIndex = 0;
            this.gbAdapterResolution.TabStop = false;
            this.gbAdapterResolution.Text = "Graphics Adapter and Resolution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Antialiasing:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resolution:";
            // 
            // antialiasingCB
            // 
            this.antialiasingCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.antialiasingCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.antialiasingCB.FormattingEnabled = true;
            this.antialiasingCB.Items.AddRange(new object[] {
            "None (best performance)",
            "2 samples",
            "4 samples",
            "8 samples (highest quality)"});
            this.antialiasingCB.Location = new System.Drawing.Point(116, 74);
            this.antialiasingCB.Name = "antialiasingCB";
            this.antialiasingCB.Size = new System.Drawing.Size(418, 21);
            this.antialiasingCB.TabIndex = 3;
            this.antialiasingCB.SelectedIndexChanged += new System.EventHandler(this.antialiasingCB_SelectedIndexChanged);
            // 
            // resolutionCB
            // 
            this.resolutionCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.resolutionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionCB.FormattingEnabled = true;
            this.resolutionCB.Location = new System.Drawing.Point(116, 47);
            this.resolutionCB.Name = "resolutionCB";
            this.resolutionCB.Size = new System.Drawing.Size(418, 21);
            this.resolutionCB.TabIndex = 2;
            this.resolutionCB.SelectedIndexChanged += new System.EventHandler(this.resolutionCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adapter:";
            // 
            // adapterCB
            // 
            this.adapterCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.adapterCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.adapterCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.adapterCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adapterCB.FormattingEnabled = true;
            this.adapterCB.Location = new System.Drawing.Point(116, 20);
            this.adapterCB.Name = "adapterCB";
            this.adapterCB.Size = new System.Drawing.Size(418, 21);
            this.adapterCB.TabIndex = 0;
            this.adapterCB.SelectedIndexChanged += new System.EventHandler(this.adapterCB_SelectedIndexChanged);
            // 
            // iniEditTab
            // 
            this.iniEditTab.Controls.Add(this.restoreDefaultINI);
            this.iniEditTab.Controls.Add(this.filterBox);
            this.iniEditTab.Controls.Add(this.iniLV);
            this.iniEditTab.Location = new System.Drawing.Point(4, 22);
            this.iniEditTab.Name = "iniEditTab";
            this.iniEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.iniEditTab.Size = new System.Drawing.Size(553, 319);
            this.iniEditTab.TabIndex = 1;
            this.iniEditTab.Text = "Oblivion.INI Options";
            this.iniEditTab.UseVisualStyleBackColor = true;
            // 
            // restoreDefaultINI
            // 
            this.restoreDefaultINI.Location = new System.Drawing.Point(6, 7);
            this.restoreDefaultINI.Name = "restoreDefaultINI";
            this.restoreDefaultINI.Size = new System.Drawing.Size(188, 30);
            this.restoreDefaultINI.TabIndex = 5;
            this.restoreDefaultINI.Text = "Restore Default INI Settings";
            this.restoreDefaultINI.UseVisualStyleBackColor = true;
            this.restoreDefaultINI.Click += new System.EventHandler(this.restoreDefaultINI_Click);
            // 
            // filterBox
            // 
            this.filterBox.AcceptsTab = true;
            this.filterBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.filterBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.filterBox.Location = new System.Drawing.Point(201, 7);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(346, 20);
            this.filterBox.TabIndex = 4;
            this.filterBox.Text = "Filter";
            this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
            this.filterBox.GotFocus += new System.EventHandler(this.filterBox_GotFocus);
            this.filterBox.LostFocus += new System.EventHandler(this.filterBox_LostFocus);
            // 
            // iniLV
            // 
            this.iniLV.AllowUserToAddRows = false;
            this.iniLV.AllowUserToDeleteRows = false;
            this.iniLV.AllowUserToResizeRows = false;
            this.iniLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.iniLV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.iniLV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iniLV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.iniLV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.iniLV.GridColor = System.Drawing.SystemColors.ControlLight;
            this.iniLV.Location = new System.Drawing.Point(201, 34);
            this.iniLV.MultiSelect = false;
            this.iniLV.Name = "iniLV";
            this.iniLV.RowHeadersVisible = false;
            this.iniLV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.iniLV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.iniLV.Size = new System.Drawing.Size(346, 279);
            this.iniLV.TabIndex = 3;
            this.iniLV.DoubleClick += new System.EventHandler(this.iniLV_DoubleClick);
            this.iniLV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iniLV_KeyDown);
            // 
            // ocolOptions
            // 
            this.ocolOptions.Controls.Add(this.oblivionUserDirectoryBrowseB);
            this.ocolOptions.Controls.Add(this.oblivionUserDirTB);
            this.ocolOptions.Controls.Add(this.label9);
            this.ocolOptions.Controls.Add(this.browseOblivionDirB);
            this.ocolOptions.Controls.Add(this.oblivionFolderPathTB);
            this.ocolOptions.Controls.Add(this.label8);
            this.ocolOptions.Controls.Add(this.aboutLink);
            this.ocolOptions.Controls.Add(this.checkForUpdates);
            this.ocolOptions.Controls.Add(this.checkForOCOLUpdates);
            this.ocolOptions.Controls.Add(this.label6);
            this.ocolOptions.Controls.Add(this.csArgsTB);
            this.ocolOptions.Controls.Add(this.csBrowseB);
            this.ocolOptions.Controls.Add(this.csPathTB);
            this.ocolOptions.Controls.Add(this.label7);
            this.ocolOptions.Controls.Add(this.label5);
            this.ocolOptions.Controls.Add(this.launchArgsTB);
            this.ocolOptions.Controls.Add(this.launchBrowseB);
            this.ocolOptions.Controls.Add(this.launchPathTB);
            this.ocolOptions.Controls.Add(this.label4);
            this.ocolOptions.Location = new System.Drawing.Point(4, 22);
            this.ocolOptions.Name = "ocolOptions";
            this.ocolOptions.Padding = new System.Windows.Forms.Padding(3);
            this.ocolOptions.Size = new System.Drawing.Size(553, 319);
            this.ocolOptions.TabIndex = 2;
            this.ocolOptions.Text = "OCOL Options";
            this.ocolOptions.UseVisualStyleBackColor = true;
            // 
            // oblivionUserDirectoryBrowseB
            // 
            this.oblivionUserDirectoryBrowseB.Location = new System.Drawing.Point(472, 168);
            this.oblivionUserDirectoryBrowseB.Name = "oblivionUserDirectoryBrowseB";
            this.oblivionUserDirectoryBrowseB.Size = new System.Drawing.Size(75, 23);
            this.oblivionUserDirectoryBrowseB.TabIndex = 18;
            this.oblivionUserDirectoryBrowseB.Text = "Browse...";
            this.oblivionUserDirectoryBrowseB.UseVisualStyleBackColor = true;
            this.oblivionUserDirectoryBrowseB.Click += new System.EventHandler(this.oblivionUserDirectoryBrowseB_Click);
            // 
            // oblivionUserDirTB
            // 
            this.oblivionUserDirTB.AccessibleDescription = "savedLaunchersXml";
            this.oblivionUserDirTB.Location = new System.Drawing.Point(173, 170);
            this.oblivionUserDirTB.Name = "oblivionUserDirTB";
            this.oblivionUserDirTB.Size = new System.Drawing.Size(293, 20);
            this.oblivionUserDirTB.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Path to Oblivion User Directory:";
            // 
            // browseOblivionDirB
            // 
            this.browseOblivionDirB.Location = new System.Drawing.Point(472, 139);
            this.browseOblivionDirB.Name = "browseOblivionDirB";
            this.browseOblivionDirB.Size = new System.Drawing.Size(75, 23);
            this.browseOblivionDirB.TabIndex = 15;
            this.browseOblivionDirB.Text = "Browse...";
            this.browseOblivionDirB.UseVisualStyleBackColor = true;
            this.browseOblivionDirB.Click += new System.EventHandler(this.browseOblivionDirB_Click);
            // 
            // oblivionFolderPathTB
            // 
            this.oblivionFolderPathTB.AccessibleDescription = "savedLaunchersXml";
            this.oblivionFolderPathTB.Location = new System.Drawing.Point(136, 141);
            this.oblivionFolderPathTB.Name = "oblivionFolderPathTB";
            this.oblivionFolderPathTB.Size = new System.Drawing.Size(330, 20);
            this.oblivionFolderPathTB.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Path to Oblivion Directory:";
            // 
            // aboutLink
            // 
            this.aboutLink.AutoSize = true;
            this.aboutLink.Location = new System.Drawing.Point(503, 303);
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.Size = new System.Drawing.Size(44, 13);
            this.aboutLink.TabIndex = 12;
            this.aboutLink.TabStop = true;
            this.aboutLink.Text = "About...";
            this.aboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLink_LinkClicked);
            // 
            // checkForUpdates
            // 
            this.checkForUpdates.Location = new System.Drawing.Point(415, 277);
            this.checkForUpdates.Name = "checkForUpdates";
            this.checkForUpdates.Size = new System.Drawing.Size(132, 23);
            this.checkForUpdates.TabIndex = 11;
            this.checkForUpdates.Text = "Check For Updates";
            this.checkForUpdates.UseVisualStyleBackColor = true;
            this.checkForUpdates.Click += new System.EventHandler(this.checkForUpdates_Click);
            // 
            // checkForOCOLUpdates
            // 
            this.checkForOCOLUpdates.AutoSize = true;
            this.checkForOCOLUpdates.Location = new System.Drawing.Point(6, 277);
            this.checkForOCOLUpdates.Name = "checkForOCOLUpdates";
            this.checkForOCOLUpdates.Size = new System.Drawing.Size(147, 17);
            this.checkForOCOLUpdates.TabIndex = 10;
            this.checkForOCOLUpdates.Text = "Check for OCOL Updates";
            this.checkForOCOLUpdates.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Arguments to Construction Set:";
            // 
            // csArgsTB
            // 
            this.csArgsTB.AccessibleDescription = "savedLaunchersXml";
            this.csArgsTB.Location = new System.Drawing.Point(173, 102);
            this.csArgsTB.Name = "csArgsTB";
            this.csArgsTB.Size = new System.Drawing.Size(374, 20);
            this.csArgsTB.TabIndex = 8;
            // 
            // csBrowseB
            // 
            this.csBrowseB.Location = new System.Drawing.Point(472, 74);
            this.csBrowseB.Name = "csBrowseB";
            this.csBrowseB.Size = new System.Drawing.Size(75, 23);
            this.csBrowseB.TabIndex = 7;
            this.csBrowseB.Text = "Browse...";
            this.csBrowseB.UseVisualStyleBackColor = true;
            this.csBrowseB.Click += new System.EventHandler(this.csBrowseB_Click);
            // 
            // csPathTB
            // 
            this.csPathTB.AccessibleDescription = "savedLaunchersXml";
            this.csPathTB.Location = new System.Drawing.Point(136, 76);
            this.csPathTB.Name = "csPathTB";
            this.csPathTB.Size = new System.Drawing.Size(330, 20);
            this.csPathTB.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Path to Construction Set:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Arguments to Oblivion Launcher:";
            // 
            // launchArgsTB
            // 
            this.launchArgsTB.AccessibleDescription = "savedLaunchersXml";
            this.launchArgsTB.Location = new System.Drawing.Point(173, 33);
            this.launchArgsTB.Name = "launchArgsTB";
            this.launchArgsTB.Size = new System.Drawing.Size(374, 20);
            this.launchArgsTB.TabIndex = 3;
            // 
            // launchBrowseB
            // 
            this.launchBrowseB.Location = new System.Drawing.Point(472, 5);
            this.launchBrowseB.Name = "launchBrowseB";
            this.launchBrowseB.Size = new System.Drawing.Size(75, 23);
            this.launchBrowseB.TabIndex = 2;
            this.launchBrowseB.Text = "Browse...";
            this.launchBrowseB.UseVisualStyleBackColor = true;
            this.launchBrowseB.Click += new System.EventHandler(this.launchBrowseB_Click);
            // 
            // launchPathTB
            // 
            this.launchPathTB.AccessibleDescription = "savedLaunchersXml";
            this.launchPathTB.Location = new System.Drawing.Point(136, 7);
            this.launchPathTB.Name = "launchPathTB";
            this.launchPathTB.Size = new System.Drawing.Size(330, 20);
            this.launchPathTB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Path to Launch Oblivion:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.applyB);
            this.panel1.Controls.Add(this.ok);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Location = new System.Drawing.Point(244, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 30);
            this.panel1.TabIndex = 1;
            // 
            // applyB
            // 
            this.applyB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyB.Location = new System.Drawing.Point(116, 0);
            this.applyB.Name = "applyB";
            this.applyB.Size = new System.Drawing.Size(104, 30);
            this.applyB.TabIndex = 2;
            this.applyB.Text = "Apply";
            this.applyB.UseVisualStyleBackColor = true;
            this.applyB.Click += new System.EventHandler(this.applyB_Click);
            // 
            // ok
            // 
            this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ok.Location = new System.Drawing.Point(226, 0);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(104, 30);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(6, 0);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(104, 30);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // browseDialog
            // 
            this.browseDialog.DefaultExt = "Oblivion.exe";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.optionTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(602, 444);
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Load += new System.EventHandler(this.Options_Load);
            this.optionTabControl.ResumeLayout(false);
            this.graphics.ResumeLayout(false);
            this.vid_qual_presets_GB.ResumeLayout(false);
            this.distantLandscapeGB.ResumeLayout(false);
            this.distantLandscapeGB.PerformLayout();
            this.screenEffectsGB.ResumeLayout(false);
            this.screenEffectsGB.PerformLayout();
            this.modeGB.ResumeLayout(false);
            this.modeGB.PerformLayout();
            this.gbAdapterResolution.ResumeLayout(false);
            this.gbAdapterResolution.PerformLayout();
            this.iniEditTab.ResumeLayout(false);
            this.iniEditTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iniLV)).EndInit();
            this.ocolOptions.ResumeLayout(false);
            this.ocolOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TabControl optionTabControl;
        private System.Windows.Forms.TabPage graphics;
        private System.Windows.Forms.TabPage iniEditTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.GroupBox gbAdapterResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox adapterCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox antialiasingCB;
        private System.Windows.Forms.ComboBox resolutionCB;
        private System.Windows.Forms.GroupBox distantLandscapeGB;
        private System.Windows.Forms.GroupBox screenEffectsGB;
        private System.Windows.Forms.RadioButton effects_HDR;
        private System.Windows.Forms.RadioButton effects_bloom;
        private System.Windows.Forms.RadioButton effects_none;
        private System.Windows.Forms.GroupBox modeGB;
        private System.Windows.Forms.CheckBox mode_vSync;
        private System.Windows.Forms.RadioButton mode_fullscreen;
        private System.Windows.Forms.RadioButton mode_windowed;
        private System.Windows.Forms.GroupBox vid_qual_presets_GB;
        private System.Windows.Forms.Button preset_low;
        private System.Windows.Forms.Button preset_vlow;
        private System.Windows.Forms.CheckBox dist_trees;
        private System.Windows.Forms.CheckBox dist_buildings;
        private System.Windows.Forms.CheckBox dist_landscape;
        private System.Windows.Forms.Button dxdiag;
        private System.Windows.Forms.Button preset_uhigh;
        private System.Windows.Forms.Button preset_high;
        private System.Windows.Forms.Button preset_medium;
        private System.Windows.Forms.DataGridView iniLV;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Button applyB;
        private System.Windows.Forms.Button restoreDefaultINI;
        private System.Windows.Forms.TabPage ocolOptions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox launchArgsTB;
        private System.Windows.Forms.Button launchBrowseB;
        private System.Windows.Forms.TextBox launchPathTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog browseDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox csArgsTB;
        private System.Windows.Forms.Button csBrowseB;
        private System.Windows.Forms.TextBox csPathTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkForOCOLUpdates;
        private System.Windows.Forms.Button checkForUpdates;
        private System.Windows.Forms.LinkLabel aboutLink;
        private System.Windows.Forms.Button browseOblivionDirB;
        private System.Windows.Forms.TextBox oblivionFolderPathTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FolderBrowserDialog oblivionFolderBrowser;
        private System.Windows.Forms.Button oblivionUserDirectoryBrowseB;
        private System.Windows.Forms.TextBox oblivionUserDirTB;
        private System.Windows.Forms.Label label9;
    }
}