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
            this.parseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.Song = new System.Windows.Forms.ColumnHeader();
            this.Artist = new System.Windows.Forms.ColumnHeader();
            this.Album = new System.Windows.Forms.ColumnHeader();
            this.Duration = new System.Windows.Forms.ColumnHeader();
            this.toolStripContainer.ContentPanel.SuspendLayout();
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
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(852, 565);
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
            this.toolStripContainer.Size = new System.Drawing.Size(852, 565);
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
            this.statusLabel.Location = new System.Drawing.Point(0, 535);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 15);
            this.statusLabel.TabIndex = 1;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputLabel.Location = new System.Drawing.Point(0, 550);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 15);
            this.outputLabel.TabIndex = 0;
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(12, 27);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(75, 23);
            this.parseButton.TabIndex = 2;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(94, 27);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
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
            this.listView.Location = new System.Drawing.Point(13, 57);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(827, 496);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 565);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BrowserForm";
            this.Text = "BrowserForm";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Song;
        private System.Windows.Forms.ColumnHeader Artist;
        private System.Windows.Forms.ColumnHeader Album;
        private System.Windows.Forms.ColumnHeader Duration;
    }
}