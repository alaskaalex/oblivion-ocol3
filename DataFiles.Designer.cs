namespace OCOL
{
    partial class DataFiles
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
            this.components = new System.ComponentModel.Container();
            this.filesCLB = new System.Windows.Forms.CheckedListBox();
            this.contextMenu_pluginsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toggleEnabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.moveToTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.enableAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filename = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.modified = new System.Windows.Forms.Label();
            this.created = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenu_pluginsList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesCLB
            // 
            this.filesCLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.filesCLB.CheckOnClick = true;
            this.filesCLB.ContextMenuStrip = this.contextMenu_pluginsList;
            this.filesCLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filesCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesCLB.FormattingEnabled = true;
            this.filesCLB.Location = new System.Drawing.Point(13, 28);
            this.filesCLB.Name = "filesCLB";
            this.filesCLB.Size = new System.Drawing.Size(196, 292);
            this.filesCLB.TabIndex = 0;
            this.filesCLB.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.filesCLB_ItemCheck);
            this.filesCLB.SelectedIndexChanged += new System.EventHandler(this.filesCLB_SelectedIndexChanged);
            this.filesCLB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filesCLB_MouseDown);
            this.filesCLB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.filesCLB_MouseMove);
            this.filesCLB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.filesCLB_MouseUp);
            // 
            // contextMenu_pluginsList
            // 
            this.contextMenu_pluginsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleEnabledToolStripMenuItem,
            this.toolStripSeparator2,
            this.moveToTopToolStripMenuItem,
            this.moveToBottomToolStripMenuItem,
            this.toolStripSeparator1,
            this.enableAllToolStripMenuItem,
            this.disableAllToolStripMenuItem});
            this.contextMenu_pluginsList.Name = "contextMenu_pluginsList";
            this.contextMenu_pluginsList.ShowImageMargin = false;
            this.contextMenu_pluginsList.Size = new System.Drawing.Size(140, 148);
            // 
            // toggleEnabledToolStripMenuItem
            // 
            this.toggleEnabledToolStripMenuItem.Name = "toggleEnabledToolStripMenuItem";
            this.toggleEnabledToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.toggleEnabledToolStripMenuItem.Text = "Toggle Enabled";
            this.toggleEnabledToolStripMenuItem.Click += new System.EventHandler(this.toggleEnabledToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // moveToTopToolStripMenuItem
            // 
            this.moveToTopToolStripMenuItem.Name = "moveToTopToolStripMenuItem";
            this.moveToTopToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.moveToTopToolStripMenuItem.Text = "Move To Top";
            this.moveToTopToolStripMenuItem.Click += new System.EventHandler(this.moveToTopToolStripMenuItem_Click);
            // 
            // moveToBottomToolStripMenuItem
            // 
            this.moveToBottomToolStripMenuItem.Name = "moveToBottomToolStripMenuItem";
            this.moveToBottomToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.moveToBottomToolStripMenuItem.Text = "Move To Bottom";
            this.moveToBottomToolStripMenuItem.Click += new System.EventHandler(this.moveToBottomToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // enableAllToolStripMenuItem
            // 
            this.enableAllToolStripMenuItem.Name = "enableAllToolStripMenuItem";
            this.enableAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.enableAllToolStripMenuItem.Text = "Enable All";
            this.enableAllToolStripMenuItem.Click += new System.EventHandler(this.enableAllToolStripMenuItem_Click);
            // 
            // disableAllToolStripMenuItem
            // 
            this.disableAllToolStripMenuItem.Name = "disableAllToolStripMenuItem";
            this.disableAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.disableAllToolStripMenuItem.Text = "Disable All";
            this.disableAllToolStripMenuItem.Click += new System.EventHandler(this.disableAllToolStripMenuItem_Click);
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Location = new System.Drawing.Point(3, 28);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(54, 13);
            this.filename.TabIndex = 1;
            this.filename.Text = "File Name";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(3, 41);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(38, 13);
            this.author.TabIndex = 2;
            this.author.Text = "Author";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(0, 55);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(174, 220);
            this.description.TabIndex = 3;
            this.description.Text = "";
            // 
            // modified
            // 
            this.modified.AutoSize = true;
            this.modified.Location = new System.Drawing.Point(3, 291);
            this.modified.Name = "modified";
            this.modified.Size = new System.Drawing.Size(53, 13);
            this.modified.TabIndex = 4;
            this.modified.Text = "Modified: ";
            // 
            // created
            // 
            this.created.AutoSize = true;
            this.created.Location = new System.Drawing.Point(3, 278);
            this.created.Name = "created";
            this.created.Size = new System.Drawing.Size(50, 13);
            this.created.TabIndex = 5;
            this.created.Text = "Created: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data Files:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.filename);
            this.panel1.Controls.Add(this.author);
            this.panel1.Controls.Add(this.modified);
            this.panel1.Controls.Add(this.created);
            this.panel1.Controls.Add(this.description);
            this.panel1.Location = new System.Drawing.Point(215, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 312);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(13, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 36);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.acceptButton);
            this.panel3.Controls.Add(this.cancelButton);
            this.panel3.Location = new System.Drawing.Point(202, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 32);
            this.panel3.TabIndex = 0;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(90, 3);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(80, 26);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(6, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 26);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "(Drag and drop to change load order)";
            // 
            // DataFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(401, 374);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filesCLB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(417, 412);
            this.Name = "DataFiles";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Files";
            this.Load += new System.EventHandler(this.DataFiles_Load);
            this.contextMenu_pluginsList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox filesCLB;
        private System.Windows.Forms.Label filename;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label modified;
        private System.Windows.Forms.Label created;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ContextMenuStrip contextMenu_pluginsList;
        private System.Windows.Forms.ToolStripMenuItem toggleEnabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToBottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
    }
}