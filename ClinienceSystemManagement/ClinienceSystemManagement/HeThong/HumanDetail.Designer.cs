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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery5 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HumanDetail));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery6 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
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
            this.lbTrangThai = new DevExpress.XtraEditors.LabelControl();
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
            columnExpression9.ColumnName = "Paraclinical_Group_ID";
            table5.Name = "Paraclinical_Group";
            columnExpression9.Table = table5;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "Paraclinical_Group_Name";
            columnExpression10.Table = table5;
            column10.Expression = columnExpression10;
            selectQuery5.Columns.Add(column9);
            selectQuery5.Columns.Add(column10);
            selectQuery5.Name = "Paraclinical_Group";
            selectQuery5.Tables.Add(table5);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery5});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xtraTabContarol1
            // 
            resources.ApplyResources(this.xtraTabContarol1, "xtraTabContarol1");
            this.xtraTabContarol1.Name = "xtraTabContarol1";
            this.xtraTabContarol1.SelectedTabPage = this.xtraTabPage1;
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
            resources.ApplyResources(this.xtraTabPage1, "xtraTabPage1");
            // 
            // txtKiTe
            // 
            resources.ApplyResources(this.txtKiTe, "txtKiTe");
            this.txtKiTe.Name = "txtKiTe";
            this.txtKiTe.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtKiTe.Properties.Appearance.Font")));
            this.txtKiTe.Properties.Appearance.Options.UseFont = true;
            // 
            // cbxHienMatKhau
            // 
            resources.ApplyResources(this.cbxHienMatKhau, "cbxHienMatKhau");
            this.cbxHienMatKhau.Name = "cbxHienMatKhau";
            this.cbxHienMatKhau.Properties.Caption = resources.GetString("cbxHienMatKhau.Properties.Caption");
            this.cbxHienMatKhau.CheckedChanged += new System.EventHandler(this.cbxHienMatKhau_CheckedChanged);
            // 
            // lkePhanQuyen
            // 
            resources.ApplyResources(this.lkePhanQuyen, "lkePhanQuyen");
            this.lkePhanQuyen.Name = "lkePhanQuyen";
            this.lkePhanQuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lkePhanQuyen.Properties.Buttons"))))});
            this.lkePhanQuyen.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lkePhanQuyen.Properties.Columns"), resources.GetString("lkePhanQuyen.Properties.Columns1"), ((int)(resources.GetObject("lkePhanQuyen.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("lkePhanQuyen.Properties.Columns3"))), resources.GetString("lkePhanQuyen.Properties.Columns4"), ((bool)(resources.GetObject("lkePhanQuyen.Properties.Columns5"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("lkePhanQuyen.Properties.Columns6")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lkePhanQuyen.Properties.Columns7"), resources.GetString("lkePhanQuyen.Properties.Columns8"), ((int)(resources.GetObject("lkePhanQuyen.Properties.Columns9"))), ((DevExpress.Utils.FormatType)(resources.GetObject("lkePhanQuyen.Properties.Columns10"))), resources.GetString("lkePhanQuyen.Properties.Columns11"), ((bool)(resources.GetObject("lkePhanQuyen.Properties.Columns12"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("lkePhanQuyen.Properties.Columns13"))))});
            this.lkePhanQuyen.Properties.DataSource = this.bindingSource2;
            this.lkePhanQuyen.Properties.DisplayMember = "Account_Type_Authority";
            this.lkePhanQuyen.Properties.NullText = resources.GetString("lkePhanQuyen.Properties.NullText");
            this.lkePhanQuyen.Properties.ValueMember = "Account_Type_ID";
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
            columnExpression11.ColumnName = "Account_Type_ID";
            table6.Name = "Account_Type";
            columnExpression11.Table = table6;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "Account_Type_Authority";
            columnExpression12.Table = table6;
            column12.Expression = columnExpression12;
            selectQuery6.Columns.Add(column11);
            selectQuery6.Columns.Add(column12);
            selectQuery6.Name = "Account_Type";
            selectQuery6.Tables.Add(table6);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery6});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // txtAnh
            // 
            resources.ApplyResources(this.txtAnh, "txtAnh");
            this.txtAnh.Name = "txtAnh";
            // 
            // peAnh
            // 
            resources.ApplyResources(this.peAnh, "peAnh");
            this.peAnh.Name = "peAnh";
            this.peAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAnh.Properties.ZoomAccelerationFactor = 1D;
            this.peAnh.Click += new System.EventHandler(this.peAnh_Click);
            // 
            // labelControl8
            // 
            resources.ApplyResources(this.labelControl8, "labelControl8");
            this.labelControl8.Name = "labelControl8";
            // 
            // txtMa
            // 
            resources.ApplyResources(this.txtMa, "txtMa");
            this.txtMa.Name = "txtMa";
            // 
            // labelControl7
            // 
            resources.ApplyResources(this.labelControl7, "labelControl7");
            this.labelControl7.Name = "labelControl7";
            // 
            // txtMatKhau2
            // 
            resources.ApplyResources(this.txtMatKhau2, "txtMatKhau2");
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.Properties.UseSystemPasswordChar = true;
            // 
            // labelControl6
            // 
            resources.ApplyResources(this.labelControl6, "labelControl6");
            this.labelControl6.Name = "labelControl6";
            // 
            // txtMatKhau
            // 
            resources.ApplyResources(this.txtMatKhau, "txtMatKhau");
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            this.txtMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhau_Validating);
            // 
            // labelControl5
            // 
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Name = "labelControl5";
            // 
            // labelControl4
            // 
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            // 
            // txtTenDangNhap
            // 
            resources.ApplyResources(this.txtTenDangNhap, "txtTenDangNhap");
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDangNhap_KeyPress);
            this.txtTenDangNhap.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenDangNhap_Validating);
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // txtTen
            // 
            resources.ApplyResources(this.txtTen, "txtTen");
            this.txtTen.Name = "txtTen";
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            resources.ApplyResources(this.btnHuy, "btnHuy");
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTao
            // 
            this.btnTao.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTao.Image = ((System.Drawing.Image)(resources.GetObject("btnTao.Image")));
            resources.ApplyResources(this.btnTao, "btnTao");
            this.btnTao.Name = "btnTao";
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbTrangThai);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnTao);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbTrangThai.Appearance.Font")));
            this.lbTrangThai.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("lbTrangThai.Appearance.ForeColor")));
            this.lbTrangThai.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lbTrangThai.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            resources.ApplyResources(this.lbTrangThai, "lbTrangThai");
            this.lbTrangThai.Name = "lbTrangThai";
            // 
            // HumanDetail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabContarol1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HumanDetail";
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
            this.panelControl1.PerformLayout();
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
        private DevExpress.XtraEditors.LabelControl lbTrangThai;
    }
}