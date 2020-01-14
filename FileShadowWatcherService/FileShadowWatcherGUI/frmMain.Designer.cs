namespace FileShadowWatcherGUI
{
    partial class frmMain
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan3 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colFolderPath = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDaysToStore = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colTrashFolder = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colFolderDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItemRunning = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemToggleSwitchRunning = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.barEditItemPaused = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemToggleSwitchPaused = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.barEditItemInstalled = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemToggleSwitchInstalled = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.btnAddOption = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveOptions = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteOption = new DevExpress.XtraBars.BarButtonItem();
            this.btnStart = new DevExpress.XtraBars.BarButtonItem();
            this.btnStop = new DevExpress.XtraBars.BarButtonItem();
            this.btnPause = new DevExpress.XtraBars.BarButtonItem();
            this.btnContinue = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestart = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowLogFile = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.rpStart = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgOptions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgService = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControlOptions = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlOptions = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceOptions = new System.Windows.Forms.BindingSource(this.components);
            this.tileViewOptions = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colFolderGUID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colFolderEnabled = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colFolderFilter = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colFolderIncludeSub = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colUseSubFolderEventNames = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colUseForensicsFactory = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colUseDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.x_Options1 = new FileShadowWatcherGUI.x_Options();
            this.timerService = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitchRunning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitchPaused)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitchInstalled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlOptions)).BeginInit();
            this.splitContainerControlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // colFolderPath
            // 
            this.colFolderPath.FieldName = "FolderPath";
            this.colFolderPath.Name = "colFolderPath";
            this.colFolderPath.Visible = true;
            this.colFolderPath.VisibleIndex = 4;
            // 
            // colDaysToStore
            // 
            this.colDaysToStore.FieldName = "DaysToStore";
            this.colDaysToStore.Name = "colDaysToStore";
            this.colDaysToStore.Visible = true;
            this.colDaysToStore.VisibleIndex = 10;
            // 
            // colTrashFolder
            // 
            this.colTrashFolder.FieldName = "TrashFolder";
            this.colTrashFolder.Name = "colTrashFolder";
            this.colTrashFolder.Visible = true;
            this.colTrashFolder.VisibleIndex = 6;
            // 
            // colFolderDescription
            // 
            this.colFolderDescription.FieldName = "FolderDescription";
            this.colFolderDescription.Name = "colFolderDescription";
            this.colFolderDescription.Visible = true;
            this.colFolderDescription.VisibleIndex = 2;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barStaticItem1,
            this.barEditItemRunning,
            this.barEditItemPaused,
            this.barEditItemInstalled,
            this.btnAddOption,
            this.btnSaveOptions,
            this.btnDeleteOption,
            this.btnStart,
            this.btnStop,
            this.btnPause,
            this.btnContinue,
            this.btnRestart,
            this.btnShowLogFile,
            this.btnAbout});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpStart});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemToggleSwitchRunning,
            this.repositoryItemToggleSwitchPaused,
            this.repositoryItemToggleSwitchInstalled});
            this.ribbon.Size = new System.Drawing.Size(1009, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Service status: ";
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barEditItemRunning
            // 
            this.barEditItemRunning.Caption = "Running";
            this.barEditItemRunning.Edit = this.repositoryItemToggleSwitchRunning;
            this.barEditItemRunning.Id = 2;
            this.barEditItemRunning.Name = "barEditItemRunning";
            // 
            // repositoryItemToggleSwitchRunning
            // 
            this.repositoryItemToggleSwitchRunning.AutoHeight = false;
            this.repositoryItemToggleSwitchRunning.Name = "repositoryItemToggleSwitchRunning";
            this.repositoryItemToggleSwitchRunning.OffText = "Off";
            this.repositoryItemToggleSwitchRunning.OnText = "On";
            this.repositoryItemToggleSwitchRunning.ReadOnly = true;
            // 
            // barEditItemPaused
            // 
            this.barEditItemPaused.Caption = "Paused";
            this.barEditItemPaused.Edit = this.repositoryItemToggleSwitchPaused;
            this.barEditItemPaused.Id = 3;
            this.barEditItemPaused.Name = "barEditItemPaused";
            // 
            // repositoryItemToggleSwitchPaused
            // 
            this.repositoryItemToggleSwitchPaused.AutoHeight = false;
            this.repositoryItemToggleSwitchPaused.Name = "repositoryItemToggleSwitchPaused";
            this.repositoryItemToggleSwitchPaused.OffText = "Off";
            this.repositoryItemToggleSwitchPaused.OnText = "On";
            this.repositoryItemToggleSwitchPaused.ReadOnly = true;
            // 
            // barEditItemInstalled
            // 
            this.barEditItemInstalled.Caption = "Installed";
            this.barEditItemInstalled.Edit = this.repositoryItemToggleSwitchInstalled;
            this.barEditItemInstalled.Id = 5;
            this.barEditItemInstalled.Name = "barEditItemInstalled";
            // 
            // repositoryItemToggleSwitchInstalled
            // 
            this.repositoryItemToggleSwitchInstalled.AutoHeight = false;
            this.repositoryItemToggleSwitchInstalled.Name = "repositoryItemToggleSwitchInstalled";
            this.repositoryItemToggleSwitchInstalled.OffText = "Off";
            this.repositoryItemToggleSwitchInstalled.OnText = "On";
            this.repositoryItemToggleSwitchInstalled.ReadOnly = true;
            // 
            // btnAddOption
            // 
            this.btnAddOption.Caption = "Add";
            this.btnAddOption.Id = 6;
            this.btnAddOption.ImageOptions.SvgImage = global::FileShadowWatcherGUI.Properties.Resources.actions_addcircled;
            this.btnAddOption.Name = "btnAddOption";
            toolTipTitleItem1.Text = "Add new Watcher";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Adds a new file watcher to the Options";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnAddOption.SuperTip = superToolTip1;
            this.btnAddOption.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddOption_ItemClick);
            // 
            // btnSaveOptions
            // 
            this.btnSaveOptions.Caption = "Save";
            this.btnSaveOptions.Id = 7;
            this.btnSaveOptions.ImageOptions.SvgImage = global::FileShadowWatcherGUI.Properties.Resources.save;
            this.btnSaveOptions.Name = "btnSaveOptions";
            this.btnSaveOptions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveOptions_ItemClick);
            // 
            // btnDeleteOption
            // 
            this.btnDeleteOption.Caption = "Delete";
            this.btnDeleteOption.Id = 8;
            this.btnDeleteOption.ImageOptions.SvgImage = global::FileShadowWatcherGUI.Properties.Resources.actions_deletecircled;
            this.btnDeleteOption.Name = "btnDeleteOption";
            this.btnDeleteOption.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteOption_ItemClick);
            // 
            // btnStart
            // 
            this.btnStart.Caption = "Start";
            this.btnStart.Id = 9;
            this.btnStart.ImageOptions.SvgImage = global::FileShadowWatcherGUI.Properties.Resources.gettingstarted;
            this.btnStart.Name = "btnStart";
            this.btnStart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStart_ItemClick);
            // 
            // btnStop
            // 
            this.btnStop.Caption = "Stop";
            this.btnStop.Id = 10;
            this.btnStop.ImageOptions.SvgImage = global::FileShadowWatcherGUI.Properties.Resources.actions_removecircled;
            this.btnStop.Name = "btnStop";
            this.btnStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStop_ItemClick);
            // 
            // btnPause
            // 
            this.btnPause.Caption = "Pause";
            this.btnPause.Id = 11;
            this.btnPause.ImageOptions.SvgImage = global::FileShadowWatcherGUI.Properties.Resources.security_stop;
            this.btnPause.Name = "btnPause";
            this.btnPause.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPause_ItemClick);
            // 
            // btnContinue
            // 
            this.btnContinue.Caption = "Continue";
            this.btnContinue.Id = 12;
            this.btnContinue.ImageOptions.SvgImage = global::FileShadowWatcherGUI.Properties.Resources.appointmentendcontinuearrow;
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnContinue_ItemClick);
            // 
            // btnRestart
            // 
            this.btnRestart.Caption = "Restart";
            this.btnRestart.Id = 13;
            this.btnRestart.ImageOptions.SvgImage = global::FileShadowWatcherGUI.Properties.Resources.recurrence;
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestart_ItemClick);
            // 
            // btnShowLogFile
            // 
            this.btnShowLogFile.Caption = "Show Logfile";
            this.btnShowLogFile.Id = 14;
            this.btnShowLogFile.ImageOptions.SvgImage = global::FileShadowWatcherGUI.Properties.Resources.showallfieldresults;
            this.btnShowLogFile.Name = "btnShowLogFile";
            this.btnShowLogFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowLogFile_ItemClick);
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "About";
            this.btnAbout.Id = 15;
            this.btnAbout.ImageOptions.SvgImage = global::FileShadowWatcherGUI.Properties.Resources.about;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAbout_ItemClick);
            // 
            // rpStart
            // 
            this.rpStart.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgOptions,
            this.rpgService,
            this.rpgTools});
            this.rpStart.Name = "rpStart";
            this.rpStart.Text = "Start";
            // 
            // rpgOptions
            // 
            this.rpgOptions.ItemLinks.Add(this.btnAddOption);
            this.rpgOptions.ItemLinks.Add(this.btnSaveOptions);
            this.rpgOptions.ItemLinks.Add(this.btnDeleteOption);
            this.rpgOptions.Name = "rpgOptions";
            this.rpgOptions.Text = "Options";
            // 
            // rpgService
            // 
            this.rpgService.ItemLinks.Add(this.btnStart);
            this.rpgService.ItemLinks.Add(this.btnStop);
            this.rpgService.ItemLinks.Add(this.btnPause);
            this.rpgService.ItemLinks.Add(this.btnContinue);
            this.rpgService.ItemLinks.Add(this.btnRestart);
            this.rpgService.Name = "rpgService";
            this.rpgService.Text = "Service";
            // 
            // rpgTools
            // 
            this.rpgTools.ItemLinks.Add(this.btnShowLogFile);
            this.rpgTools.ItemLinks.Add(this.btnAbout);
            this.rpgTools.Name = "rpgTools";
            this.rpgTools.Text = "Tools";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barEditItemInstalled);
            this.ribbonStatusBar.ItemLinks.Add(this.barEditItemRunning);
            this.ribbonStatusBar.ItemLinks.Add(this.barEditItemPaused);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 566);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1009, 24);
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 545);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1009, 21);
            this.panelControl1.TabIndex = 2;
            // 
            // splitContainerControlOptions
            // 
            this.splitContainerControlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlOptions.Location = new System.Drawing.Point(0, 158);
            this.splitContainerControlOptions.Name = "splitContainerControlOptions";
            this.splitContainerControlOptions.Panel1.Controls.Add(this.gridControlOptions);
            this.splitContainerControlOptions.Panel2.Controls.Add(this.x_Options1);
            this.splitContainerControlOptions.Size = new System.Drawing.Size(1009, 387);
            this.splitContainerControlOptions.SplitterPosition = 304;
            this.splitContainerControlOptions.TabIndex = 3;
            // 
            // gridControlOptions
            // 
            this.gridControlOptions.DataSource = this.bindingSourceOptions;
            this.gridControlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOptions.Location = new System.Drawing.Point(0, 0);
            this.gridControlOptions.MainView = this.tileViewOptions;
            this.gridControlOptions.MenuManager = this.ribbon;
            this.gridControlOptions.Name = "gridControlOptions";
            this.gridControlOptions.Size = new System.Drawing.Size(304, 387);
            this.gridControlOptions.TabIndex = 0;
            this.gridControlOptions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileViewOptions});
            // 
            // bindingSourceOptions
            // 
            this.bindingSourceOptions.DataSource = typeof(FileShadowWatcherShared.WatcherFolderOption);
            this.bindingSourceOptions.CurrentChanged += new System.EventHandler(this.bindingSourceOptions_CurrentChanged);
            this.bindingSourceOptions.PositionChanged += new System.EventHandler(this.bindingSourceOptions_PositionChanged);
            // 
            // tileViewOptions
            // 
            this.tileViewOptions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFolderGUID,
            this.colFolderEnabled,
            this.colFolderDescription,
            this.colFolderFilter,
            this.colFolderPath,
            this.colFolderIncludeSub,
            this.colTrashFolder,
            this.colUseSubFolderEventNames,
            this.colUseForensicsFactory,
            this.colUseDate,
            this.colDaysToStore});
            this.tileViewOptions.GridControl = this.gridControlOptions;
            this.tileViewOptions.Name = "tileViewOptions";
            this.tileViewOptions.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileViewOptions.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            tableColumnDefinition1.Length.Value = 80D;
            tableColumnDefinition2.Length.Value = 111D;
            tableColumnDefinition3.Length.Value = 33D;
            this.tileViewOptions.TileColumns.Add(tableColumnDefinition1);
            this.tileViewOptions.TileColumns.Add(tableColumnDefinition2);
            this.tileViewOptions.TileColumns.Add(tableColumnDefinition3);
            tableRowDefinition1.Length.Value = 34D;
            tableRowDefinition2.Length.Value = 50D;
            tableRowDefinition3.Length.Value = 20D;
            this.tileViewOptions.TileRows.Add(tableRowDefinition1);
            this.tileViewOptions.TileRows.Add(tableRowDefinition2);
            this.tileViewOptions.TileRows.Add(tableRowDefinition3);
            tableSpan1.ColumnSpan = 2;
            tableSpan2.ColumnSpan = 2;
            tableSpan2.RowIndex = 2;
            tableSpan3.ColumnSpan = 3;
            tableSpan3.RowIndex = 1;
            this.tileViewOptions.TileSpans.Add(tableSpan1);
            this.tileViewOptions.TileSpans.Add(tableSpan2);
            this.tileViewOptions.TileSpans.Add(tableSpan3);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.Blue;
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement1.Column = this.colFolderPath;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "colFolderPath";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement2.Column = this.colDaysToStore;
            tileViewItemElement2.ColumnIndex = 2;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.RowIndex = 2;
            tileViewItemElement2.Text = "colDaysToStore";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileViewItemElement3.Column = this.colTrashFolder;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.RowIndex = 2;
            tileViewItemElement3.Text = "colTrashFolder";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement4.Column = this.colFolderDescription;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.RowIndex = 1;
            tileViewItemElement4.Text = "colFolderDescription";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileViewOptions.TileTemplate.Add(tileViewItemElement1);
            this.tileViewOptions.TileTemplate.Add(tileViewItemElement2);
            this.tileViewOptions.TileTemplate.Add(tileViewItemElement3);
            this.tileViewOptions.TileTemplate.Add(tileViewItemElement4);
            // 
            // colFolderGUID
            // 
            this.colFolderGUID.FieldName = "FolderGUID";
            this.colFolderGUID.Name = "colFolderGUID";
            this.colFolderGUID.Visible = true;
            this.colFolderGUID.VisibleIndex = 0;
            // 
            // colFolderEnabled
            // 
            this.colFolderEnabled.FieldName = "FolderEnabled";
            this.colFolderEnabled.Name = "colFolderEnabled";
            this.colFolderEnabled.Visible = true;
            this.colFolderEnabled.VisibleIndex = 1;
            // 
            // colFolderFilter
            // 
            this.colFolderFilter.FieldName = "FolderFilter";
            this.colFolderFilter.Name = "colFolderFilter";
            this.colFolderFilter.Visible = true;
            this.colFolderFilter.VisibleIndex = 3;
            // 
            // colFolderIncludeSub
            // 
            this.colFolderIncludeSub.FieldName = "FolderIncludeSub";
            this.colFolderIncludeSub.Name = "colFolderIncludeSub";
            this.colFolderIncludeSub.Visible = true;
            this.colFolderIncludeSub.VisibleIndex = 5;
            // 
            // colUseSubFolderEventNames
            // 
            this.colUseSubFolderEventNames.FieldName = "UseSubFolderEventNames";
            this.colUseSubFolderEventNames.Name = "colUseSubFolderEventNames";
            this.colUseSubFolderEventNames.Visible = true;
            this.colUseSubFolderEventNames.VisibleIndex = 7;
            // 
            // colUseForensicsFactory
            // 
            this.colUseForensicsFactory.FieldName = "UseForensicsFactory";
            this.colUseForensicsFactory.Name = "colUseForensicsFactory";
            this.colUseForensicsFactory.Visible = true;
            this.colUseForensicsFactory.VisibleIndex = 8;
            // 
            // colUseDate
            // 
            this.colUseDate.FieldName = "UseDate";
            this.colUseDate.Name = "colUseDate";
            this.colUseDate.Visible = true;
            this.colUseDate.VisibleIndex = 9;
            // 
            // x_Options1
            // 
            this.x_Options1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x_Options1.Location = new System.Drawing.Point(0, 0);
            this.x_Options1.Name = "x_Options1";
            this.x_Options1.Size = new System.Drawing.Size(695, 387);
            this.x_Options1.TabIndex = 0;
            this.x_Options1.UIFactory = null;
            // 
            // timerService
            // 
            this.timerService.Interval = 60000;
            this.timerService.Tick += new System.EventHandler(this.timerService_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 590);
            this.Controls.Add(this.splitContainerControlOptions);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ShadowFileWatcher";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitchRunning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitchPaused)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitchInstalled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlOptions)).EndInit();
            this.splitContainerControlOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpStart;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgOptions;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlOptions;
        private DevExpress.XtraGrid.GridControl gridControlOptions;
        private DevExpress.XtraGrid.Views.Tile.TileView tileViewOptions;
        private System.Windows.Forms.BindingSource bindingSourceOptions;
        private DevExpress.XtraGrid.Columns.TileViewColumn colFolderGUID;
        private DevExpress.XtraGrid.Columns.TileViewColumn colFolderEnabled;
        private DevExpress.XtraGrid.Columns.TileViewColumn colFolderDescription;
        private DevExpress.XtraGrid.Columns.TileViewColumn colFolderFilter;
        private DevExpress.XtraGrid.Columns.TileViewColumn colFolderPath;
        private DevExpress.XtraGrid.Columns.TileViewColumn colFolderIncludeSub;
        private DevExpress.XtraGrid.Columns.TileViewColumn colTrashFolder;
        private DevExpress.XtraGrid.Columns.TileViewColumn colUseSubFolderEventNames;
        private DevExpress.XtraGrid.Columns.TileViewColumn colUseForensicsFactory;
        private DevExpress.XtraGrid.Columns.TileViewColumn colUseDate;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDaysToStore;
        private x_Options x_Options1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitchRunning;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitchPaused;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitchInstalled;
        private DevExpress.XtraBars.BarButtonItem btnAddOption;
        private DevExpress.XtraBars.BarButtonItem btnSaveOptions;
        private DevExpress.XtraBars.BarButtonItem btnDeleteOption;
        private DevExpress.XtraBars.BarButtonItem btnStart;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgService;
        private DevExpress.XtraBars.BarButtonItem btnStop;
        private DevExpress.XtraBars.BarButtonItem btnPause;
        private DevExpress.XtraBars.BarButtonItem btnContinue;
        private DevExpress.XtraBars.BarButtonItem btnRestart;
        private System.Windows.Forms.Timer timerService;
        internal DevExpress.XtraBars.BarEditItem barEditItemInstalled;
        internal DevExpress.XtraBars.BarEditItem barEditItemRunning;
        internal DevExpress.XtraBars.BarEditItem barEditItemPaused;
        private DevExpress.XtraBars.BarButtonItem btnShowLogFile;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTools;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
    }
}