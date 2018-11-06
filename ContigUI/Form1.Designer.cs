namespace ContigUI
{
    partial class MainForm
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
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defragOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.defragTargetDropDown = new System.Windows.Forms.ComboBox();
            this.addTargetButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.defragOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.MainContainer.IsSplitterFixed = true;
            this.MainContainer.Location = new System.Drawing.Point(0, 28);
            this.MainContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.defragOptionsGroupBox);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.startButton);
            this.MainContainer.Size = new System.Drawing.Size(1000, 534);
            this.MainContainer.SplitterDistance = 450;
            this.MainContainer.SplitterWidth = 5;
            this.MainContainer.TabIndex = 0;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1000, 28);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // defragOptionsGroupBox
            // 
            this.defragOptionsGroupBox.Controls.Add(this.addTargetButton);
            this.defragOptionsGroupBox.Controls.Add(this.defragTargetDropDown);
            this.defragOptionsGroupBox.Controls.Add(this.targetLabel);
            this.defragOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defragOptionsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.defragOptionsGroupBox.Name = "defragOptionsGroupBox";
            this.defragOptionsGroupBox.Size = new System.Drawing.Size(1000, 450);
            this.defragOptionsGroupBox.TabIndex = 0;
            this.defragOptionsGroupBox.TabStop = false;
            this.defragOptionsGroupBox.Text = "&Defragmentation Options";
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(12, 29);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(97, 17);
            this.targetLabel.TabIndex = 0;
            this.targetLabel.Text = "Defrag &Target";
            // 
            // defragTargetDropDown
            // 
            this.defragTargetDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defragTargetDropDown.FormattingEnabled = true;
            this.defragTargetDropDown.Items.AddRange(new object[] {
            "Files",
            "Folders",
            "Disk Drive",
            "NTFS MetaData Files"});
            this.defragTargetDropDown.Location = new System.Drawing.Point(115, 26);
            this.defragTargetDropDown.Name = "defragTargetDropDown";
            this.defragTargetDropDown.Size = new System.Drawing.Size(200, 24);
            this.defragTargetDropDown.TabIndex = 1;
            // 
            // addTargetButton
            // 
            this.addTargetButton.Location = new System.Drawing.Point(342, 23);
            this.addTargetButton.Name = "addTargetButton";
            this.addTargetButton.Size = new System.Drawing.Size(75, 28);
            this.addTargetButton.TabIndex = 2;
            this.addTargetButton.Text = "&Add";
            this.addTargetButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(913, 25);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 28);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "&Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.MainMenuStrip);
            this.MainMenuStrip = this.MainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Contig UI";
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.defragOptionsGroupBox.ResumeLayout(false);
            this.defragOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.GroupBox defragOptionsGroupBox;
        private System.Windows.Forms.ComboBox defragTargetDropDown;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button addTargetButton;
        private System.Windows.Forms.Button startButton;
    }
}

