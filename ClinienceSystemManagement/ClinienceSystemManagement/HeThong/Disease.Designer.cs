namespace ClinienceSystemManagement.HeThong
{
    partial class Disease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disease));
            DevExpress.DataAccess.Sql.TableQuery tableQuery2 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo2 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo4 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo5 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo6 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.cmsXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.searchControl2 = new DevExpress.XtraEditors.SearchControl();
            this.grcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDisease_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisease_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisease_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsXoa
            // 
            this.cmsXoa.BackColor = System.Drawing.SystemColors.Control;
            this.cmsXoa.Name = "cmsXoa";
            resources.ApplyResources(this.cmsXoa, "cmsXoa");
            this.cmsXoa.Click += new System.EventHandler(this.cmsXoa_Click);
            // 
            // cmsCapNhat
            // 
            this.cmsCapNhat.BackColor = System.Drawing.SystemColors.Control;
            this.cmsCapNhat.Name = "cmsCapNhat";
            resources.ApplyResources(this.cmsCapNhat, "cmsCapNhat");
            this.cmsCapNhat.Click += new System.EventHandler(this.cmsCapNhat_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCapNhat,
            this.cmsXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Name = "labelControl1";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            resources.ApplyResources(this.btnLamMoi, "btnLamMoi");
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            resources.ApplyResources(this.btnThem, "btnThem");
            this.btnThem.Name = "btnThem";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnLamMoi);
            this.panelControl1.Controls.Add(this.btnThem);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // panelControl2
            // 
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Controls.Add(this.groupBox1);
            this.panelControl2.Name = "panelControl2";
            // 
            // searchControl2
            // 
            resources.ApplyResources(this.searchControl2, "searchControl2");
            this.searchControl2.Client = this.grcDanhMuc;
            this.searchControl2.Name = "searchControl2";
            this.searchControl2.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("searchControl2.Properties.Appearance.Font")));
            this.searchControl2.Properties.Appearance.Options.UseFont = true;
            this.searchControl2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl2.Properties.Client = this.grcDanhMuc;
            this.searchControl2.Properties.NullValuePrompt = resources.GetString("searchControl2.Properties.NullValuePrompt");
            // 
            // grcDanhMuc
            // 
            this.grcDanhMuc.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.grcDanhMuc, "grcDanhMuc");
            this.grcDanhMuc.DataSource = this.sqlDataSource2;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.TextStringFormat = resources.GetString("grcDanhMuc.EmbeddedNavigator.TextStringFormat");
            this.grcDanhMuc.MainView = this.gvDanhMuc;
            this.grcDanhMuc.Name = "grcDanhMuc";
            this.grcDanhMuc.UseEmbeddedNavigator = true;
            this.grcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            tableQuery2.Name = "Disease";
            tableInfo2.Name = "Disease";
            columnInfo4.Name = "Disease_ID";
            columnInfo5.Name = "Disease_Name";
            columnInfo6.Name = "Disease_Description";
            tableInfo2.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo4,
            columnInfo5,
            columnInfo6});
            tableQuery2.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo2});
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("gvDanhMuc.Appearance.HeaderPanel.Font")));
            this.gvDanhMuc.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDanhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDisease_ID,
            this.colDisease_Name,
            this.colDisease_Description});
            this.gvDanhMuc.GridControl = this.grcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.OptionsFind.AllowFindPanel = false;
            this.gvDanhMuc.OptionsFind.AlwaysVisible = true;
            this.gvDanhMuc.OptionsFind.FindNullPrompt = "Nhập vào thông tin tìm kiếm...";
            this.gvDanhMuc.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDanhMuc.OptionsView.ShowFooter = true;
            // 
            // colDisease_ID
            // 
            resources.ApplyResources(this.colDisease_ID, "colDisease_ID");
            this.colDisease_ID.FieldName = "Disease_ID";
            this.colDisease_ID.Name = "colDisease_ID";
            // 
            // colDisease_Name
            // 
            resources.ApplyResources(this.colDisease_Name, "colDisease_Name");
            this.colDisease_Name.FieldName = "Disease_Name";
            this.colDisease_Name.Name = "colDisease_Name";
            // 
            // colDisease_Description
            // 
            resources.ApplyResources(this.colDisease_Description, "colDisease_Description");
            this.colDisease_Description.FieldName = "Disease_Description";
            this.colDisease_Description.Name = "colDisease_Description";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.searchControl2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Disease
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcDanhMuc);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "Disease";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsCapNhat;
        private System.Windows.Forms.ToolStripMenuItem cmsXoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.GridControl grcDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colDisease_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDisease_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colDisease_Description;
        private DevExpress.XtraEditors.SearchControl searchControl2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}