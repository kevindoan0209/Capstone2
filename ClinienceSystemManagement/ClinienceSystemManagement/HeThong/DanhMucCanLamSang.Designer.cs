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
            DevExpress.DataAccess.Sql.TableQuery tableQuery4 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo4 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo4 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo7 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo19 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo20 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo21 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo22 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo23 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo8 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo24 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colParaclinical_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParaclinical_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParaclinical_ReferenceValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParaclinical_ValueMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParaclinical_ValueMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParaclinical_Group_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.panelControl1.Controls.Add(this.btnThem);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            resources.ApplyResources(this.btnThem, "btnThem");
            this.btnThem.Name = "btnThem";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            tableQuery4.Name = "Paraclinical";
            relationColumnInfo4.NestedKeyColumn = "Paraclinical_Group_ID";
            relationColumnInfo4.ParentKeyColumn = "Paraclinical_Group_ID";
            relationInfo4.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo4});
            relationInfo4.NestedTable = "Paraclinical_Group";
            relationInfo4.ParentTable = "Paraclinical";
            tableQuery4.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo4});
            tableInfo7.Name = "Paraclinical";
            columnInfo19.Name = "Paraclinical_ID";
            columnInfo20.Name = "Paraclinical_Name";
            columnInfo21.Name = "Paraclinical_ReferenceValue";
            columnInfo22.Name = "Paraclinical_ValueMin";
            columnInfo23.Name = "Paraclinical_ValueMax";
            tableInfo7.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo19,
            columnInfo20,
            columnInfo21,
            columnInfo22,
            columnInfo23});
            tableInfo8.Name = "Paraclinical_Group";
            columnInfo24.Name = "Paraclinical_Group_Name";
            tableInfo8.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo24});
            tableQuery4.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo7,
            tableInfo8});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery4});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colParaclinical_ID,
            this.colParaclinical_Name,
            this.colParaclinical_ReferenceValue,
            this.colParaclinical_ValueMin,
            this.colParaclinical_ValueMax,
            this.colParaclinical_Group_Name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary"))), resources.GetString("gridView1.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary2"))), resources.GetString("gridView1.GroupSummary3"))});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Nhập vào thông tin tìm kiếm...";
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
            // DanhMucCanLamSang
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "DanhMucCanLamSang";
            this.Load += new System.EventHandler(this.DanhMucCanLamSang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colParaclinical_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colParaclinical_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colParaclinical_ReferenceValue;
        private DevExpress.XtraGrid.Columns.GridColumn colParaclinical_ValueMin;
        private DevExpress.XtraGrid.Columns.GridColumn colParaclinical_ValueMax;
        private DevExpress.XtraGrid.Columns.GridColumn colParaclinical_Group_Name;
    }
}