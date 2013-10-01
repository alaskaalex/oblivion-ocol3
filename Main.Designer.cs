namespace OCOL
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.playButton = new System.Windows.Forms.Button();
            this.dataButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.csButton = new System.Windows.Forms.Button();
            this.utilitiesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.Preloader = new System.ComponentModel.BackgroundWorker();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.VersionCounter = new System.Windows.Forms.Label();
            this.OblivionVersionCounter = new System.Windows.Forms.Label();
            this.obseVersionCounter = new System.Windows.Forms.Label();
            this.oblivionFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Image = global::OCOL.Properties.Resources.playOff;
            this.playButton.Location = new System.Drawing.Point(299, 105);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(249, 38);
            this.playButton.TabIndex = 0;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.playButton_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            // 
            // dataButton
            // 
            this.dataButton.BackColor = System.Drawing.Color.Transparent;
            this.dataButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataButton.FlatAppearance.BorderSize = 0;
            this.dataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataButton.ForeColor = System.Drawing.Color.Transparent;
            this.dataButton.Image = global::OCOL.Properties.Resources.dataOff;
            this.dataButton.Location = new System.Drawing.Point(299, 143);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(249, 38);
            this.dataButton.TabIndex = 1;
            this.dataButton.UseVisualStyleBackColor = false;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            this.dataButton.MouseEnter += new System.EventHandler(this.dataButton_MouseEnter);
            this.dataButton.MouseLeave += new System.EventHandler(this.dataButton_MouseLeave);
            // 
            // optionsButton
            // 
            this.optionsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.optionsButton.FlatAppearance.BorderSize = 0;
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.Image = global::OCOL.Properties.Resources.optionsOff;
            this.optionsButton.Location = new System.Drawing.Point(299, 181);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(249, 38);
            this.optionsButton.TabIndex = 2;
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            this.optionsButton.MouseEnter += new System.EventHandler(this.optionsButton_MouseEnter);
            this.optionsButton.MouseLeave += new System.EventHandler(this.optionsButton_MouseLeave);
            // 
            // csButton
            // 
            this.csButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.csButton.FlatAppearance.BorderSize = 0;
            this.csButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csButton.Image = global::OCOL.Properties.Resources.csOff;
            this.csButton.Location = new System.Drawing.Point(299, 219);
            this.csButton.Name = "csButton";
            this.csButton.Size = new System.Drawing.Size(249, 38);
            this.csButton.TabIndex = 3;
            this.csButton.UseVisualStyleBackColor = true;
            this.csButton.Click += new System.EventHandler(this.csButton_Click);
            this.csButton.MouseEnter += new System.EventHandler(this.csButton_MouseEnter);
            this.csButton.MouseLeave += new System.EventHandler(this.csButton_MouseLeave);
            // 
            // utilitiesButton
            // 
            this.utilitiesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.utilitiesButton.FlatAppearance.BorderSize = 0;
            this.utilitiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.utilitiesButton.Image = global::OCOL.Properties.Resources.utilitiesOff;
            this.utilitiesButton.Location = new System.Drawing.Point(299, 257);
            this.utilitiesButton.Name = "utilitiesButton";
            this.utilitiesButton.Size = new System.Drawing.Size(249, 38);
            this.utilitiesButton.TabIndex = 4;
            this.utilitiesButton.UseVisualStyleBackColor = true;
            this.utilitiesButton.Click += new System.EventHandler(this.utilitiesButton_Click);
            this.utilitiesButton.MouseEnter += new System.EventHandler(this.utilitiesButton_MouseEnter);
            this.utilitiesButton.MouseLeave += new System.EventHandler(this.utilitiesButton_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::OCOL.Properties.Resources.exitOff;
            this.exitButton.Location = new System.Drawing.Point(299, 333);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(249, 38);
            this.exitButton.TabIndex = 5;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // Preloader
            // 
            this.Preloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Preloader_DoWork);
            this.Preloader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Preloader_RunWorkerCompleted);
            // 
            // uninstallButton
            // 
            this.uninstallButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uninstallButton.FlatAppearance.BorderSize = 0;
            this.uninstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallButton.Image = global::OCOL.Properties.Resources.uninstallOff;
            this.uninstallButton.Location = new System.Drawing.Point(299, 295);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(249, 38);
            this.uninstallButton.TabIndex = 6;
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            this.uninstallButton.MouseEnter += new System.EventHandler(this.uninstallButton_MouseEnter);
            this.uninstallButton.MouseLeave += new System.EventHandler(this.uninstallButton_MouseLeave);
            // 
            // VersionCounter
            // 
            this.VersionCounter.AutoSize = true;
            this.VersionCounter.BackColor = System.Drawing.Color.Transparent;
            this.VersionCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.VersionCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(108)))), ((int)(((byte)(23)))));
            this.VersionCounter.Location = new System.Drawing.Point(74, 392);
            this.VersionCounter.Name = "VersionCounter";
            this.VersionCounter.Size = new System.Drawing.Size(74, 13);
            this.VersionCounter.TabIndex = 7;
            this.VersionCounter.Text = "OCOL Version";
            // 
            // OblivionVersionCounter
            // 
            this.OblivionVersionCounter.AutoSize = true;
            this.OblivionVersionCounter.BackColor = System.Drawing.Color.Transparent;
            this.OblivionVersionCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.OblivionVersionCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(108)))), ((int)(((byte)(23)))));
            this.OblivionVersionCounter.Location = new System.Drawing.Point(74, 379);
            this.OblivionVersionCounter.Name = "OblivionVersionCounter";
            this.OblivionVersionCounter.Size = new System.Drawing.Size(83, 13);
            this.OblivionVersionCounter.TabIndex = 8;
            this.OblivionVersionCounter.Text = "Oblivion Version";
            // 
            // obseVersionCounter
            // 
            this.obseVersionCounter.AutoSize = true;
            this.obseVersionCounter.BackColor = System.Drawing.Color.Transparent;
            this.obseVersionCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.obseVersionCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(108)))), ((int)(((byte)(23)))));
            this.obseVersionCounter.Location = new System.Drawing.Point(74, 366);
            this.obseVersionCounter.Name = "obseVersionCounter";
            this.obseVersionCounter.Size = new System.Drawing.Size(74, 13);
            this.obseVersionCounter.TabIndex = 9;
            this.obseVersionCounter.Text = "OBSE Version";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OCOL.Properties.Resources.launcherBackground;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.obseVersionCounter);
            this.Controls.Add(this.OblivionVersionCounter);
            this.Controls.Add(this.VersionCounter);
            this.Controls.Add(this.uninstallButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.utilitiesButton);
            this.Controls.Add(this.csButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.dataButton);
            this.Controls.Add(this.playButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCOL Oblivion Launcher";
            this.Activated += new System.EventHandler(this.main_Activated);
            this.Load += new System.EventHandler(this.main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.main_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button dataButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button csButton;
        private System.Windows.Forms.Button utilitiesButton;
        private System.Windows.Forms.Button exitButton;
        private System.ComponentModel.BackgroundWorker Preloader;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Label VersionCounter;
        private System.Windows.Forms.Label OblivionVersionCounter;
        private System.Windows.Forms.Label obseVersionCounter;
        private System.Windows.Forms.FolderBrowserDialog oblivionFolderBrowser;
    }
}

