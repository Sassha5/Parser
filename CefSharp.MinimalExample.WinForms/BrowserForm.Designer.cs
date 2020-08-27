namespace CefSharp.MinimalExample.WinForms
{
    partial class BrowserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.Song = new System.Windows.Forms.ColumnHeader();
            this.Artist = new System.Windows.Forms.ColumnHeader();
            this.Album = new System.Windows.Forms.ColumnHeader();
            this.Duration = new System.Windows.Forms.ColumnHeader();
            this.textBoxToParse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonParse = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.parseButton = new System.Windows.Forms.Button();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // 
            // 
            this.toolStripContainer.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.BottomToolStripPanel.Name = "";
            this.toolStripContainer.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripContainer.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // 
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.statusLabel);
            this.toolStripContainer.ContentPanel.Controls.Add(this.outputLabel);
            this.toolStripContainer.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(999, 622);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.toolStripContainer.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.LeftToolStripPanel.Name = "";
            this.toolStripContainer.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripContainer.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripContainer.LeftToolStripPanel.Visible = false;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toolStripContainer.Name = "toolStripContainer";
            // 
            // 
            // 
            this.toolStripContainer.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.RightToolStripPanel.Name = "";
            this.toolStripContainer.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripContainer.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripContainer.RightToolStripPanel.Visible = false;
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(999, 622);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // 
            // 
            this.toolStripContainer.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.TopToolStripPanel.Name = "";
            this.toolStripContainer.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripContainer.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripContainer.TopToolStripPanel.Size = new System.Drawing.Size(852, 29);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Location = new System.Drawing.Point(0, 592);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 15);
            this.statusLabel.TabIndex = 1;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputLabel.Location = new System.Drawing.Point(0, 607);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 15);
            this.outputLabel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(1638, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(81, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Song,
            this.Artist,
            this.Album,
            this.Duration});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 41);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(975, 569);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // Song
            // 
            this.Song.Text = "Song";
            // 
            // Artist
            // 
            this.Artist.Text = "Artist";
            // 
            // Album
            // 
            this.Album.Text = "Album";
            // 
            // Duration
            // 
            this.Duration.Text = "Duration";
            // 
            // textBoxToParse
            // 
            this.textBoxToParse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxToParse.Location = new System.Drawing.Point(12, 12);
            this.textBoxToParse.MinimumSize = new System.Drawing.Size(100, 0);
            this.textBoxToParse.Name = "textBoxToParse";
            this.textBoxToParse.Size = new System.Drawing.Size(812, 23);
            this.textBoxToParse.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-235, -87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Moov link to parse";
            // 
            // buttonParse
            // 
            this.buttonParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonParse.Location = new System.Drawing.Point(1557, 12);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(75, 23);
            this.buttonParse.TabIndex = 8;
            this.buttonParse.Text = "Parse";
            this.buttonParse.UseVisualStyleBackColor = true;
            this.buttonParse.Click += new System.EventHandler(this.buttonParse_Click);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.parseButton);
            this.groupBox.Controls.Add(this.buttonExit);
            this.groupBox.Controls.Add(this.textBoxToParse);
            this.groupBox.Controls.Add(this.buttonParse);
            this.groupBox.Controls.Add(this.listView);
            this.groupBox.Controls.Add(this.exitButton);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(999, 622);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(911, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // parseButton
            // 
            this.parseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parseButton.Location = new System.Drawing.Point(830, 12);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(75, 23);
            this.parseButton.TabIndex = 10;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.buttonParse_Click);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 622);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BrowserForm";
            this.Text = "BrowserForm";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ContentPanel.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Song;
        private System.Windows.Forms.ColumnHeader Artist;
        private System.Windows.Forms.ColumnHeader Album;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.TextBox textBoxToParse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonParse;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.Button buttonExit;
    }
}