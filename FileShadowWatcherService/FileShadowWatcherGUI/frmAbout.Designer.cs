namespace FileShadowWatcherGUI
{
    partial class frmAbout
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItemName = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.textEditVersion = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItemVersion = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEditPath = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItemPath = new DevExpress.XtraLayout.LayoutControlItem();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.textEditCompany = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItemCompany = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEditAssembly = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItemAssembly = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAssembly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAssembly)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 197);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(490, 85);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(190, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEditAssembly);
            this.layoutControl1.Controls.Add(this.textEditCompany);
            this.layoutControl1.Controls.Add(this.textEditPath);
            this.layoutControl1.Controls.Add(this.textEditVersion);
            this.layoutControl1.Controls.Add(this.textEditName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(490, 197);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemName,
            this.emptySpaceItem1,
            this.layoutControlItemVersion,
            this.layoutControlItemPath,
            this.layoutControlItemAssembly,
            this.layoutControlItemCompany});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(490, 197);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(60, 12);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.ReadOnly = true;
            this.textEditName.Size = new System.Drawing.Size(418, 20);
            this.textEditName.StyleController = this.layoutControl1;
            this.textEditName.TabIndex = 4;
            // 
            // layoutControlItemName
            // 
            this.layoutControlItemName.Control = this.textEditName;
            this.layoutControlItemName.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemName.Name = "layoutControlItemName";
            this.layoutControlItemName.Size = new System.Drawing.Size(470, 24);
            this.layoutControlItemName.Text = "Name";
            this.layoutControlItemName.TextSize = new System.Drawing.Size(45, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(470, 57);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // textEditVersion
            // 
            this.textEditVersion.Location = new System.Drawing.Point(60, 36);
            this.textEditVersion.Name = "textEditVersion";
            this.textEditVersion.Properties.ReadOnly = true;
            this.textEditVersion.Size = new System.Drawing.Size(418, 20);
            this.textEditVersion.StyleController = this.layoutControl1;
            this.textEditVersion.TabIndex = 5;
            // 
            // layoutControlItemVersion
            // 
            this.layoutControlItemVersion.Control = this.textEditVersion;
            this.layoutControlItemVersion.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemVersion.Name = "layoutControlItemVersion";
            this.layoutControlItemVersion.Size = new System.Drawing.Size(470, 24);
            this.layoutControlItemVersion.Text = "Version";
            this.layoutControlItemVersion.TextSize = new System.Drawing.Size(45, 13);
            // 
            // textEditPath
            // 
            this.textEditPath.Location = new System.Drawing.Point(60, 84);
            this.textEditPath.Name = "textEditPath";
            this.textEditPath.Properties.ReadOnly = true;
            this.textEditPath.Size = new System.Drawing.Size(418, 20);
            this.textEditPath.StyleController = this.layoutControl1;
            this.textEditPath.TabIndex = 6;
            // 
            // layoutControlItemPath
            // 
            this.layoutControlItemPath.Control = this.textEditPath;
            this.layoutControlItemPath.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItemPath.Name = "layoutControlItemPath";
            this.layoutControlItemPath.Size = new System.Drawing.Size(470, 24);
            this.layoutControlItemPath.Text = "Path";
            this.layoutControlItemPath.TextSize = new System.Drawing.Size(45, 13);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::FileShadowWatcherGUI.Properties.Resources.Final_LIT_Logo_klein;
            this.pictureEdit1.Location = new System.Drawing.Point(13, 7);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(102, 66);
            this.pictureEdit1.TabIndex = 1;
            // 
            // textEditCompany
            // 
            this.textEditCompany.Location = new System.Drawing.Point(60, 60);
            this.textEditCompany.Name = "textEditCompany";
            this.textEditCompany.Properties.ReadOnly = true;
            this.textEditCompany.Size = new System.Drawing.Size(418, 20);
            this.textEditCompany.StyleController = this.layoutControl1;
            this.textEditCompany.TabIndex = 7;
            // 
            // layoutControlItemCompany
            // 
            this.layoutControlItemCompany.Control = this.textEditCompany;
            this.layoutControlItemCompany.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemCompany.Name = "layoutControlItemCompany";
            this.layoutControlItemCompany.Size = new System.Drawing.Size(470, 24);
            this.layoutControlItemCompany.Text = "Company";
            this.layoutControlItemCompany.TextSize = new System.Drawing.Size(45, 13);
            // 
            // textEditAssembly
            // 
            this.textEditAssembly.Location = new System.Drawing.Point(60, 108);
            this.textEditAssembly.Name = "textEditAssembly";
            this.textEditAssembly.Properties.ReadOnly = true;
            this.textEditAssembly.Size = new System.Drawing.Size(418, 20);
            this.textEditAssembly.StyleController = this.layoutControl1;
            this.textEditAssembly.TabIndex = 8;
            // 
            // layoutControlItemAssembly
            // 
            this.layoutControlItemAssembly.Control = this.textEditAssembly;
            this.layoutControlItemAssembly.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItemAssembly.Name = "layoutControlItemAssembly";
            this.layoutControlItemAssembly.Size = new System.Drawing.Size(470, 24);
            this.layoutControlItemAssembly.Text = "Assembly";
            this.layoutControlItemAssembly.TextSize = new System.Drawing.Size(45, 13);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 282);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmAbout";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAssembly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAssembly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit textEditPath;
        private DevExpress.XtraEditors.TextEdit textEditVersion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemVersion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemPath;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit textEditAssembly;
        private DevExpress.XtraEditors.TextEdit textEditCompany;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemAssembly;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCompany;
    }
}