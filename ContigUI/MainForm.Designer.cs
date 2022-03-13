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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "C:",
            "Solid state drive",
            "150 GB"}, "HardDrive");
			this.DriveImageList = new System.Windows.Forms.ImageList(this.components);
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.FileDialog = new System.Windows.Forms.OpenFileDialog();
			this.MainToolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.MainContainer = new System.Windows.Forms.SplitContainer();
			this.OptionsTabControl = new System.Windows.Forms.TabControl();
			this.DiskTabPage = new System.Windows.Forms.TabPage();
			this.driveSplitContainer = new System.Windows.Forms.SplitContainer();
			this.DriveListView = new System.Windows.Forms.ListView();
			this.DriveNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DriveSizeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FolderTabPage = new System.Windows.Forms.TabPage();
			this.FoldersSplitContainer = new System.Windows.Forms.SplitContainer();
			this.FolderListView = new System.Windows.Forms.ListView();
			this.folderNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.RemoveFolderButton = new System.Windows.Forms.Button();
			this.FolderBrowserButton = new System.Windows.Forms.Button();
			this.FileTabPage = new System.Windows.Forms.TabPage();
			this.FilesSplitContainer = new System.Windows.Forms.SplitContainer();
			this.FileListView = new System.Windows.Forms.ListView();
			this.FileNameCOlumnHEader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.RemoveFilesButton = new System.Windows.Forms.Button();
			this.FileBrowserButton = new System.Windows.Forms.Button();
			this.progressIndicator = new System.Windows.Forms.ProgressBar();
			this.ExitButton = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.MainToolStrip = new System.Windows.Forms.ToolStrip();
			this.addFileStripButton = new System.Windows.Forms.ToolStripButton();
			this.addFolderStripButton = new System.Windows.Forms.ToolStripButton();
			this.StartStripButton = new System.Windows.Forms.ToolStripButton();
			this.ExitStripButton = new System.Windows.Forms.ToolStripButton();
			this.driveLogListView = new System.Windows.Forms.ListView();
			this.DriveTypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ItemColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BeforeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AfterColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sep1 = new System.Windows.Forms.ToolStripSeparator();
			this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu.SuspendLayout();
			this.MainToolStripContainer.ContentPanel.SuspendLayout();
			this.MainToolStripContainer.TopToolStripPanel.SuspendLayout();
			this.MainToolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
			this.MainContainer.Panel1.SuspendLayout();
			this.MainContainer.Panel2.SuspendLayout();
			this.MainContainer.SuspendLayout();
			this.OptionsTabControl.SuspendLayout();
			this.DiskTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.driveSplitContainer)).BeginInit();
			this.driveSplitContainer.Panel1.SuspendLayout();
			this.driveSplitContainer.Panel2.SuspendLayout();
			this.driveSplitContainer.SuspendLayout();
			this.FolderTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FoldersSplitContainer)).BeginInit();
			this.FoldersSplitContainer.Panel1.SuspendLayout();
			this.FoldersSplitContainer.Panel2.SuspendLayout();
			this.FoldersSplitContainer.SuspendLayout();
			this.FileTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FilesSplitContainer)).BeginInit();
			this.FilesSplitContainer.Panel1.SuspendLayout();
			this.FilesSplitContainer.Panel2.SuspendLayout();
			this.FilesSplitContainer.SuspendLayout();
			this.MainToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// DriveImageList
			// 
			this.DriveImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DriveImageList.ImageStream")));
			this.DriveImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.DriveImageList.Images.SetKeyName(0, "HardDrive");
			this.DriveImageList.Images.SetKeyName(1, "Add Folder");
			this.DriveImageList.Images.SetKeyName(2, "Delete Folder");
			this.DriveImageList.Images.SetKeyName(3, "Folder");
			this.DriveImageList.Images.SetKeyName(4, "Add File");
			this.DriveImageList.Images.SetKeyName(5, "Delete File");
			this.DriveImageList.Images.SetKeyName(6, "File");
			this.DriveImageList.Images.SetKeyName(7, "Start");
			this.DriveImageList.Images.SetKeyName(8, "Exit");
			// 
			// MainMenu
			// 
			this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.MainMenu.Size = new System.Drawing.Size(875, 24);
			this.MainMenu.TabIndex = 1;
			this.MainMenu.Text = "Main Menu";
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
			this.exitToolStripMenuItem.Image = global::ContigUI.Properties.Resources.Exit_16x;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitButton_Click);
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
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			// 
			// FolderDialog
			// 
			this.FolderDialog.Description = "Select Folder to Defrag...";
			this.FolderDialog.ShowNewFolderButton = false;
			// 
			// FileDialog
			// 
			this.FileDialog.Filter = "All Files|*.*";
			this.FileDialog.Multiselect = true;
			this.FileDialog.SupportMultiDottedExtensions = true;
			this.FileDialog.Title = "Select Files to Defrag...";
			// 
			// MainToolStripContainer
			// 
			// 
			// MainToolStripContainer.BottomToolStripPanel
			// 
			this.MainToolStripContainer.BottomToolStripPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MainToolStripContainer_BottomToolStripPanel_ControlAdded);
			this.MainToolStripContainer.BottomToolStripPanelVisible = false;
			// 
			// MainToolStripContainer.ContentPanel
			// 
			this.MainToolStripContainer.ContentPanel.Controls.Add(this.MainContainer);
			this.MainToolStripContainer.ContentPanel.Size = new System.Drawing.Size(875, 478);
			this.MainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// MainToolStripContainer.LeftToolStripPanel
			// 
			this.MainToolStripContainer.LeftToolStripPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MainToolStripContainer_LeftToolStripPanel_ControlAdded);
			this.MainToolStripContainer.Location = new System.Drawing.Point(0, 24);
			this.MainToolStripContainer.Name = "MainToolStripContainer";
			// 
			// MainToolStripContainer.RightToolStripPanel
			// 
			this.MainToolStripContainer.RightToolStripPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MainToolStripContainer_RightToolStripPanel_ControlAdded);
			this.MainToolStripContainer.Size = new System.Drawing.Size(875, 503);
			this.MainToolStripContainer.TabIndex = 2;
			this.MainToolStripContainer.Text = "MainToolStrip";
			// 
			// MainToolStripContainer.TopToolStripPanel
			// 
			this.MainToolStripContainer.TopToolStripPanel.Controls.Add(this.MainToolStrip);
			this.MainToolStripContainer.TopToolStripPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MainToolStripContainer_TopToolStripPanel_ControlAdded);
			// 
			// MainContainer
			// 
			this.MainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.MainContainer.IsSplitterFixed = true;
			this.MainContainer.Location = new System.Drawing.Point(0, 0);
			this.MainContainer.Name = "MainContainer";
			this.MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// MainContainer.Panel1
			// 
			this.MainContainer.Panel1.Controls.Add(this.OptionsTabControl);
			// 
			// MainContainer.Panel2
			// 
			this.MainContainer.Panel2.Controls.Add(this.progressIndicator);
			this.MainContainer.Panel2.Controls.Add(this.ExitButton);
			this.MainContainer.Panel2.Controls.Add(this.startButton);
			this.MainContainer.Size = new System.Drawing.Size(875, 478);
			this.MainContainer.SplitterDistance = 414;
			this.MainContainer.SplitterWidth = 5;
			this.MainContainer.TabIndex = 1;
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
			this.OptionsTabControl.Size = new System.Drawing.Size(873, 412);
			this.OptionsTabControl.TabIndex = 0;
			// 
			// DiskTabPage
			// 
			this.DiskTabPage.Controls.Add(this.driveSplitContainer);
			this.DiskTabPage.Location = new System.Drawing.Point(4, 24);
			this.DiskTabPage.Name = "DiskTabPage";
			this.DiskTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.DiskTabPage.Size = new System.Drawing.Size(865, 384);
			this.DiskTabPage.TabIndex = 0;
			this.DiskTabPage.Text = "Disk Drives";
			this.DiskTabPage.UseVisualStyleBackColor = true;
			// 
			// driveSplitContainer
			// 
			this.driveSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.driveSplitContainer.Location = new System.Drawing.Point(3, 3);
			this.driveSplitContainer.Name = "driveSplitContainer";
			this.driveSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// driveSplitContainer.Panel1
			// 
			this.driveSplitContainer.Panel1.Controls.Add(this.DriveListView);
			// 
			// driveSplitContainer.Panel2
			// 
			this.driveSplitContainer.Panel2.Controls.Add(this.driveLogListView);
			this.driveSplitContainer.Size = new System.Drawing.Size(859, 378);
			this.driveSplitContainer.SplitterDistance = 102;
			this.driveSplitContainer.TabIndex = 1;
			// 
			// DriveListView
			// 
			this.DriveListView.CheckBoxes = true;
			this.DriveListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DriveNameColumnHeader,
            this.DriveTypeColumnHeader,
            this.DriveSizeColumnHeader});
			this.DriveListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DriveListView.FullRowSelect = true;
			this.DriveListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.DriveListView.HideSelection = false;
			listViewItem1.StateImageIndex = 0;
			this.DriveListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.DriveListView.Location = new System.Drawing.Point(0, 0);
			this.DriveListView.Name = "DriveListView";
			this.DriveListView.Size = new System.Drawing.Size(859, 102);
			this.DriveListView.SmallImageList = this.DriveImageList;
			this.DriveListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.DriveListView.TabIndex = 0;
			this.DriveListView.UseCompatibleStateImageBehavior = false;
			this.DriveListView.View = System.Windows.Forms.View.Details;
			// 
			// DriveNameColumnHeader
			// 
			this.DriveNameColumnHeader.Text = "Drive";
			this.DriveNameColumnHeader.Width = 120;
			// 
			// DriveSizeColumnHeader
			// 
			this.DriveSizeColumnHeader.Text = "Size";
			this.DriveSizeColumnHeader.Width = 120;
			// 
			// FolderTabPage
			// 
			this.FolderTabPage.Controls.Add(this.FoldersSplitContainer);
			this.FolderTabPage.Location = new System.Drawing.Point(4, 24);
			this.FolderTabPage.Name = "FolderTabPage";
			this.FolderTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.FolderTabPage.Size = new System.Drawing.Size(865, 384);
			this.FolderTabPage.TabIndex = 1;
			this.FolderTabPage.Text = "Folders";
			this.FolderTabPage.UseVisualStyleBackColor = true;
			// 
			// FoldersSplitContainer
			// 
			this.FoldersSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FoldersSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.FoldersSplitContainer.IsSplitterFixed = true;
			this.FoldersSplitContainer.Location = new System.Drawing.Point(3, 3);
			this.FoldersSplitContainer.Name = "FoldersSplitContainer";
			this.FoldersSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// FoldersSplitContainer.Panel1
			// 
			this.FoldersSplitContainer.Panel1.Controls.Add(this.FolderListView);
			// 
			// FoldersSplitContainer.Panel2
			// 
			this.FoldersSplitContainer.Panel2.Controls.Add(this.RemoveFolderButton);
			this.FoldersSplitContainer.Panel2.Controls.Add(this.FolderBrowserButton);
			this.FoldersSplitContainer.Size = new System.Drawing.Size(859, 378);
			this.FoldersSplitContainer.SplitterDistance = 324;
			this.FoldersSplitContainer.SplitterWidth = 1;
			this.FoldersSplitContainer.TabIndex = 0;
			// 
			// FolderListView
			// 
			this.FolderListView.CheckBoxes = true;
			this.FolderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.folderNameColumnHeader});
			this.FolderListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FolderListView.HideSelection = false;
			this.FolderListView.Location = new System.Drawing.Point(0, 0);
			this.FolderListView.Name = "FolderListView";
			this.FolderListView.Size = new System.Drawing.Size(859, 324);
			this.FolderListView.SmallImageList = this.DriveImageList;
			this.FolderListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.FolderListView.TabIndex = 1;
			this.FolderListView.UseCompatibleStateImageBehavior = false;
			this.FolderListView.View = System.Windows.Forms.View.Details;
			// 
			// folderNameColumnHeader
			// 
			this.folderNameColumnHeader.Text = "Folder";
			this.folderNameColumnHeader.Width = 400;
			// 
			// RemoveFolderButton
			// 
			this.RemoveFolderButton.ImageKey = "Delete Folder";
			this.RemoveFolderButton.ImageList = this.DriveImageList;
			this.RemoveFolderButton.Location = new System.Drawing.Point(615, 16);
			this.RemoveFolderButton.Margin = new System.Windows.Forms.Padding(2);
			this.RemoveFolderButton.Name = "RemoveFolderButton";
			this.RemoveFolderButton.Size = new System.Drawing.Size(121, 31);
			this.RemoveFolderButton.TabIndex = 3;
			this.RemoveFolderButton.Text = "&Remove Folders";
			this.RemoveFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.RemoveFolderButton.UseVisualStyleBackColor = true;
			this.RemoveFolderButton.Click += new System.EventHandler(this.RemoveFolderButton_Click);
			// 
			// FolderBrowserButton
			// 
			this.FolderBrowserButton.ImageKey = "Add Folder";
			this.FolderBrowserButton.ImageList = this.DriveImageList;
			this.FolderBrowserButton.Location = new System.Drawing.Point(740, 16);
			this.FolderBrowserButton.Margin = new System.Windows.Forms.Padding(2);
			this.FolderBrowserButton.Name = "FolderBrowserButton";
			this.FolderBrowserButton.Size = new System.Drawing.Size(112, 31);
			this.FolderBrowserButton.TabIndex = 1;
			this.FolderBrowserButton.Text = "Add &Folders...";
			this.FolderBrowserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.FolderBrowserButton.UseVisualStyleBackColor = true;
			this.FolderBrowserButton.Click += new System.EventHandler(this.FolderBrowserButton_Click);
			// 
			// FileTabPage
			// 
			this.FileTabPage.Controls.Add(this.FilesSplitContainer);
			this.FileTabPage.Location = new System.Drawing.Point(4, 24);
			this.FileTabPage.Name = "FileTabPage";
			this.FileTabPage.Size = new System.Drawing.Size(865, 384);
			this.FileTabPage.TabIndex = 2;
			this.FileTabPage.Text = "Files";
			this.FileTabPage.UseVisualStyleBackColor = true;
			// 
			// FilesSplitContainer
			// 
			this.FilesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FilesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.FilesSplitContainer.IsSplitterFixed = true;
			this.FilesSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.FilesSplitContainer.Name = "FilesSplitContainer";
			this.FilesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// FilesSplitContainer.Panel1
			// 
			this.FilesSplitContainer.Panel1.Controls.Add(this.FileListView);
			// 
			// FilesSplitContainer.Panel2
			// 
			this.FilesSplitContainer.Panel2.Controls.Add(this.RemoveFilesButton);
			this.FilesSplitContainer.Panel2.Controls.Add(this.FileBrowserButton);
			this.FilesSplitContainer.Size = new System.Drawing.Size(865, 384);
			this.FilesSplitContainer.SplitterDistance = 324;
			this.FilesSplitContainer.SplitterWidth = 1;
			this.FilesSplitContainer.TabIndex = 1;
			// 
			// FileListView
			// 
			this.FileListView.CheckBoxes = true;
			this.FileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileNameCOlumnHEader});
			this.FileListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FileListView.HideSelection = false;
			this.FileListView.Location = new System.Drawing.Point(0, 0);
			this.FileListView.Name = "FileListView";
			this.FileListView.Size = new System.Drawing.Size(865, 324);
			this.FileListView.SmallImageList = this.DriveImageList;
			this.FileListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.FileListView.TabIndex = 2;
			this.FileListView.UseCompatibleStateImageBehavior = false;
			this.FileListView.View = System.Windows.Forms.View.Details;
			// 
			// FileNameCOlumnHEader
			// 
			this.FileNameCOlumnHEader.Text = "File";
			this.FileNameCOlumnHEader.Width = 400;
			// 
			// RemoveFilesButton
			// 
			this.RemoveFilesButton.ImageKey = "Delete File";
			this.RemoveFilesButton.ImageList = this.DriveImageList;
			this.RemoveFilesButton.Location = new System.Drawing.Point(627, 19);
			this.RemoveFilesButton.Margin = new System.Windows.Forms.Padding(2);
			this.RemoveFilesButton.Name = "RemoveFilesButton";
			this.RemoveFilesButton.Size = new System.Drawing.Size(112, 31);
			this.RemoveFilesButton.TabIndex = 2;
			this.RemoveFilesButton.Text = "&Remove Files";
			this.RemoveFilesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.RemoveFilesButton.UseVisualStyleBackColor = true;
			this.RemoveFilesButton.Click += new System.EventHandler(this.RemoveFilesButton_Click);
			// 
			// FileBrowserButton
			// 
			this.FileBrowserButton.ImageKey = "Add File";
			this.FileBrowserButton.ImageList = this.DriveImageList;
			this.FileBrowserButton.Location = new System.Drawing.Point(743, 19);
			this.FileBrowserButton.Margin = new System.Windows.Forms.Padding(2);
			this.FileBrowserButton.Name = "FileBrowserButton";
			this.FileBrowserButton.Size = new System.Drawing.Size(112, 31);
			this.FileBrowserButton.TabIndex = 1;
			this.FileBrowserButton.Text = "Add &Files...";
			this.FileBrowserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.FileBrowserButton.UseVisualStyleBackColor = true;
			this.FileBrowserButton.Click += new System.EventHandler(this.FileBrowserButton_Click);
			// 
			// progressIndicator
			// 
			this.progressIndicator.Location = new System.Drawing.Point(11, 10);
			this.progressIndicator.Name = "progressIndicator";
			this.progressIndicator.Size = new System.Drawing.Size(663, 36);
			this.progressIndicator.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressIndicator.TabIndex = 3;
			// 
			// ExitButton
			// 
			this.ExitButton.ImageKey = "Exit";
			this.ExitButton.ImageList = this.DriveImageList;
			this.ExitButton.Location = new System.Drawing.Point(773, 10);
			this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(90, 36);
			this.ExitButton.TabIndex = 1;
			this.ExitButton.Text = "E&xit";
			this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// startButton
			// 
			this.startButton.ImageKey = "Start";
			this.startButton.ImageList = this.DriveImageList;
			this.startButton.Location = new System.Drawing.Point(679, 10);
			this.startButton.Margin = new System.Windows.Forms.Padding(2);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(90, 36);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "&Start";
			this.startButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// MainToolStrip
			// 
			this.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileStripButton,
            this.addFolderStripButton,
            this.StartStripButton,
            this.ExitStripButton});
			this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
			this.MainToolStrip.Name = "MainToolStrip";
			this.MainToolStrip.Size = new System.Drawing.Size(875, 25);
			this.MainToolStrip.Stretch = true;
			this.MainToolStrip.TabIndex = 0;
			this.MainToolStrip.Text = "MainToolStrip";
			// 
			// addFileStripButton
			// 
			this.addFileStripButton.Image = global::ContigUI.Properties.Resources.AddFile_16x;
			this.addFileStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addFileStripButton.Name = "addFileStripButton";
			this.addFileStripButton.Size = new System.Drawing.Size(84, 22);
			this.addFileStripButton.Text = "Add F&iles...";
			this.addFileStripButton.Click += new System.EventHandler(this.FileBrowserButton_Click);
			// 
			// addFolderStripButton
			// 
			this.addFolderStripButton.Image = global::ContigUI.Properties.Resources.AddFolder_16x;
			this.addFolderStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addFolderStripButton.Name = "addFolderStripButton";
			this.addFolderStripButton.Size = new System.Drawing.Size(94, 22);
			this.addFolderStripButton.Text = "Add &Folder...";
			this.addFolderStripButton.Click += new System.EventHandler(this.FolderBrowserButton_Click);
			// 
			// StartStripButton
			// 
			this.StartStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.StartStripButton.Image = global::ContigUI.Properties.Resources.PlayVideo_16x;
			this.StartStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.StartStripButton.Name = "StartStripButton";
			this.StartStripButton.Size = new System.Drawing.Size(23, 22);
			this.StartStripButton.Text = "StartStripButton";
			// 
			// ExitStripButton
			// 
			this.ExitStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ExitStripButton.Image = global::ContigUI.Properties.Resources.Exit_16x;
			this.ExitStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ExitStripButton.Name = "ExitStripButton";
			this.ExitStripButton.Size = new System.Drawing.Size(23, 22);
			this.ExitStripButton.Text = "ExitStripButton";
			this.ExitStripButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// driveLogListView
			// 
			this.driveLogListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemColumnHeader,
            this.BeforeColumnHeader,
            this.AfterColumnHeader});
			this.driveLogListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.driveLogListView.FullRowSelect = true;
			this.driveLogListView.GridLines = true;
			this.driveLogListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.driveLogListView.HideSelection = false;
			this.driveLogListView.Location = new System.Drawing.Point(0, 0);
			this.driveLogListView.Name = "driveLogListView";
			this.driveLogListView.Size = new System.Drawing.Size(859, 272);
			this.driveLogListView.TabIndex = 0;
			this.driveLogListView.UseCompatibleStateImageBehavior = false;
			this.driveLogListView.View = System.Windows.Forms.View.Details;
			// 
			// DriveTypeColumnHeader
			// 
			this.DriveTypeColumnHeader.Text = "Media Type";
			this.DriveTypeColumnHeader.Width = 130;
			// 
			// ItemColumnHeader
			// 
			this.ItemColumnHeader.Text = "Item";
			this.ItemColumnHeader.Width = 180;
			// 
			// BeforeColumnHeader
			// 
			this.BeforeColumnHeader.Text = "Fragments Before";
			this.BeforeColumnHeader.Width = 130;
			// 
			// AfterColumnHeader
			// 
			this.AfterColumnHeader.Text = "Fragments After";
			this.AfterColumnHeader.Width = 130;
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFolderToolStripMenuItem,
            this.removeFolderToolStripMenuItem,
            this.sep1,
            this.addFileToolStripMenuItem,
            this.removeFileToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// addFolderToolStripMenuItem
			// 
			this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
			this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.addFolderToolStripMenuItem.Text = "Add F&older...";
			this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.FolderBrowserButton_Click);
			// 
			// removeFolderToolStripMenuItem
			// 
			this.removeFolderToolStripMenuItem.Name = "removeFolderToolStripMenuItem";
			this.removeFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.removeFolderToolStripMenuItem.Text = "Remove Fo&lder";
			this.removeFolderToolStripMenuItem.Click += new System.EventHandler(this.RemoveFolderButton_Click);
			// 
			// sep1
			// 
			this.sep1.Name = "sep1";
			this.sep1.Size = new System.Drawing.Size(177, 6);
			// 
			// addFileToolStripMenuItem
			// 
			this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
			this.addFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.addFileToolStripMenuItem.Text = "Add F&ile...";
			this.addFileToolStripMenuItem.Click += new System.EventHandler(this.FileBrowserButton_Click);
			// 
			// removeFileToolStripMenuItem
			// 
			this.removeFileToolStripMenuItem.Name = "removeFileToolStripMenuItem";
			this.removeFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.removeFileToolStripMenuItem.Text = "Re&move File";
			this.removeFileToolStripMenuItem.Click += new System.EventHandler(this.RemoveFilesButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(875, 527);
			this.Controls.Add(this.MainToolStripContainer);
			this.Controls.Add(this.MainMenu);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contig UI";
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.MainToolStripContainer.ContentPanel.ResumeLayout(false);
			this.MainToolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.MainToolStripContainer.TopToolStripPanel.PerformLayout();
			this.MainToolStripContainer.ResumeLayout(false);
			this.MainToolStripContainer.PerformLayout();
			this.MainContainer.Panel1.ResumeLayout(false);
			this.MainContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
			this.MainContainer.ResumeLayout(false);
			this.OptionsTabControl.ResumeLayout(false);
			this.DiskTabPage.ResumeLayout(false);
			this.driveSplitContainer.Panel1.ResumeLayout(false);
			this.driveSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.driveSplitContainer)).EndInit();
			this.driveSplitContainer.ResumeLayout(false);
			this.FolderTabPage.ResumeLayout(false);
			this.FoldersSplitContainer.Panel1.ResumeLayout(false);
			this.FoldersSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FoldersSplitContainer)).EndInit();
			this.FoldersSplitContainer.ResumeLayout(false);
			this.FileTabPage.ResumeLayout(false);
			this.FilesSplitContainer.Panel1.ResumeLayout(false);
			this.FilesSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FilesSplitContainer)).EndInit();
			this.FilesSplitContainer.ResumeLayout(false);
			this.MainToolStrip.ResumeLayout(false);
			this.MainToolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ImageList DriveImageList;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.OpenFileDialog FileDialog;
		private System.Windows.Forms.ToolStripContainer MainToolStripContainer;
		private System.Windows.Forms.SplitContainer MainContainer;
		private System.Windows.Forms.TabControl OptionsTabControl;
		private System.Windows.Forms.TabPage DiskTabPage;
		private System.Windows.Forms.ListView DriveListView;
		private System.Windows.Forms.ColumnHeader DriveNameColumnHeader;
		private System.Windows.Forms.ColumnHeader DriveSizeColumnHeader;
		private System.Windows.Forms.TabPage FolderTabPage;
		private System.Windows.Forms.SplitContainer FoldersSplitContainer;
		private System.Windows.Forms.ListView FolderListView;
		private System.Windows.Forms.ColumnHeader folderNameColumnHeader;
		private System.Windows.Forms.Button RemoveFolderButton;
		private System.Windows.Forms.Button FolderBrowserButton;
		private System.Windows.Forms.TabPage FileTabPage;
		private System.Windows.Forms.SplitContainer FilesSplitContainer;
		private System.Windows.Forms.ListView FileListView;
		private System.Windows.Forms.ColumnHeader FileNameCOlumnHEader;
		private System.Windows.Forms.Button RemoveFilesButton;
		private System.Windows.Forms.Button FileBrowserButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.ToolStrip MainToolStrip;
		private System.Windows.Forms.ToolStripButton addFileStripButton;
		private System.Windows.Forms.ToolStripButton addFolderStripButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.ToolStripButton StartStripButton;
		private System.Windows.Forms.ToolStripButton ExitStripButton;
		private System.Windows.Forms.SplitContainer driveSplitContainer;
		private System.Windows.Forms.ProgressBar progressIndicator;
		private System.Windows.Forms.ListView driveLogListView;
		private System.Windows.Forms.ColumnHeader DriveTypeColumnHeader;
		private System.Windows.Forms.ColumnHeader ItemColumnHeader;
		private System.Windows.Forms.ColumnHeader BeforeColumnHeader;
		private System.Windows.Forms.ColumnHeader AfterColumnHeader;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator sep1;
		private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeFileToolStripMenuItem;
	}
}

