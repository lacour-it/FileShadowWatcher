namespace FileShadowWatcherGUI
{
    partial class u_WatcherOptions
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(u_WatcherOptions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelectWatcher = new System.Windows.Forms.ComboBox();
            this.watcherFolderOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtGUID = new System.Windows.Forms.TextBox();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFolderFilter = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.chkSubDirs = new System.Windows.Forms.CheckBox();
            this.bntDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.watcherChangeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.executablePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executableArgsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventExecutableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bindingNavigatorEvents = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watcherFolderOptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventExecutableBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEvents)).BeginInit();
            this.bindingNavigatorEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 38);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Instances";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.02098F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.97902F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbSelectWatcher, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGUID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFolderPath, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtFolderFilter, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.chkEnabled, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.chkSubDirs, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.bntDelete, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPath, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(49, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.86274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.13726F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 298);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "GUID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instance";
            // 
            // cmbSelectWatcher
            // 
            this.cmbSelectWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbSelectWatcher.DataSource = this.watcherFolderOptionBindingSource;
            this.cmbSelectWatcher.DisplayMember = "FolderPath";
            this.cmbSelectWatcher.FormattingEnabled = true;
            this.cmbSelectWatcher.Location = new System.Drawing.Point(85, 8);
            this.cmbSelectWatcher.Name = "cmbSelectWatcher";
            this.cmbSelectWatcher.Size = new System.Drawing.Size(196, 21);
            this.cmbSelectWatcher.TabIndex = 1;
            this.cmbSelectWatcher.ValueMember = "FolderGUID";
            // 
            // watcherFolderOptionBindingSource
            // 
            this.watcherFolderOptionBindingSource.DataSource = typeof(FileShadowWatcherShared.WatcherFolderOption);
            this.watcherFolderOptionBindingSource.CurrentChanged += new System.EventHandler(this.watcherFolderOptionBindingSource_CurrentChanged);
            // 
            // txtGUID
            // 
            this.txtGUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGUID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watcherFolderOptionBindingSource, "FolderGUID", true));
            this.txtGUID.Location = new System.Drawing.Point(85, 60);
            this.txtGUID.Name = "txtGUID";
            this.txtGUID.Size = new System.Drawing.Size(196, 20);
            this.txtGUID.TabIndex = 3;
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFolderPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watcherFolderOptionBindingSource, "FolderPath", true));
            this.txtFolderPath.Location = new System.Drawing.Point(85, 99);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(196, 20);
            this.txtFolderPath.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filter";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enabled";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Subdirectories";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Description";
            // 
            // txtFolderFilter
            // 
            this.txtFolderFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFolderFilter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watcherFolderOptionBindingSource, "FolderFilter", true));
            this.txtFolderFilter.Location = new System.Drawing.Point(85, 135);
            this.txtFolderFilter.Name = "txtFolderFilter";
            this.txtFolderFilter.Size = new System.Drawing.Size(196, 20);
            this.txtFolderFilter.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watcherFolderOptionBindingSource, "FolderDescription", true));
            this.txtDescription.Location = new System.Drawing.Point(85, 260);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 20);
            this.txtDescription.TabIndex = 13;
            // 
            // chkEnabled
            // 
            this.chkEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.watcherFolderOptionBindingSource, "FolderEnabled", true));
            this.chkEnabled.Location = new System.Drawing.Point(85, 180);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(15, 14);
            this.chkEnabled.TabIndex = 14;
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // chkSubDirs
            // 
            this.chkSubDirs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSubDirs.AutoSize = true;
            this.chkSubDirs.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.watcherFolderOptionBindingSource, "FolderIncludeSub", true));
            this.chkSubDirs.Location = new System.Drawing.Point(85, 220);
            this.chkSubDirs.Name = "chkSubDirs";
            this.chkSubDirs.Size = new System.Drawing.Size(15, 14);
            this.chkSubDirs.TabIndex = 15;
            this.chkSubDirs.UseVisualStyleBackColor = true;
            // 
            // bntDelete
            // 
            this.bntDelete.Image = global::FileShadowWatcherGUI.Properties.Resources.Action_Delete;
            this.bntDelete.Location = new System.Drawing.Point(345, 35);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(55, 19);
            this.bntDelete.TabIndex = 17;
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::FileShadowWatcherGUI.Properties.Resources.Save_16x16;
            this.btnSave.Location = new System.Drawing.Point(345, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 21);
            this.btnSave.TabIndex = 16;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::FileShadowWatcherGUI.Properties.Resources.Add_16x16;
            this.btnAdd.Location = new System.Drawing.Point(287, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPath
            // 
            this.btnPath.Image = global::FileShadowWatcherGUI.Properties.Resources.Open2_16x16;
            this.btnPath.Location = new System.Drawing.Point(287, 96);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(52, 23);
            this.btnPath.TabIndex = 19;
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.AutoGenerateColumns = false;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.watcherChangeTypeDataGridViewTextBoxColumn,
            this.executablePathDataGridViewTextBoxColumn,
            this.executableArgsDataGridViewTextBoxColumn});
            this.dataGridViewEvents.DataSource = this.eventExecutableBindingSource;
            this.dataGridViewEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewEvents.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.Size = new System.Drawing.Size(385, 114);
            this.dataGridViewEvents.TabIndex = 2;
            // 
            // watcherChangeTypeDataGridViewTextBoxColumn
            // 
            this.watcherChangeTypeDataGridViewTextBoxColumn.DataPropertyName = "WatcherChangeType";
            this.watcherChangeTypeDataGridViewTextBoxColumn.HeaderText = "WatcherChangeType";
            this.watcherChangeTypeDataGridViewTextBoxColumn.Name = "watcherChangeTypeDataGridViewTextBoxColumn";
            this.watcherChangeTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.watcherChangeTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // executablePathDataGridViewTextBoxColumn
            // 
            this.executablePathDataGridViewTextBoxColumn.DataPropertyName = "ExecutablePath";
            this.executablePathDataGridViewTextBoxColumn.HeaderText = "ExecutablePath";
            this.executablePathDataGridViewTextBoxColumn.Name = "executablePathDataGridViewTextBoxColumn";
            // 
            // executableArgsDataGridViewTextBoxColumn
            // 
            this.executableArgsDataGridViewTextBoxColumn.DataPropertyName = "ExecutableArgs";
            this.executableArgsDataGridViewTextBoxColumn.HeaderText = "ExecutableArgs";
            this.executableArgsDataGridViewTextBoxColumn.Name = "executableArgsDataGridViewTextBoxColumn";
            // 
            // eventExecutableBindingSource
            // 
            this.eventExecutableBindingSource.DataSource = typeof(FileShadowWatcherShared.EventExecutable);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bindingNavigatorEvents);
            this.panel2.Controls.Add(this.dataGridViewEvents);
            this.panel2.Location = new System.Drawing.Point(49, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 149);
            this.panel2.TabIndex = 3;
            // 
            // bindingNavigatorEvents
            // 
            this.bindingNavigatorEvents.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorEvents.BindingSource = this.eventExecutableBindingSource;
            this.bindingNavigatorEvents.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorEvents.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorEvents.Location = new System.Drawing.Point(0, 114);
            this.bindingNavigatorEvents.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorEvents.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorEvents.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorEvents.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorEvents.Name = "bindingNavigatorEvents";
            this.bindingNavigatorEvents.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorEvents.Size = new System.Drawing.Size(385, 25);
            this.bindingNavigatorEvents.TabIndex = 3;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // u_WatcherOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "u_WatcherOptions";
            this.Size = new System.Drawing.Size(551, 574);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watcherFolderOptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventExecutableBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEvents)).EndInit();
            this.bindingNavigatorEvents.ResumeLayout(false);
            this.bindingNavigatorEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelectWatcher;
        private System.Windows.Forms.BindingSource watcherFolderOptionBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGUID;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFolderFilter;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.CheckBox chkSubDirs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.DataGridViewComboBoxColumn watcherChangeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn executablePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn executableArgsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eventExecutableBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingNavigator bindingNavigatorEvents;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPath;
    }
}
