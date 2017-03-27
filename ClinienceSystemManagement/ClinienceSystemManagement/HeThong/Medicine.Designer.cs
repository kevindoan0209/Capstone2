namespace ClinienceSystemManagement.Hệ_Thống
{
    partial class DanhMucThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMucThuoc));
            DevExpress.DataAccess.Sql.TableQuery tableQuery7 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo7 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo7 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo13 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo34 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo35 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo36 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo37 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo14 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo38 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery8 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo8 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo8 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo15 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo39 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo40 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo41 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo42 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo43 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo16 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo44 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sqlDataSource5 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMedicine_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicine_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicine_Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicine_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicine_Class = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCapNhat,
            this.cmsXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // cmsCapNhat
            // 
            this.cmsCapNhat.BackColor = System.Drawing.SystemColors.Control;
            this.cmsCapNhat.Name = "cmsCapNhat";
            this.cmsCapNhat.Size = new System.Drawing.Size(122, 22);
            this.cmsCapNhat.Text = "Cập nhật";
            this.cmsCapNhat.Click += new System.EventHandler(this.cmsCapNhat_Click);
            // 
            // cmsXoa
            // 
            this.cmsXoa.BackColor = System.Drawing.SystemColors.Control;
            this.cmsXoa.Name = "cmsXoa";
            this.cmsXoa.Size = new System.Drawing.Size(122, 22);
            this.cmsXoa.Text = "Xóa";
            this.cmsXoa.Click += new System.EventHandler(this.cmsXoa_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl2.Controls.Add(this.txtTimKiem);
            this.panelControl2.Controls.Add(this.btnTimKiem);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(764, 61);
            this.panelControl2.TabIndex = 7;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiem.EditValue = "";
            this.txtTimKiem.Location = new System.Drawing.Point(191, 20);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.AccessibleDescription = "";
            this.txtTimKiem.Properties.NullValuePrompt = "Nhập vào tên bệnh...";
            this.txtTimKiem.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTimKiem.Size = new System.Drawing.Size(341, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(549, 19);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 22);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm ";
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(16, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 28);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm thuốc";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(154, 9);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 28);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnLamMoi);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 367);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(764, 44);
            this.panelControl1.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(391, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(351, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "* Nhấn chuột phải trên danh sách để xóa hoặc cập nhật dữ liệu";
            // 
            // sqlDataSource5
            // 
            this.sqlDataSource5.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource5.Name = "sqlDataSource5";
            tableQuery7.Name = "Medicine";
            relationColumnInfo7.NestedKeyColumn = "Unit_ID";
            relationColumnInfo7.ParentKeyColumn = "Unit_ID";
            relationInfo7.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo7});
            relationInfo7.NestedTable = "Medicine_Unit";
            relationInfo7.ParentTable = "Medicine";
            tableQuery7.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo7});
            tableInfo13.Name = "Medicine";
            columnInfo34.Name = "Medicine_Name";
            columnInfo35.Name = "Medicine_Class";
            columnInfo36.Name = "Medicine_Note";
            columnInfo37.Name = "Medicine_Price";
            tableInfo13.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo34,
            columnInfo35,
            columnInfo36,
            columnInfo37});
            tableInfo14.Name = "Medicine_Unit";
            columnInfo38.Name = "Unit_Name";
            tableInfo14.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo38});
            tableQuery7.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo13,
            tableInfo14});
            this.sqlDataSource5.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery7});
            this.sqlDataSource5.ResultSchemaSerializable = resources.GetString("sqlDataSource5.ResultSchemaSerializable");
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            tableQuery8.Name = "Medicine";
            relationColumnInfo8.NestedKeyColumn = "Unit_ID";
            relationColumnInfo8.ParentKeyColumn = "Unit_ID";
            relationInfo8.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo8});
            relationInfo8.NestedTable = "Medicine_Unit";
            relationInfo8.ParentTable = "Medicine";
            tableQuery8.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo8});
            tableInfo15.Name = "Medicine";
            columnInfo39.Name = "Medicine_ID";
            columnInfo40.Name = "Medicine_Name";
            columnInfo41.Name = "Medicine_Note";
            columnInfo42.Name = "Medicine_Price";
            columnInfo43.Name = "Medicine_Class";
            tableInfo15.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo39,
            columnInfo40,
            columnInfo41,
            columnInfo42,
            columnInfo43});
            tableInfo16.Name = "Medicine_Unit";
            columnInfo44.Name = "Unit_Name";
            tableInfo16.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo44});
            tableQuery8.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo15,
            tableInfo16});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery8});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDanhMuc.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDanhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMedicine_ID,
            this.colMedicine_Name,
            this.colMedicine_Note,
            this.colMedicine_Price,
            this.colMedicine_Class,
            this.colUnit_Name});
            this.gvDanhMuc.GridControl = this.grcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.OptionsFind.AlwaysVisible = true;
            this.gvDanhMuc.OptionsFind.FindNullPrompt = "Nhập vào thông tin tìm kiếm...";
            this.gvDanhMuc.OptionsView.EnableAppearanceEvenRow = true;
            // 
            // colMedicine_ID
            // 
            this.colMedicine_ID.Caption = "Mã thuốc";
            this.colMedicine_ID.FieldName = "Medicine_ID";
            this.colMedicine_ID.Name = "colMedicine_ID";
            // 
            // colMedicine_Name
            // 
            this.colMedicine_Name.Caption = "Tên thuốc";
            this.colMedicine_Name.FieldName = "Medicine_Name";
            this.colMedicine_Name.Name = "colMedicine_Name";
            this.colMedicine_Name.Visible = true;
            this.colMedicine_Name.VisibleIndex = 0;
            this.colMedicine_Name.Width = 235;
            // 
            // colMedicine_Note
            // 
            this.colMedicine_Note.Caption = "Ghi chú";
            this.colMedicine_Note.FieldName = "Medicine_Note";
            this.colMedicine_Note.Name = "colMedicine_Note";
            this.colMedicine_Note.Visible = true;
            this.colMedicine_Note.VisibleIndex = 3;
            this.colMedicine_Note.Width = 104;
            // 
            // colMedicine_Price
            // 
            this.colMedicine_Price.Caption = "Đơn giá";
            this.colMedicine_Price.FieldName = "Medicine_Price";
            this.colMedicine_Price.Name = "colMedicine_Price";
            this.colMedicine_Price.Visible = true;
            this.colMedicine_Price.VisibleIndex = 4;
            this.colMedicine_Price.Width = 111;
            // 
            // colMedicine_Class
            // 
            this.colMedicine_Class.Caption = "Lớp thuốc";
            this.colMedicine_Class.FieldName = "Medicine_Class";
            this.colMedicine_Class.Name = "colMedicine_Class";
            this.colMedicine_Class.Visible = true;
            this.colMedicine_Class.VisibleIndex = 1;
            this.colMedicine_Class.Width = 192;
            // 
            // colUnit_Name
            // 
            this.colUnit_Name.Caption = "Đơn vị";
            this.colUnit_Name.FieldName = "Unit_Name";
            this.colUnit_Name.Name = "colUnit_Name";
            this.colUnit_Name.Visible = true;
            this.colUnit_Name.VisibleIndex = 2;
            this.colUnit_Name.Width = 104;
            // 
            // grcDanhMuc
            // 
            this.grcDanhMuc.ContextMenuStrip = this.contextMenuStrip1;
            this.grcDanhMuc.DataMember = "Medicine";
            this.grcDanhMuc.DataSource = this.sqlDataSource1;
            this.grcDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.TextStringFormat = "Trang {0} / {1}";
            this.grcDanhMuc.Location = new System.Drawing.Point(0, 61);
            this.grcDanhMuc.MainView = this.gvDanhMuc;
            this.grcDanhMuc.Name = "grcDanhMuc";
            this.grcDanhMuc.Size = new System.Drawing.Size(764, 306);
            this.grcDanhMuc.TabIndex = 9;
            this.grcDanhMuc.UseEmbeddedNavigator = true;
            this.grcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            // 
            // DanhMucThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 411);
            this.Controls.Add(this.grcDanhMuc);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhMucThuoc";
            this.Text = "Danh mục thuốc";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsCapNhat;
        private System.Windows.Forms.ToolStripMenuItem cmsXoa;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource5;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicine_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicine_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicine_Note;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicine_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicine_Class;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_Name;
        private DevExpress.XtraGrid.GridControl grcDanhMuc;
    }
}