namespace ClinienceSystemManagement.KhamBenh
{
    partial class Patient
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
            System.Windows.Forms.GroupBox groupBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression21 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression22 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lbCongViec = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbTuoi = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbThanhPho = new DevExpress.XtraEditors.LabelControl();
            this.lbEmail = new DevExpress.XtraEditors.LabelControl();
            this.lbSoDienThoai = new DevExpress.XtraEditors.LabelControl();
            this.lbDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.lbGioiTinh = new DevExpress.XtraEditors.LabelControl();
            this.lbTen = new DevExpress.XtraEditors.LabelControl();
            this.peAnh = new DevExpress.XtraEditors.PictureEdit();
            this.btnTiepNhan = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchControl2 = new DevExpress.XtraEditors.SearchControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnXuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.grcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccount_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Image = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Type_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Sex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Job = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_City = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.pictureBox8);
            groupBox2.Controls.Add(this.lbCongViec);
            groupBox2.Controls.Add(this.pictureBox7);
            groupBox2.Controls.Add(this.lbTuoi);
            groupBox2.Controls.Add(this.pictureBox6);
            groupBox2.Controls.Add(this.pictureBox5);
            groupBox2.Controls.Add(this.pictureBox4);
            groupBox2.Controls.Add(this.pictureBox3);
            groupBox2.Controls.Add(this.pictureBox2);
            groupBox2.Controls.Add(this.pictureBox1);
            groupBox2.Controls.Add(this.lbThanhPho);
            groupBox2.Controls.Add(this.lbEmail);
            groupBox2.Controls.Add(this.lbSoDienThoai);
            groupBox2.Controls.Add(this.lbDiaChi);
            groupBox2.Controls.Add(this.lbGioiTinh);
            groupBox2.Controls.Add(this.lbTen);
            groupBox2.Controls.Add(this.peAnh);
            groupBox2.Location = new System.Drawing.Point(14, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(271, 415);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hồ sơ";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(17, 246);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(17, 17);
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            // 
            // lbCongViec
            // 
            this.lbCongViec.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCongViec.Location = new System.Drawing.Point(40, 245);
            this.lbCongViec.Name = "lbCongViec";
            this.lbCongViec.Size = new System.Drawing.Size(0, 18);
            this.lbCongViec.TabIndex = 18;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(17, 212);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(17, 17);
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // lbTuoi
            // 
            this.lbTuoi.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuoi.Location = new System.Drawing.Point(40, 211);
            this.lbTuoi.Name = "lbTuoi";
            this.lbTuoi.Size = new System.Drawing.Size(0, 18);
            this.lbTuoi.TabIndex = 16;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(17, 385);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(17, 17);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(18, 315);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(17, 17);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(17, 177);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 17);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 349);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 17);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 281);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbThanhPho
            // 
            this.lbThanhPho.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhPho.Location = new System.Drawing.Point(43, 385);
            this.lbThanhPho.Name = "lbThanhPho";
            this.lbThanhPho.Size = new System.Drawing.Size(0, 18);
            this.lbThanhPho.TabIndex = 9;
            // 
            // lbEmail
            // 
            this.lbEmail.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(43, 314);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(0, 18);
            this.lbEmail.TabIndex = 8;
            // 
            // lbSoDienThoai
            // 
            this.lbSoDienThoai.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDienThoai.Location = new System.Drawing.Point(42, 279);
            this.lbSoDienThoai.Name = "lbSoDienThoai";
            this.lbSoDienThoai.Size = new System.Drawing.Size(0, 18);
            this.lbSoDienThoai.TabIndex = 7;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(43, 348);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(0, 18);
            this.lbDiaChi.TabIndex = 6;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(40, 175);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(0, 18);
            this.lbGioiTinh.TabIndex = 5;
            // 
            // lbTen
            // 
            this.lbTen.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(41, 142);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(0, 18);
            this.lbTen.TabIndex = 4;
            // 
            // peAnh
            // 
            this.peAnh.EditValue = ((object)(resources.GetObject("peAnh.EditValue")));
            this.peAnh.Location = new System.Drawing.Point(13, 23);
            this.peAnh.Name = "peAnh";
            this.peAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAnh.Properties.ZoomAccelerationFactor = 1D;
            this.peAnh.Size = new System.Drawing.Size(110, 110);
            this.peAnh.TabIndex = 3;
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTiepNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnTiepNhan.Image")));
            this.btnTiepNhan.Location = new System.Drawing.Point(6, 11);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(146, 28);
            this.btnTiepNhan.TabIndex = 3;
            this.btnTiepNhan.Text = "Tiếp nhận bệnh nhân";
            this.btnTiepNhan.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(groupBox2);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(299, 506);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.searchControl2);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 50);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // searchControl2
            // 
            this.searchControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchControl2.Location = new System.Drawing.Point(20, 18);
            this.searchControl2.Name = "searchControl2";
            this.searchControl2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.searchControl2.Properties.Appearance.Options.UseFont = true;
            this.searchControl2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl2.Properties.NullValuePrompt = "Nhập vào thông tin tìm kiếm...";
            this.searchControl2.Size = new System.Drawing.Size(235, 24);
            this.searchControl2.TabIndex = 5;
            this.searchControl2.ToolTip = "Nhập vào thông tin tìm kiếm";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnTiepNhan);
            this.panelControl2.Controls.Add(this.btnXuatFile);
            this.panelControl2.Controls.Add(this.btnLamMoi);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(299, 457);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(510, 49);
            this.panelControl2.TabIndex = 1;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXuatFile.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnXuatFile.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.Image")));
            this.btnXuatFile.Location = new System.Drawing.Point(356, 11);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(142, 28);
            this.btnXuatFile.TabIndex = 5;
            this.btnXuatFile.Text = "Kết xuất danh sách";
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(158, 11);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 28);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grcDanhMuc
            // 
            this.grcDanhMuc.ContextMenuStrip = this.contextMenuStrip1;
            this.grcDanhMuc.DataMember = "Account";
            this.grcDanhMuc.DataSource = this.sqlDataSource1;
            this.grcDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grcDanhMuc.Location = new System.Drawing.Point(299, 0);
            this.grcDanhMuc.MainView = this.gvDanhMuc;
            this.grcDanhMuc.Name = "grcDanhMuc";
            this.grcDanhMuc.Size = new System.Drawing.Size(510, 457);
            this.grcDanhMuc.TabIndex = 2;
            this.grcDanhMuc.UseEmbeddedNavigator = true;
            this.grcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            this.grcDanhMuc.Click += new System.EventHandler(this.grcDanhMuc_Click);
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
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression12.ColumnName = "Account_ID";
            table3.MetaSerializable = "0|0|125|180";
            table3.Name = "Account";
            columnExpression12.Table = table3;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "Account_Name";
            columnExpression13.Table = table3;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "Account_Image";
            columnExpression14.Table = table3;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "Account_Type_ID";
            columnExpression15.Table = table3;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "Account_Age";
            table4.MetaSerializable = "0|0|125|200";
            table4.Name = "Human";
            columnExpression16.Table = table4;
            column16.Expression = columnExpression16;
            columnExpression17.ColumnName = "Account_Sex";
            columnExpression17.Table = table4;
            column17.Expression = columnExpression17;
            columnExpression18.ColumnName = "Account_Email";
            columnExpression18.Table = table4;
            column18.Expression = columnExpression18;
            columnExpression19.ColumnName = "Account_Phone";
            columnExpression19.Table = table4;
            column19.Expression = columnExpression19;
            columnExpression20.ColumnName = "Account_Job";
            columnExpression20.Table = table4;
            column20.Expression = columnExpression20;
            columnExpression21.ColumnName = "Account_City";
            columnExpression21.Table = table4;
            column21.Expression = columnExpression21;
            columnExpression22.ColumnName = "Account_Address";
            columnExpression22.Table = table4;
            column22.Expression = columnExpression22;
            selectQuery2.Columns.Add(column12);
            selectQuery2.Columns.Add(column13);
            selectQuery2.Columns.Add(column14);
            selectQuery2.Columns.Add(column15);
            selectQuery2.Columns.Add(column16);
            selectQuery2.Columns.Add(column17);
            selectQuery2.Columns.Add(column18);
            selectQuery2.Columns.Add(column19);
            selectQuery2.Columns.Add(column20);
            selectQuery2.Columns.Add(column21);
            selectQuery2.Columns.Add(column22);
            selectQuery2.FilterString = "[Account.Account_Type_ID] = 5";
            selectQuery2.GroupFilterString = "";
            selectQuery2.Name = "Account";
            relationColumnInfo2.NestedKeyColumn = "Account_ID";
            relationColumnInfo2.ParentKeyColumn = "Account_ID";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table4;
            join2.Parent = table3;
            selectQuery2.Relations.Add(join2);
            selectQuery2.Tables.Add(table3);
            selectQuery2.Tables.Add(table4);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDanhMuc.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDanhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccount_ID,
            this.colAccount_Name,
            this.colAccount_Image,
            this.colAccount_Type_ID,
            this.colAccount_Age,
            this.colAccount_Sex,
            this.colAccount_Email,
            this.colAccount_Phone,
            this.colAccount_Job,
            this.colAccount_City,
            this.colAccount_Address});
            this.gvDanhMuc.GridControl = this.grcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDanhMuc.OptionsView.ShowFooter = true;
            // 
            // colAccount_ID
            // 
            this.colAccount_ID.FieldName = "Account_ID";
            this.colAccount_ID.Name = "colAccount_ID";
            // 
            // colAccount_Name
            // 
            this.colAccount_Name.Caption = "Tên bệnh nhân";
            this.colAccount_Name.FieldName = "Account_Name";
            this.colAccount_Name.Name = "colAccount_Name";
            this.colAccount_Name.Visible = true;
            this.colAccount_Name.VisibleIndex = 0;
            this.colAccount_Name.Width = 95;
            // 
            // colAccount_Image
            // 
            this.colAccount_Image.FieldName = "Account_Image";
            this.colAccount_Image.Name = "colAccount_Image";
            // 
            // colAccount_Type_ID
            // 
            this.colAccount_Type_ID.FieldName = "Account_Type_ID";
            this.colAccount_Type_ID.Name = "colAccount_Type_ID";
            // 
            // colAccount_Age
            // 
            this.colAccount_Age.Caption = "Tuổi";
            this.colAccount_Age.FieldName = "Account_Age";
            this.colAccount_Age.Name = "colAccount_Age";
            this.colAccount_Age.Visible = true;
            this.colAccount_Age.VisibleIndex = 1;
            this.colAccount_Age.Width = 48;
            // 
            // colAccount_Sex
            // 
            this.colAccount_Sex.Caption = "Giới tính";
            this.colAccount_Sex.FieldName = "Account_Sex";
            this.colAccount_Sex.Name = "colAccount_Sex";
            this.colAccount_Sex.Visible = true;
            this.colAccount_Sex.VisibleIndex = 2;
            this.colAccount_Sex.Width = 43;
            // 
            // colAccount_Email
            // 
            this.colAccount_Email.FieldName = "Account_Email";
            this.colAccount_Email.Name = "colAccount_Email";
            // 
            // colAccount_Phone
            // 
            this.colAccount_Phone.Caption = "Số điện thoại";
            this.colAccount_Phone.FieldName = "Account_Phone";
            this.colAccount_Phone.Name = "colAccount_Phone";
            this.colAccount_Phone.Visible = true;
            this.colAccount_Phone.VisibleIndex = 3;
            this.colAccount_Phone.Width = 66;
            // 
            // colAccount_Job
            // 
            this.colAccount_Job.Caption = "Nghề nghiệp";
            this.colAccount_Job.FieldName = "Account_Job";
            this.colAccount_Job.Name = "colAccount_Job";
            this.colAccount_Job.Visible = true;
            this.colAccount_Job.VisibleIndex = 5;
            this.colAccount_Job.Width = 82;
            // 
            // colAccount_City
            // 
            this.colAccount_City.FieldName = "Account_City";
            this.colAccount_City.Name = "colAccount_City";
            // 
            // colAccount_Address
            // 
            this.colAccount_Address.Caption = "Địa chỉ";
            this.colAccount_Address.FieldName = "Account_Address";
            this.colAccount_Address.Name = "colAccount_Address";
            this.colAccount_Address.Visible = true;
            this.colAccount_Address.VisibleIndex = 4;
            this.colAccount_Address.Width = 124;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 506);
            this.Controls.Add(this.grcDanhMuc);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Patient";
            this.Text = "Bệnh nhân";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SearchControl searchControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnTiepNhan;
        private DevExpress.XtraEditors.SimpleButton btnXuatFile;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.PictureEdit peAnh;
        private DevExpress.XtraGrid.GridControl grcDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Image;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Type_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Age;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Sex;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Email;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Job;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_City;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Address;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsCapNhat;
        private System.Windows.Forms.ToolStripMenuItem cmsXoa;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lbThanhPho;
        private DevExpress.XtraEditors.LabelControl lbEmail;
        private DevExpress.XtraEditors.LabelControl lbSoDienThoai;
        private DevExpress.XtraEditors.LabelControl lbDiaChi;
        private DevExpress.XtraEditors.LabelControl lbGioiTinh;
        private DevExpress.XtraEditors.LabelControl lbTen;
        private System.Windows.Forms.PictureBox pictureBox7;
        private DevExpress.XtraEditors.LabelControl lbTuoi;
        private System.Windows.Forms.PictureBox pictureBox8;
        private DevExpress.XtraEditors.LabelControl lbCongViec;
    }
}