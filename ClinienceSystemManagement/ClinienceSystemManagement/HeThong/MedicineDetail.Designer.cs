namespace ClinienceSystemManagement.HeThong
{
    partial class MedicineDetail
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
            DevExpress.DataAccess.Sql.TableQuery tableQuery1 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo1 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo2 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo1 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo1 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo2 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo3 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo4 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo2 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo3 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo5 = new DevExpress.DataAccess.Sql.ColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineDetail));
            DevExpress.DataAccess.Sql.TableQuery tableQuery2 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo3 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo4 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo6 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo7 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo5 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo8 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery3 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo6 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo9 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo10 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo11 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo12 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.xtraTabContarol1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.grcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csmThem = new System.Windows.Forms.ToolStripMenuItem();
            this.csmCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.csmXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlDataSource5 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMedicine_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngredient_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContentUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngredient_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.lkeDonVi = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLopThuoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSuDung = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).BeginInit();
            this.xtraTabContarol1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLopThuoc.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabContarol1
            // 
            this.xtraTabContarol1.Location = new System.Drawing.Point(25, 12);
            this.xtraTabContarol1.Name = "xtraTabContarol1";
            this.xtraTabContarol1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabContarol1.Size = new System.Drawing.Size(459, 427);
            this.xtraTabContarol1.TabIndex = 9;
            this.xtraTabContarol1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage1});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.grcDanhMuc);
            this.xtraTabPage2.Controls.Add(this.txtTen);
            this.xtraTabPage2.Controls.Add(this.lkeDonVi);
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Controls.Add(this.txtLopThuoc);
            this.xtraTabPage2.Controls.Add(this.labelControl12);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(453, 399);
            this.xtraTabPage2.Text = "Chi tiết thuốc";
            // 
            // grcDanhMuc
            // 
            this.grcDanhMuc.ContextMenuStrip = this.contextMenuStrip1;
            this.grcDanhMuc.DataMember = "Medincine_Ingredient";
            this.grcDanhMuc.DataSource = this.sqlDataSource5;
            this.grcDanhMuc.EmbeddedNavigator.TextStringFormat = "Trang {0} / {1}";
            this.grcDanhMuc.Location = new System.Drawing.Point(20, 125);
            this.grcDanhMuc.MainView = this.gvDanhMuc;
            this.grcDanhMuc.Name = "grcDanhMuc";
            this.grcDanhMuc.Size = new System.Drawing.Size(405, 259);
            this.grcDanhMuc.TabIndex = 33;
            this.grcDanhMuc.UseEmbeddedNavigator = true;
            this.grcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csmThem,
            this.csmCapNhat,
            this.csmXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            // 
            // csmThem
            // 
            this.csmThem.Name = "csmThem";
            this.csmThem.Size = new System.Drawing.Size(122, 22);
            this.csmThem.Text = "Thêm";
            this.csmThem.Click += new System.EventHandler(this.csmThem_Click);
            // 
            // csmCapNhat
            // 
            this.csmCapNhat.Name = "csmCapNhat";
            this.csmCapNhat.Size = new System.Drawing.Size(122, 22);
            this.csmCapNhat.Text = "Cập nhật";
            this.csmCapNhat.Click += new System.EventHandler(this.csmCapNhat_Click);
            // 
            // csmXoa
            // 
            this.csmXoa.Name = "csmXoa";
            this.csmXoa.Size = new System.Drawing.Size(122, 22);
            this.csmXoa.Text = "Xóa";
            this.csmXoa.Click += new System.EventHandler(this.csmXoa_Click);
            // 
            // sqlDataSource5
            // 
            this.sqlDataSource5.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource5.Name = "sqlDataSource5";
            tableQuery1.Name = "Medincine_Ingredient";
            relationColumnInfo1.NestedKeyColumn = "Medicine_ID";
            relationColumnInfo1.ParentKeyColumn = "Medicine_ID";
            relationInfo1.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo1});
            relationInfo1.NestedTable = "Medicine";
            relationInfo1.ParentTable = "Medincine_Ingredient";
            relationColumnInfo2.NestedKeyColumn = "Ingredient_ID";
            relationColumnInfo2.ParentKeyColumn = "Ingredient_ID";
            relationInfo2.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo2});
            relationInfo2.NestedTable = "Ingredient";
            relationInfo2.ParentTable = "Medincine_Ingredient";
            tableQuery1.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo1,
            relationInfo2});
            tableInfo1.Name = "Medincine_Ingredient";
            columnInfo1.Name = "Medicine_ID";
            columnInfo2.Name = "Ingredient_ID";
            columnInfo3.Name = "Unit";
            columnInfo4.Name = "ContentUnit";
            tableInfo1.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo1,
            columnInfo2,
            columnInfo3,
            columnInfo4});
            tableInfo2.Name = "Medicine";
            tableInfo3.Name = "Ingredient";
            columnInfo5.Name = "Ingredient_Name";
            tableInfo3.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo5});
            tableQuery1.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo1,
            tableInfo2,
            tableInfo3});
            this.sqlDataSource5.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery1});
            this.sqlDataSource5.ResultSchemaSerializable = resources.GetString("sqlDataSource5.ResultSchemaSerializable");
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDanhMuc.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDanhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMedicine_ID,
            this.colIngredient_ID,
            this.colUnit,
            this.colContentUnit,
            this.colIngredient_Name});
            this.gvDanhMuc.GridControl = this.grcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDanhMuc.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colMedicine_ID
            // 
            this.colMedicine_ID.FieldName = "Medicine_ID";
            this.colMedicine_ID.Name = "colMedicine_ID";
            this.colMedicine_ID.Visible = true;
            this.colMedicine_ID.VisibleIndex = 0;
            this.colMedicine_ID.Width = 60;
            // 
            // colIngredient_ID
            // 
            this.colIngredient_ID.FieldName = "Ingredient_ID";
            this.colIngredient_ID.Name = "colIngredient_ID";
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 2;
            this.colUnit.Width = 87;
            // 
            // colContentUnit
            // 
            this.colContentUnit.FieldName = "ContentUnit";
            this.colContentUnit.Name = "colContentUnit";
            this.colContentUnit.Visible = true;
            this.colContentUnit.VisibleIndex = 3;
            this.colContentUnit.Width = 79;
            // 
            // colIngredient_Name
            // 
            this.colIngredient_Name.FieldName = "Ingredient_Name";
            this.colIngredient_Name.Name = "colIngredient_Name";
            this.colIngredient_Name.Visible = true;
            this.colIngredient_Name.VisibleIndex = 1;
            this.colIngredient_Name.Width = 161;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(19, 33);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(406, 20);
            this.txtTen.TabIndex = 32;
            // 
            // lkeDonVi
            // 
            this.lkeDonVi.Location = new System.Drawing.Point(280, 79);
            this.lkeDonVi.Name = "lkeDonVi";
            this.lkeDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeDonVi.Properties.DataSource = this.bindingSource3;
            this.lkeDonVi.Properties.DisplayMember = "Unit_Name";
            this.lkeDonVi.Properties.NullText = "Chọn đơn vị";
            this.lkeDonVi.Properties.ValueMember = "Unit_ID";
            this.lkeDonVi.Size = new System.Drawing.Size(145, 20);
            this.lkeDonVi.TabIndex = 30;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 13);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Tóm tắt thành phần:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(280, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Đơn vị:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Lớp thuốc:";
            // 
            // txtLopThuoc
            // 
            this.txtLopThuoc.Location = new System.Drawing.Point(20, 78);
            this.txtLopThuoc.Name = "txtLopThuoc";
            this.txtLopThuoc.Size = new System.Drawing.Size(244, 20);
            this.txtLopThuoc.TabIndex = 24;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(20, 14);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(52, 13);
            this.labelControl12.TabIndex = 21;
            this.labelControl12.Text = "Tên thuốc:";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.txtGia);
            this.xtraTabPage1.Controls.Add(this.txtMa);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.txtGhiChu);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.txtSuDung);
            this.xtraTabPage1.Controls.Add(this.labelControl9);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(453, 399);
            this.xtraTabPage1.Text = "Thông tin khác";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(245, 38);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(20, 13);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "VND";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(24, 35);
            this.txtGia.Name = "txtGia";
            this.txtGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtGia.Properties.NullValuePrompt = "0";
            this.txtGia.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtGia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGia.Size = new System.Drawing.Size(215, 20);
            this.txtGia.TabIndex = 32;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(279, 35);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(150, 20);
            this.txtMa.TabIndex = 30;
            this.txtMa.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 16);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Đơn giá:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(24, 230);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(405, 145);
            this.txtGhiChu.TabIndex = 27;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 211);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Ghi chú:";
            // 
            // txtSuDung
            // 
            this.txtSuDung.Location = new System.Drawing.Point(24, 80);
            this.txtSuDung.Name = "txtSuDung";
            this.txtSuDung.Size = new System.Drawing.Size(405, 125);
            this.txtSuDung.TabIndex = 25;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(24, 61);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(70, 13);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "Cách sử dụng:";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            tableQuery2.FilterString = "[Medincine_Ingredient.Medicine_ID] = ?ID";
            tableQuery2.Name = "Medincine_Ingredient";
            queryParameter1.Name = "ID";
            queryParameter1.Type = typeof(int);
            queryParameter1.ValueInfo = "0";
            tableQuery2.Parameters.Add(queryParameter1);
            relationColumnInfo3.NestedKeyColumn = "Ingredient_ID";
            relationColumnInfo3.ParentKeyColumn = "Ingredient_ID";
            relationInfo3.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo3});
            relationInfo3.NestedTable = "Ingredient";
            relationInfo3.ParentTable = "Medincine_Ingredient";
            tableQuery2.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo3});
            tableInfo4.Name = "Medincine_Ingredient";
            columnInfo6.Name = "Unit";
            columnInfo7.Name = "ContentUnit";
            tableInfo4.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo6,
            columnInfo7});
            tableInfo5.Name = "Ingredient";
            columnInfo8.Name = "Ingredient_Name";
            tableInfo5.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo8});
            tableQuery2.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo4,
            tableInfo5});
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            tableQuery3.Name = "Medincine_Ingredient";
            tableInfo6.Name = "Medincine_Ingredient";
            columnInfo9.Name = "Medicine_ID";
            columnInfo10.Name = "Ingredient_ID";
            columnInfo11.Name = "Unit";
            columnInfo12.Name = "ContentUnit";
            tableInfo6.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo9,
            columnInfo10,
            columnInfo11,
            columnInfo12});
            tableQuery3.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo6});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(409, 16);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 25);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(328, 16);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 25);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 452);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(503, 53);
            this.panelControl1.TabIndex = 8;
            // 
            // MedicineDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 505);
            this.Controls.Add(this.xtraTabContarol1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicineDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục thuốc";
            this.Load += new System.EventHandler(this.MedicineDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).EndInit();
            this.xtraTabContarol1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLopThuoc.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabContarol1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtLopThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txtSuDung;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LookUpEdit lkeDonVi;
        private System.Windows.Forms.BindingSource bindingSource3;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraGrid.GridControl grcDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource5;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicine_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colIngredient_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colContentUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colIngredient_Name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem csmThem;
        private System.Windows.Forms.ToolStripMenuItem csmCapNhat;
        private System.Windows.Forms.ToolStripMenuItem csmXoa;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
    }
}