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
            DevExpress.DataAccess.Sql.TableQuery tableQuery11 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo17 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo35 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo36 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo37 = new DevExpress.DataAccess.Sql.ColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineDetail));
            DevExpress.DataAccess.Sql.TableQuery tableQuery12 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo18 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo38 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo39 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery13 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo7 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo7 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo8 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo8 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo19 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo40 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo41 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo42 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo43 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo20 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo21 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo44 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery14 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo9 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo9 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo22 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo45 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo46 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo23 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo47 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery15 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo24 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo48 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo49 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo50 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo51 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.xtraTabContarol1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.grcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csmThem = new System.Windows.Forms.ToolStripMenuItem();
            this.csmCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.csmXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlDataSource4 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIngredient_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngredient_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngredient_Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkChon = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.lkeDonVi = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
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
            this.sqlDataSource5 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).BeginInit();
            this.xtraTabContarol1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLopThuoc.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
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
            this.xtraTabPage2.Controls.Add(this.checkEdit1);
            this.xtraTabPage2.Controls.Add(this.grcDanhMuc);
            this.xtraTabPage2.Controls.Add(this.lkeDonVi);
            this.xtraTabPage2.Controls.Add(this.txtTen);
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Controls.Add(this.txtLopThuoc);
            this.xtraTabPage2.Controls.Add(this.labelControl12);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(453, 399);
            this.xtraTabPage2.Text = "Chi tiết thuốc";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(302, 100);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "checkEdit1";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 36;
            // 
            // grcDanhMuc
            // 
            this.grcDanhMuc.ContextMenuStrip = this.contextMenuStrip1;
            this.grcDanhMuc.DataMember = "Ingredient";
            this.grcDanhMuc.DataSource = this.sqlDataSource4;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.TextStringFormat = "Trang {0} / {1}";
            this.grcDanhMuc.Location = new System.Drawing.Point(20, 125);
            this.grcDanhMuc.MainView = this.gvDanhMuc;
            this.grcDanhMuc.Name = "grcDanhMuc";
            this.grcDanhMuc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkChon});
            this.grcDanhMuc.Size = new System.Drawing.Size(405, 255);
            this.grcDanhMuc.TabIndex = 35;
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
            // sqlDataSource4
            // 
            this.sqlDataSource4.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource4.Name = "sqlDataSource4";
            tableQuery11.Name = "Ingredient";
            tableInfo17.Name = "Ingredient";
            columnInfo35.Name = "Ingredient_ID";
            columnInfo36.Name = "Ingredient_Name";
            columnInfo37.Name = "Ingredient_Note";
            tableInfo17.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo35,
            columnInfo36,
            columnInfo37});
            tableQuery11.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo17});
            this.sqlDataSource4.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery11});
            this.sqlDataSource4.ResultSchemaSerializable = resources.GetString("sqlDataSource4.ResultSchemaSerializable");
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDanhMuc.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDanhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIngredient_ID,
            this.colIngredient_Name,
            this.colIngredient_Note});
            this.gvDanhMuc.GridControl = this.grcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.OptionsFind.AlwaysVisible = true;
            this.gvDanhMuc.OptionsFind.FindNullPrompt = "Nhập vào thông tin cần tìm kiếm...";
            this.gvDanhMuc.OptionsSelection.MultiSelect = true;
            this.gvDanhMuc.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMuc.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gvDanhMuc.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDanhMuc.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvDanhMuc_SelectionChanged);
            // 
            // colIngredient_ID
            // 
            this.colIngredient_ID.Caption = "Mã";
            this.colIngredient_ID.FieldName = "Ingredient_ID";
            this.colIngredient_ID.Name = "colIngredient_ID";
            this.colIngredient_ID.Visible = true;
            this.colIngredient_ID.VisibleIndex = 1;
            this.colIngredient_ID.Width = 46;
            // 
            // colIngredient_Name
            // 
            this.colIngredient_Name.Caption = "Tên thành phần";
            this.colIngredient_Name.FieldName = "Ingredient_Name";
            this.colIngredient_Name.Name = "colIngredient_Name";
            this.colIngredient_Name.Visible = true;
            this.colIngredient_Name.VisibleIndex = 2;
            this.colIngredient_Name.Width = 143;
            // 
            // colIngredient_Note
            // 
            this.colIngredient_Note.Caption = "Ghi chú";
            this.colIngredient_Note.FieldName = "Ingredient_Note";
            this.colIngredient_Note.Name = "colIngredient_Note";
            this.colIngredient_Note.Width = 104;
            // 
            // checkChon
            // 
            this.checkChon.AutoHeight = false;
            this.checkChon.Name = "checkChon";
            this.checkChon.CheckedChanged += new System.EventHandler(this.checkChon_CheckedChanged);
            // 
            // lkeDonVi
            // 
            this.lkeDonVi.Location = new System.Drawing.Point(280, 78);
            this.lkeDonVi.Name = "lkeDonVi";
            this.lkeDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeDonVi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Unit_ID", "Unit_ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Unit_Name", "Chọn đơn vị", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkeDonVi.Properties.DataSource = this.bindingSource4;
            this.lkeDonVi.Properties.DisplayMember = "Unit_Name";
            this.lkeDonVi.Properties.NullText = "Chọn đơn vị";
            this.lkeDonVi.Properties.ValueMember = "Unit_ID";
            this.lkeDonVi.Size = new System.Drawing.Size(145, 20);
            this.lkeDonVi.TabIndex = 34;
            // 
            // bindingSource4
            // 
            this.bindingSource4.DataMember = "Medicine_Unit";
            this.bindingSource4.DataSource = this.sqlDataSource3;
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource3.Name = "sqlDataSource3";
            tableQuery12.Name = "Medicine_Unit";
            tableInfo18.Name = "Medicine_Unit";
            columnInfo38.Name = "Unit_ID";
            columnInfo39.Name = "Unit_Name";
            tableInfo18.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo38,
            columnInfo39});
            tableQuery12.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo18});
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery12});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(19, 33);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(406, 20);
            this.txtTen.TabIndex = 32;
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
            // sqlDataSource5
            // 
            this.sqlDataSource5.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource5.Name = "sqlDataSource5";
            tableQuery13.Name = "Medincine_Ingredient";
            relationColumnInfo7.NestedKeyColumn = "Medicine_ID";
            relationColumnInfo7.ParentKeyColumn = "Medicine_ID";
            relationInfo7.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo7});
            relationInfo7.NestedTable = "Medicine";
            relationInfo7.ParentTable = "Medincine_Ingredient";
            relationColumnInfo8.NestedKeyColumn = "Ingredient_ID";
            relationColumnInfo8.ParentKeyColumn = "Ingredient_ID";
            relationInfo8.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo8});
            relationInfo8.NestedTable = "Ingredient";
            relationInfo8.ParentTable = "Medincine_Ingredient";
            tableQuery13.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo7,
            relationInfo8});
            tableInfo19.Name = "Medincine_Ingredient";
            columnInfo40.Name = "Medicine_ID";
            columnInfo41.Name = "Ingredient_ID";
            columnInfo42.Name = "Unit";
            columnInfo43.Name = "ContentUnit";
            tableInfo19.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo40,
            columnInfo41,
            columnInfo42,
            columnInfo43});
            tableInfo20.Name = "Medicine";
            tableInfo21.Name = "Ingredient";
            columnInfo44.Name = "Ingredient_Name";
            tableInfo21.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo44});
            tableQuery13.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo19,
            tableInfo20,
            tableInfo21});
            this.sqlDataSource5.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery13});
            this.sqlDataSource5.ResultSchemaSerializable = resources.GetString("sqlDataSource5.ResultSchemaSerializable");
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            tableQuery14.FilterString = "[Medincine_Ingredient.Medicine_ID] = ?ID";
            tableQuery14.Name = "Medincine_Ingredient";
            queryParameter3.Name = "ID";
            queryParameter3.Type = typeof(int);
            queryParameter3.ValueInfo = "0";
            tableQuery14.Parameters.Add(queryParameter3);
            relationColumnInfo9.NestedKeyColumn = "Ingredient_ID";
            relationColumnInfo9.ParentKeyColumn = "Ingredient_ID";
            relationInfo9.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo9});
            relationInfo9.NestedTable = "Ingredient";
            relationInfo9.ParentTable = "Medincine_Ingredient";
            tableQuery14.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo9});
            tableInfo22.Name = "Medincine_Ingredient";
            columnInfo45.Name = "Unit";
            columnInfo46.Name = "ContentUnit";
            tableInfo22.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo45,
            columnInfo46});
            tableInfo23.Name = "Ingredient";
            columnInfo47.Name = "Ingredient_Name";
            tableInfo23.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo47});
            tableQuery14.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo22,
            tableInfo23});
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery14});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            tableQuery15.Name = "Medincine_Ingredient";
            tableInfo24.Name = "Medincine_Ingredient";
            columnInfo48.Name = "Medicine_ID";
            columnInfo49.Name = "Ingredient_ID";
            columnInfo50.Name = "Unit";
            columnInfo51.Name = "ContentUnit";
            tableInfo24.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo48,
            columnInfo49,
            columnInfo50,
            columnInfo51});
            tableQuery15.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo24});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery15});
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
            this.panelControl1.Controls.Add(this.lbTrangThai);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 452);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(503, 53);
            this.panelControl1.TabIndex = 8;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbTrangThai.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbTrangThai.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lbTrangThai.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.lbTrangThai.Location = new System.Drawing.Point(30, 20);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(0, 15);
            this.lbTrangThai.TabIndex = 36;
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
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLopThuoc.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
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
        private System.Windows.Forms.BindingSource bindingSource3;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem csmThem;
        private System.Windows.Forms.ToolStripMenuItem csmCapNhat;
        private System.Windows.Forms.ToolStripMenuItem csmXoa;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.LabelControl lbTrangThai;
        private DevExpress.XtraEditors.LookUpEdit lkeDonVi;
        private System.Windows.Forms.BindingSource bindingSource4;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.XtraGrid.GridControl grcDanhMuc;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource4;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colIngredient_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colIngredient_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colIngredient_Note;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkChon;
    }
}