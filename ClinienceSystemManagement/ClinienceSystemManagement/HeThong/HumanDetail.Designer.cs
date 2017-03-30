namespace ClinienceSystemManagement.HeThong
{
    partial class HumanDetail
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
            DevExpress.DataAccess.Sql.TableQuery tableQuery5 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo5 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo9 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo10 = new DevExpress.DataAccess.Sql.ColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HumanDetail));
            DevExpress.DataAccess.Sql.TableQuery tableQuery6 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo6 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo11 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo12 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xtraTabContarol1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtKiTe = new DevExpress.XtraEditors.MemoEdit();
            this.cbxHienMatKhau = new DevExpress.XtraEditors.CheckEdit();
            this.lkePhanQuyen = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.txtAnh = new DevExpress.XtraEditors.TextEdit();
            this.peAnh = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhau2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnTao = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).BeginInit();
            this.xtraTabContarol1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKiTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxHienMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkePhanQuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Paraclinical_Group";
            this.bindingSource1.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            tableQuery5.Name = "Paraclinical_Group";
            tableInfo5.Name = "Paraclinical_Group";
            columnInfo9.Name = "Paraclinical_Group_ID";
            columnInfo10.Name = "Paraclinical_Group_Name";
            tableInfo5.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo9,
            columnInfo10});
            tableQuery5.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo5});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery5});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xtraTabContarol1
            // 
            this.xtraTabContarol1.Location = new System.Drawing.Point(26, 14);
            this.xtraTabContarol1.Name = "xtraTabContarol1";
            this.xtraTabContarol1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabContarol1.Size = new System.Drawing.Size(478, 314);
            this.xtraTabContarol1.TabIndex = 7;
            this.xtraTabContarol1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtKiTe);
            this.xtraTabPage1.Controls.Add(this.cbxHienMatKhau);
            this.xtraTabPage1.Controls.Add(this.lkePhanQuyen);
            this.xtraTabPage1.Controls.Add(this.txtAnh);
            this.xtraTabPage1.Controls.Add(this.peAnh);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.txtMa);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.txtMatKhau2);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.txtMatKhau);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.txtTenDangNhap);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtTen);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(472, 286);
            this.xtraTabPage1.Text = "Thông tin người dùng";
            // 
            // txtKiTe
            // 
            this.txtKiTe.Location = new System.Drawing.Point(28, 206);
            this.txtKiTe.Name = "txtKiTe";
            this.txtKiTe.Properties.Appearance.Font = new System.Drawing.Font("Twilight New Moon", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKiTe.Properties.Appearance.Options.UseFont = true;
            this.txtKiTe.Size = new System.Drawing.Size(140, 64);
            this.txtKiTe.TabIndex = 37;
            // 
            // cbxHienMatKhau
            // 
            this.cbxHienMatKhau.Location = new System.Drawing.Point(362, 205);
            this.cbxHienMatKhau.Name = "cbxHienMatKhau";
            this.cbxHienMatKhau.Properties.Caption = "Hiện mật khẩu";
            this.cbxHienMatKhau.Size = new System.Drawing.Size(91, 19);
            this.cbxHienMatKhau.TabIndex = 36;
            this.cbxHienMatKhau.CheckedChanged += new System.EventHandler(this.cbxHienMatKhau_CheckedChanged);
            // 
            // lkePhanQuyen
            // 
            this.lkePhanQuyen.Location = new System.Drawing.Point(183, 164);
            this.lkePhanQuyen.Name = "lkePhanQuyen";
            this.lkePhanQuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkePhanQuyen.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Type_ID", "Account_Type_ID", 109, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Type_Authority", "Phân quyền", 130, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkePhanQuyen.Properties.DataSource = this.bindingSource2;
            this.lkePhanQuyen.Properties.DisplayMember = "Account_Type_Authority";
            this.lkePhanQuyen.Properties.NullText = "Chọn quyền hạn";
            this.lkePhanQuyen.Properties.ValueMember = "Account_Type_ID";
            this.lkePhanQuyen.Size = new System.Drawing.Size(110, 20);
            this.lkePhanQuyen.TabIndex = 34;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Account_Type";
            this.bindingSource2.DataSource = this.sqlDataSource2;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            tableQuery6.Name = "Account_Type";
            tableInfo6.Name = "Account_Type";
            columnInfo11.Name = "Account_Type_ID";
            columnInfo12.Name = "Account_Type_Authority";
            tableInfo6.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo11,
            columnInfo12});
            tableQuery6.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo6});
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery6});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(362, 205);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(100, 20);
            this.txtAnh.TabIndex = 32;
            this.txtAnh.Visible = false;
            // 
            // peAnh
            // 
            this.peAnh.EditValue = ((object)(resources.GetObject("peAnh.EditValue")));
            this.peAnh.Location = new System.Drawing.Point(28, 35);
            this.peAnh.Name = "peAnh";
            this.peAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAnh.Size = new System.Drawing.Size(140, 140);
            this.peAnh.TabIndex = 30;
            this.peAnh.Click += new System.EventHandler(this.peAnh_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(183, 16);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(18, 13);
            this.labelControl8.TabIndex = 29;
            this.labelControl8.Text = "Mã:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(183, 33);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(110, 20);
            this.txtMa.TabIndex = 28;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(183, 231);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(89, 13);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "Nhập lại mật khẩu:";
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.Location = new System.Drawing.Point(183, 250);
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau2.Size = new System.Drawing.Size(173, 20);
            this.txtMatKhau2.TabIndex = 24;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(183, 186);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 13);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(183, 205);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau.Size = new System.Drawing.Size(173, 20);
            this.txtMatKhau.TabIndex = 22;
            this.txtMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhau_Validating);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(183, 145);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 13);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Phân quyền:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(183, 100);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(183, 119);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(256, 20);
            this.txtTenDangNhap.TabIndex = 16;
            this.txtTenDangNhap.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenDangNhap_Validating);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 186);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Chữ ký:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Ảnh (140*140):";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(183, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Họ và tên:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(183, 74);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(256, 20);
            this.txtTen.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(429, 16);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 25);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTao
            // 
            this.btnTao.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTao.Image = ((System.Drawing.Image)(resources.GetObject("btnTao.Image")));
            this.btnTao.Location = new System.Drawing.Point(348, 16);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 25);
            this.btnTao.TabIndex = 0;
            this.btnTao.Text = "Lưu";
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnTao);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 340);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(525, 53);
            this.panelControl1.TabIndex = 6;
            // 
            // HumanDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 393);
            this.Controls.Add(this.xtraTabContarol1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HumanDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục người dùng";
            this.Load += new System.EventHandler(this.HumanDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).EndInit();
            this.xtraTabContarol1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKiTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxHienMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkePhanQuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraTab.XtraTabControl xtraTabContarol1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtMatKhau2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnTao;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.PictureEdit peAnh;
        private DevExpress.XtraEditors.TextEdit txtAnh;
        private DevExpress.XtraEditors.LookUpEdit lkePhanQuyen;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.CheckEdit cbxHienMatKhau;
        private DevExpress.XtraEditors.MemoEdit txtKiTe;
    }
}