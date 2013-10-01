namespace OCOL {
    partial class Utilities {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LauncherGB = new System.Windows.Forms.GroupBox();
            this.switchEditLink = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.testB = new System.Windows.Forms.Button();
            this.saveB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.argumentTB = new System.Windows.Forms.TextBox();
            this.browseB = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.utilityPathTB = new System.Windows.Forms.TextBox();
            this.browseDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LauncherGB
            // 
            this.LauncherGB.Location = new System.Drawing.Point(12, 12);
            this.LauncherGB.Name = "LauncherGB";
            this.LauncherGB.Size = new System.Drawing.Size(388, 175);
            this.LauncherGB.TabIndex = 5;
            this.LauncherGB.TabStop = false;
            this.LauncherGB.Text = "Utility Applications";
            // 
            // switchEditLink
            // 
            this.switchEditLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.switchEditLink.AutoSize = true;
            this.switchEditLink.Location = new System.Drawing.Point(308, 191);
            this.switchEditLink.Name = "switchEditLink";
            this.switchEditLink.Size = new System.Drawing.Size(103, 13);
            this.switchEditLink.TabIndex = 6;
            this.switchEditLink.TabStop = true;
            this.switchEditLink.Text = "Show Edit Options...";
            this.switchEditLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.switchEditLink_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameTB);
            this.groupBox1.Controls.Add(this.testB);
            this.groupBox1.Controls.Add(this.saveB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.argumentTB);
            this.groupBox1.Controls.Add(this.browseB);
            this.groupBox1.Controls.Add(this.path);
            this.groupBox1.Controls.Add(this.utilityPathTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 101);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Button Name:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(84, 71);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(156, 20);
            this.nameTB.TabIndex = 7;
            // 
            // testB
            // 
            this.testB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testB.Location = new System.Drawing.Point(419, 71);
            this.testB.Name = "testB";
            this.testB.Size = new System.Drawing.Size(75, 23);
            this.testB.TabIndex = 6;
            this.testB.Text = "Test";
            this.testB.UseVisualStyleBackColor = true;
            this.testB.Click += new System.EventHandler(this.testB_Click);
            // 
            // saveB
            // 
            this.saveB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveB.Location = new System.Drawing.Point(500, 71);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(75, 23);
            this.saveB.TabIndex = 5;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arguments:";
            // 
            // argumentTB
            // 
            this.argumentTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.argumentTB.Location = new System.Drawing.Point(72, 45);
            this.argumentTB.Name = "argumentTB";
            this.argumentTB.Size = new System.Drawing.Size(502, 20);
            this.argumentTB.TabIndex = 3;
            // 
            // browseB
            // 
            this.browseB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseB.Location = new System.Drawing.Point(499, 17);
            this.browseB.Name = "browseB";
            this.browseB.Size = new System.Drawing.Size(75, 23);
            this.browseB.TabIndex = 2;
            this.browseB.Text = "Browse...";
            this.browseB.UseVisualStyleBackColor = true;
            this.browseB.Click += new System.EventHandler(this.browseB_Click);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(6, 22);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(60, 13);
            this.path.TabIndex = 1;
            this.path.Text = "Utility Path:";
            // 
            // utilityPathTB
            // 
            this.utilityPathTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.utilityPathTB.Location = new System.Drawing.Point(72, 19);
            this.utilityPathTB.Name = "utilityPathTB";
            this.utilityPathTB.Size = new System.Drawing.Size(421, 20);
            this.utilityPathTB.TabIndex = 0;
            // 
            // Utilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 207);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.switchEditLink);
            this.Controls.Add(this.LauncherGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(423, 235);
            this.Name = "Utilities";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Utilities";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Utilities_FormClosing);
            this.Load += new System.EventHandler(this.Utilities_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LauncherGB;
        private System.Windows.Forms.LinkLabel switchEditLink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox utilityPathTB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox argumentTB;
        private System.Windows.Forms.Button browseB;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.OpenFileDialog browseDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button testB;
    }
}