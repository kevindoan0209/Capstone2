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
            DevExpress.DataAccess.Sql.TableQuery tableQuery2 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo2 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo3 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo7 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo8 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo9 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo10 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo11 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo4 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo12 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.txtTimKiem);
            this.panelControl2.Name = "panelControl2";
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Name = "simpleButton1";
            // 
            // txtTimKiem
            // 
            resources.ApplyResources(this.txtTimKiem, "txtTimKiem");
            this.txtTimKiem.Name = "txtTimKiem";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnLamMoi);
            this.panelControl1.Controls.Add(this.btnThem);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
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
            // grcDanhMuc
            // 
            this.grcDanhMuc.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.grcDanhMuc, "grcDanhMuc");
            this.grcDanhMuc.DataSource = this.sqlDataSource1;
            this.grcDanhMuc.MainView = this.gvData;
            this.grcDanhMuc.Name = "grcDanhMuc";
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
            tableQuery2.Name = "Paraclinical";
            relationColumnInfo2.NestedKeyColumn = "Paraclinical_Group_ID";
            relationColumnInfo2.ParentKeyColumn = "Paraclinical_Group_ID";
            relationInfo2.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo2});
            relationInfo2.NestedTable = "Paraclinical_Group";
            relationInfo2.ParentTable = "Paraclinical";
            tableQuery2.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo2});
            tableInfo3.Name = "Paraclinical";
            columnInfo7.Name = "Paraclinical_ID";
            columnInfo8.Name = "Paraclinical_Name";
            columnInfo9.Name = "Paraclinical_ReferenceValue";
            columnInfo10.Name = "Paraclinical_ValueMin";
            columnInfo11.Name = "Paraclinical_ValueMax";
            tableInfo3.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo7,
            columnInfo8,
            columnInfo9,
            columnInfo10,
            columnInfo11});
            tableInfo4.Name = "Paraclinical_Group";
            columnInfo12.Name = "Paraclinical_Group_Name";
            tableInfo4.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo12});
            tableQuery2.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo3,
            tableInfo4});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gvData
            // 
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
            this.gvData.OptionsFind.AlwaysVisible = true;
            this.gvData.OptionsFind.FindNullPrompt = "Nhập vào thông tin tìm kiếm...";
            // 
            // colParaclinical_ID
            // 
            this.colParaclinical_ID.FieldName = "Paraclinical_ID";
            this.colParaclinical_ID.Name = "colParaclinical_ID";
            resources.ApplyResources(this.colParaclinical_ID, "colParaclinical_ID");
            // 
            // colParaclinical_Name
            // 
            this.colParaclinical_Name.FieldName = "Paraclinical_Name";
            this.colParaclinical_Name.Name = "colParaclinical_Name";
            resources.ApplyResources(this.colParaclinical_Name, "colParaclinical_Name");
            // 
            // colParaclinical_ReferenceValue
            // 
            this.colParaclinical_ReferenceValue.FieldName = "Paraclinical_ReferenceValue";
            this.colParaclinical_ReferenceValue.Name = "colParaclinical_ReferenceValue";
            resources.ApplyResources(this.colParaclinical_ReferenceValue, "colParaclinical_ReferenceValue");
            // 
            // colParaclinical_ValueMin
            // 
            this.colParaclinical_ValueMin.FieldName = "Paraclinical_ValueMin";
            this.colParaclinical_ValueMin.Name = "colParaclinical_ValueMin";
            resources.ApplyResources(this.colParaclinical_ValueMin, "colParaclinical_ValueMin");
            // 
            // colParaclinical_ValueMax
            // 
            this.colParaclinical_ValueMax.FieldName = "Paraclinical_ValueMax";
            this.colParaclinical_ValueMax.Name = "colParaclinical_ValueMax";
            resources.ApplyResources(this.colParaclinical_ValueMax, "colParaclinical_ValueMax");
            // 
            // colParaclinical_Group_Name
            // 
            this.colParaclinical_Group_Name.FieldName = "Paraclinical_Group_Name";
            this.colParaclinical_Group_Name.Name = "colParaclinical_Group_Name";
            resources.ApplyResources(this.colParaclinical_Group_Name, "colParaclinical_Group_Name");
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Name = "labelControl1";
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
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtTimKiem;
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
    }
}