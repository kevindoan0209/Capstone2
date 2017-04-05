namespace ClinienceSystemManagement
{
    partial class DanhMucCanLamSang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMucCanLamSang));
            DevExpress.DataAccess.Sql.TableQuery tableQuery1 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo1 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo1 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo1 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo2 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo3 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo4 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo5 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo2 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo6 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchControl2 = new DevExpress.XtraEditors.SearchControl();
            this.grcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colParaclinical_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParaclinical_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParaclinical_ReferenceValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParaclinical_ValueMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParaclinical_ValueMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParaclinical_Group_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Controls.Add(this.groupBox1);
            this.panelControl2.Name = "panelControl2";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.searchControl2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
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
            this.grcDanhMuc.DataSource = this.sqlDataSource1;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.TextStringFormat = resources.GetString("grcDanhMuc.EmbeddedNavigator.TextStringFormat");
            this.grcDanhMuc.MainView = this.gvData;
            this.grcDanhMuc.Name = "grcDanhMuc";
            this.grcDanhMuc.UseEmbeddedNavigator = true;
            this.grcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCapNhat,
            this.cmsXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // cmsCapNhat
            // 
            this.cmsCapNhat.BackColor = System.Drawing.SystemColors.Control;
            this.cmsCapNhat.Name = "cmsCapNhat";
            resources.ApplyResources(this.cmsCapNhat, "cmsCapNhat");
            this.cmsCapNhat.Click += new System.EventHandler(this.cmsCapNhat_Click);
            // 
            // cmsXoa
            // 
            this.cmsXoa.BackColor = System.Drawing.SystemColors.Control;
            this.cmsXoa.Name = "cmsXoa";
            resources.ApplyResources(this.cmsXoa, "cmsXoa");
            this.cmsXoa.Click += new System.EventHandler(this.cmsXoa_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            tableQuery1.Name = "Paraclinical";
            relationColumnInfo1.NestedKeyColumn = "Paraclinical_Group_ID";
            relationColumnInfo1.ParentKeyColumn = "Paraclinical_Group_ID";
            relationInfo1.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo1});
            relationInfo1.NestedTable = "Paraclinical_Group";
            relationInfo1.ParentTable = "Paraclinical";
            tableQuery1.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo1});
            tableInfo1.Name = "Paraclinical";
            columnInfo1.Name = "Paraclinical_ID";
            columnInfo2.Name = "Paraclinical_Name";
            columnInfo3.Name = "Paraclinical_ReferenceValue";
            columnInfo4.Name = "Paraclinical_ValueMin";
            columnInfo5.Name = "Paraclinical_ValueMax";
            tableInfo1.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo1,
            columnInfo2,
            columnInfo3,
            columnInfo4,
            columnInfo5});
            tableInfo2.Name = "Paraclinical_Group";
            columnInfo6.Name = "Paraclinical_Group_Name";
            tableInfo2.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo6});
            tableQuery1.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo1,
            tableInfo2});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gvData
            // 
            this.gvData.Appearance.FixedLine.Font = ((System.Drawing.Font)(resources.GetObject("gvData.Appearance.FixedLine.Font")));
            this.gvData.Appearance.FixedLine.Options.UseFont = true;
            this.gvData.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("gvData.Appearance.HeaderPanel.Font")));
            this.gvData.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colParaclinical_ID,
            this.colParaclinical_Name,
            this.colParaclinical_ReferenceValue,
            this.colParaclinical_ValueMin,
            this.colParaclinical_ValueMax,
            this.colParaclinical_Group_Name});
            this.gvData.GridControl = this.grcDanhMuc;
            this.gvData.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gvData.GroupSummary"))), resources.GetString("gvData.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gvData.GroupSummary2"))), resources.GetString("gvData.GroupSummary3"))});
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsFind.FindNullPrompt = "Nhập vào thông tin tìm kiếm...";
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.ShowFooter = true;
            // 
            // colParaclinical_ID
            // 
            resources.ApplyResources(this.colParaclinical_ID, "colParaclinical_ID");
            this.colParaclinical_ID.FieldName = "Paraclinical_ID";
            this.colParaclinical_ID.Name = "colParaclinical_ID";
            // 
            // colParaclinical_Name
            // 
            resources.ApplyResources(this.colParaclinical_Name, "colParaclinical_Name");
            this.colParaclinical_Name.FieldName = "Paraclinical_Name";
            this.colParaclinical_Name.Name = "colParaclinical_Name";
            // 
            // colParaclinical_ReferenceValue
            // 
            resources.ApplyResources(this.colParaclinical_ReferenceValue, "colParaclinical_ReferenceValue");
            this.colParaclinical_ReferenceValue.FieldName = "Paraclinical_ReferenceValue";
            this.colParaclinical_ReferenceValue.Name = "colParaclinical_ReferenceValue";
            // 
            // colParaclinical_ValueMin
            // 
            resources.ApplyResources(this.colParaclinical_ValueMin, "colParaclinical_ValueMin");
            this.colParaclinical_ValueMin.FieldName = "Paraclinical_ValueMin";
            this.colParaclinical_ValueMin.Name = "colParaclinical_ValueMin";
            // 
            // colParaclinical_ValueMax
            // 
            resources.ApplyResources(this.colParaclinical_ValueMax, "colParaclinical_ValueMax");
            this.colParaclinical_ValueMax.FieldName = "Paraclinical_ValueMax";
            this.colParaclinical_ValueMax.Name = "colParaclinical_ValueMax";
            // 
            // colParaclinical_Group_Name
            // 
            resources.ApplyResources(this.colParaclinical_Group_Name, "colParaclinical_Group_Name");
            this.colParaclinical_Group_Name.FieldName = "Paraclinical_Group_Name";
            this.colParaclinical_Group_Name.Name = "colParaclinical_Group_Name";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnLamMoi);
            this.panelControl1.Controls.Add(this.btnThem);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
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
            // DanhMucCanLamSang
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcDanhMuc);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "DanhMucCanLamSang";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl grcDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colParaclinical_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colParaclinical_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colParaclinical_ReferenceValue;
        private DevExpress.XtraGrid.Columns.GridColumn colParaclinical_ValueMin;
        private DevExpress.XtraGrid.Columns.GridColumn colParaclinical_ValueMax;
        private DevExpress.XtraGrid.Columns.GridColumn colParaclinical_Group_Name;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsCapNhat;
        private System.Windows.Forms.ToolStripMenuItem cmsXoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SearchControl searchControl2;
    }
}