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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "C:",
            "150 GB"}, "HardDrive");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.OptionsTabControl = new System.Windows.Forms.TabControl();
            this.DiskTabPage = new System.Windows.Forms.TabPage();
            this.DriveListView = new System.Windows.Forms.ListView();
            this.DriveNameCOlumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DriveSizeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DriveImageList = new System.Windows.Forms.ImageList(this.components);
            this.FolderTabPage = new System.Windows.Forms.TabPage();
            this.FoldersSplitContainer = new System.Windows.Forms.SplitContainer();
            this.FolderBrowserButton = new System.Windows.Forms.Button();
            this.FileTabPage = new System.Windows.Forms.TabPage();
            this.FilesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.FileBrowserButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.OptionsTabControl.SuspendLayout();
            this.DiskTabPage.SuspendLayout();
            this.FolderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoldersSplitContainer)).BeginInit();
            this.FoldersSplitContainer.Panel2.SuspendLayout();
            this.FoldersSplitContainer.SuspendLayout();
            this.FileTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilesSplitContainer)).BeginInit();
            this.FilesSplitContainer.Panel2.SuspendLayout();
            this.FilesSplitContainer.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.MainContainer.IsSplitterFixed = true;
            this.MainContainer.Location = new System.Drawing.Point(0, 24);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.OptionsTabControl);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.startButton);
            this.MainContainer.Size = new System.Drawing.Size(875, 503);
            this.MainContainer.SplitterDistance = 416;
            this.MainContainer.SplitterWidth = 5;
            this.MainContainer.TabIndex = 0;
            // 
            // OptionsTabControl
            // 
            this.OptionsTabControl.Controls.Add(this.DiskTabPage);
            this.OptionsTabControl.Controls.Add(this.FolderTabPage);
            this.OptionsTabControl.Controls.Add(this.FileTabPage);
            this.OptionsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsTabControl.HotTrack = true;
            this.OptionsTabControl.Location = new System.Drawing.Point(0, 0);
            this.OptionsTabControl.Multiline = true;
            this.OptionsTabControl.Name = "OptionsTabControl";
            this.OptionsTabControl.SelectedIndex = 0;
            this.OptionsTabControl.Size = new System.Drawing.Size(873, 414);
            this.OptionsTabControl.TabIndex = 0;
            // 
            // DiskTabPage
            // 
            this.DiskTabPage.Controls.Add(this.DriveListView);
            this.DiskTabPage.Location = new System.Drawing.Point(4, 24);
            this.DiskTabPage.Name = "DiskTabPage";
            this.DiskTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DiskTabPage.Size = new System.Drawing.Size(865, 386);
            this.DiskTabPage.TabIndex = 0;
            this.DiskTabPage.Text = "Disk Drives";
            this.DiskTabPage.UseVisualStyleBackColor = true;
            // 
            // DriveListView
            // 
            this.DriveListView.CheckBoxes = true;
            this.DriveListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DriveNameCOlumnHeader,
            this.DriveSizeColumnHeader});
            this.DriveListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DriveListView.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.DriveListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.DriveListView.Location = new System.Drawing.Point(3, 3);
            this.DriveListView.Name = "DriveListView";
            this.DriveListView.Size = new System.Drawing.Size(859, 380);
            this.DriveListView.SmallImageList = this.DriveImageList;
            this.DriveListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.DriveListView.TabIndex = 0;
            this.DriveListView.UseCompatibleStateImageBehavior = false;
            this.DriveListView.View = System.Windows.Forms.View.Details;
            // 
            // DriveNameCOlumnHeader
            // 
            this.DriveNameCOlumnHeader.Text = "Disk Drive";
            this.DriveNameCOlumnHeader.Width = 120;
            // 
            // DriveSizeColumnHeader
            // 
            this.DriveSizeColumnHeader.Text = "Size";
            this.DriveSizeColumnHeader.Width = 120;
            // 
            // DriveImageList
            // 
            this.DriveImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DriveImageList.ImageStream")));
            this.DriveImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.DriveImageList.Images.SetKeyName(0, "HardDrive");
            // 
            // FolderTabPage
            // 
            this.FolderTabPage.Controls.Add(this.FoldersSplitContainer);
            this.FolderTabPage.Location = new System.Drawing.Point(4, 24);
            this.FolderTabPage.Name = "FolderTabPage";
            this.FolderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FolderTabPage.Size = new System.Drawing.Size(865, 386);
            this.FolderTabPage.TabIndex = 1;
            this.FolderTabPage.Text = "Folders";
            this.FolderTabPage.UseVisualStyleBackColor = true;
            // 
            // FoldersSplitContainer
            // 
            this.FoldersSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FoldersSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoldersSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.FoldersSplitContainer.IsSplitterFixed = true;
            this.FoldersSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.FoldersSplitContainer.Name = "FoldersSplitContainer";
            this.FoldersSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // FoldersSplitContainer.Panel2
            // 
            this.FoldersSplitContainer.Panel2.Controls.Add(this.FolderBrowserButton);
            this.FoldersSplitContainer.Size = new System.Drawing.Size(859, 380);
            this.FoldersSplitContainer.SplitterDistance = 310;
            this.FoldersSplitContainer.SplitterWidth = 5;
            this.FoldersSplitContainer.TabIndex = 0;
            // 
            // FolderBrowserButton
            // 
            this.FolderBrowserButton.Location = new System.Drawing.Point(760, 16);
            this.FolderBrowserButton.Margin = new System.Windows.Forms.Padding(2);
            this.FolderBrowserButton.Name = "FolderBrowserButton";
            this.FolderBrowserButton.Size = new System.Drawing.Size(90, 31);
            this.FolderBrowserButton.TabIndex = 1;
            this.FolderBrowserButton.Text = "Add &Folders...";
            this.FolderBrowserButton.UseVisualStyleBackColor = true;
            // 
            // FileTabPage
            // 
            this.FileTabPage.Controls.Add(this.FilesSplitContainer);
            this.FileTabPage.Location = new System.Drawing.Point(4, 24);
            this.FileTabPage.Name = "FileTabPage";
            this.FileTabPage.Size = new System.Drawing.Size(865, 386);
            this.FileTabPage.TabIndex = 2;
            this.FileTabPage.Text = "Files";
            this.FileTabPage.UseVisualStyleBackColor = true;
            // 
            // FilesSplitContainer
            // 
            this.FilesSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.FilesSplitContainer.IsSplitterFixed = true;
            this.FilesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.FilesSplitContainer.Name = "FilesSplitContainer";
            this.FilesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // FilesSplitContainer.Panel2
            // 
            this.FilesSplitContainer.Panel2.Controls.Add(this.FileBrowserButton);
            this.FilesSplitContainer.Size = new System.Drawing.Size(865, 386);
            this.FilesSplitContainer.SplitterDistance = 310;
            this.FilesSplitContainer.SplitterWidth = 5;
            this.FilesSplitContainer.TabIndex = 1;
            // 
            // FileBrowserButton
            // 
            this.FileBrowserButton.Location = new System.Drawing.Point(760, 19);
            this.FileBrowserButton.Margin = new System.Windows.Forms.Padding(2);
            this.FileBrowserButton.Name = "FileBrowserButton";
            this.FileBrowserButton.Size = new System.Drawing.Size(90, 31);
            this.FileBrowserButton.TabIndex = 1;
            this.FileBrowserButton.Text = "Add &Files...";
            this.FileBrowserButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(769, 25);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(90, 31);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "&Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(875, 24);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // FolderDialog
            // 
            this.FolderDialog.Description = "Select Folder to Defrag";
            this.FolderDialog.ShowNewFolderButton = false;
            // 
            // FileDialog
            // 
            this.FileDialog.Filter = "All Files|*.*";
            this.FileDialog.Multiselect = true;
            this.FileDialog.SupportMultiDottedExtensions = true;
            this.FileDialog.Title = "Select Files to Defrag";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 527);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Contig UI";
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.OptionsTabControl.ResumeLayout(false);
            this.DiskTabPage.ResumeLayout(false);
            this.FolderTabPage.ResumeLayout(false);
            this.FoldersSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FoldersSplitContainer)).EndInit();
            this.FoldersSplitContainer.ResumeLayout(false);
            this.FileTabPage.ResumeLayout(false);
            this.FilesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilesSplitContainer)).EndInit();
            this.FilesSplitContainer.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TabControl OptionsTabControl;
        private System.Windows.Forms.TabPage DiskTabPage;
        private System.Windows.Forms.ListView DriveListView;
        private System.Windows.Forms.ColumnHeader DriveNameCOlumnHeader;
        private System.Windows.Forms.ColumnHeader DriveSizeColumnHeader;
        private System.Windows.Forms.ImageList DriveImageList;
        private System.Windows.Forms.TabPage FolderTabPage;
        private System.Windows.Forms.SplitContainer FoldersSplitContainer;
        private System.Windows.Forms.Button FolderBrowserButton;
        private System.Windows.Forms.TabPage FileTabPage;
        private System.Windows.Forms.SplitContainer FilesSplitContainer;
        private System.Windows.Forms.Button FileBrowserButton;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.OpenFileDialog FileDialog;
    }
}

