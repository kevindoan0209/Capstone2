namespace ClinienceSystemManagement.HeThong
{
    partial class MedicineIngredient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineIngredient));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xtraTabContarol1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtHamLuongTPT = new DevExpress.XtraEditors.SpinEdit();
            this.txtDonVi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.btnTao = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchControl2 = new DevExpress.XtraEditors.SearchControl();
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIngredient_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngredient_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngredient_Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngredient_Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngredient_Content = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).BeginInit();
            this.xtraTabContarol1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHamLuongTPT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.xtraTabContarol1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 395);
            this.panel1.TabIndex = 0;
            // 
            // xtraTabContarol1
            // 
            this.xtraTabContarol1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.xtraTabContarol1.Location = new System.Drawing.Point(21, 18);
            this.xtraTabContarol1.Name = "xtraTabContarol1";
            this.xtraTabContarol1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabContarol1.Size = new System.Drawing.Size(244, 358);
            this.xtraTabContarol1.TabIndex = 8;
            this.xtraTabContarol1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtHamLuongTPT);
            this.xtraTabPage2.Controls.Add(this.txtDonVi);
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.lbTrangThai);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Controls.Add(this.btnReset);
            this.xtraTabPage2.Controls.Add(this.txtGhiChu);
            this.xtraTabPage2.Controls.Add(this.btnTao);
            this.xtraTabPage2.Controls.Add(this.labelControl9);
            this.xtraTabPage2.Controls.Add(this.labelControl12);
            this.xtraTabPage2.Controls.Add(this.txtTen);
            this.xtraTabPage2.Controls.Add(this.labelControl11);
            this.xtraTabPage2.Controls.Add(this.txtMa);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(238, 330);
            this.xtraTabPage2.Text = "Thông tin thành phần";
            // 
            // txtHamLuongTPT
            // 
            this.txtHamLuongTPT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHamLuongTPT.Location = new System.Drawing.Point(19, 128);
            this.txtHamLuongTPT.Name = "txtHamLuongTPT";
            this.txtHamLuongTPT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHamLuongTPT.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtHamLuongTPT.Size = new System.Drawing.Size(86, 20);
            this.txtHamLuongTPT.TabIndex = 43;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(111, 128);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(108, 20);
            this.txtDonVi.TabIndex = 42;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(111, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "Đơn vị:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Hàm lượng:";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbTrangThai.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbTrangThai.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lbTrangThai.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.lbTrangThai.Location = new System.Drawing.Point(25, 326);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(0, 15);
            this.lbTrangThai.TabIndex = 37;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(19, 287);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(191, 28);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "* Nhấn chuột phải trên danh sách \r\nđể xóa hoặc cập nhật dữ liệu";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(144, 292);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Làm mới";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(19, 173);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 108);
            this.txtGhiChu.TabIndex = 23;
            // 
            // btnTao
            // 
            this.btnTao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTao.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTao.Image = ((System.Drawing.Image)(resources.GetObject("btnTao.Image")));
            this.btnTao.Location = new System.Drawing.Point(63, 292);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 25);
            this.btnTao.TabIndex = 9;
            this.btnTao.Text = "Lưu";
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(19, 154);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(35, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Ghi chú";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(19, 64);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(76, 13);
            this.labelControl12.TabIndex = 21;
            this.labelControl12.Text = "Tên thành phần";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(19, 83);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 20);
            this.txtTen.TabIndex = 20;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(19, 16);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(18, 13);
            this.labelControl11.TabIndex = 19;
            this.labelControl11.Text = "Mã:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(19, 38);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(147, 20);
            this.txtMa.TabIndex = 3;
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
            this.cmsCapNhat.Name = "cmsCapNhat";
            this.cmsCapNhat.Size = new System.Drawing.Size(122, 22);
            this.cmsCapNhat.Text = "Cập nhật";
            this.cmsCapNhat.Click += new System.EventHandler(this.cmsCapNhat_Click);
            // 
            // cmsXoa
            // 
            this.cmsXoa.Name = "cmsXoa";
            this.cmsXoa.Size = new System.Drawing.Size(122, 22);
            this.cmsXoa.Text = "Xóa";
            this.cmsXoa.Click += new System.EventHandler(this.cmsXoa_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(284, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(447, 60);
            this.panelControl1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.searchControl2);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 47);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // searchControl2
            // 
            this.searchControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchControl2.Client = this.grcDanhMuc;
            this.searchControl2.Location = new System.Drawing.Point(22, 16);
            this.searchControl2.Name = "searchControl2";
            this.searchControl2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.searchControl2.Properties.Appearance.Options.UseFont = true;
            this.searchControl2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl2.Properties.Client = this.grcDanhMuc;
            this.searchControl2.Properties.NullValuePrompt = "Nhập vào thông tin tìm kiếm...";
            this.searchControl2.Size = new System.Drawing.Size(390, 24);
            this.searchControl2.TabIndex = 5;
            this.searchControl2.ToolTip = "Nhập vào thông tin tìm kiếm";
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDanhMuc.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDanhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIngredient_Name,
            this.colIngredient_ID,
            this.colIngredient_Note,
            this.colIngredient_Unit,
            this.colIngredient_Content});
            this.gvDanhMuc.GridControl = this.grcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDanhMuc.OptionsView.ShowFooter = true;
            // 
            // colIngredient_Name
            // 
            this.colIngredient_Name.Caption = "Tên thành phần";
            this.colIngredient_Name.FieldName = "Ingredient_Name";
            this.colIngredient_Name.Name = "colIngredient_Name";
            this.colIngredient_Name.Visible = true;
            this.colIngredient_Name.VisibleIndex = 1;
            this.colIngredient_Name.Width = 121;
            // 
            // colIngredient_ID
            // 
            this.colIngredient_ID.Caption = "Mã";
            this.colIngredient_ID.FieldName = "Ingredient_ID";
            this.colIngredient_ID.Name = "colIngredient_ID";
            this.colIngredient_ID.Visible = true;
            this.colIngredient_ID.VisibleIndex = 0;
            this.colIngredient_ID.Width = 33;
            // 
            // colIngredient_Note
            // 
            this.colIngredient_Note.Caption = "Ghi chú";
            this.colIngredient_Note.FieldName = "Ingredient_Note";
            this.colIngredient_Note.Name = "colIngredient_Note";
            this.colIngredient_Note.Visible = true;
            this.colIngredient_Note.VisibleIndex = 4;
            this.colIngredient_Note.Width = 141;
            // 
            // colIngredient_Unit
            // 
            this.colIngredient_Unit.Caption = "Đơn vị";
            this.colIngredient_Unit.FieldName = "Ingredient_Unit";
            this.colIngredient_Unit.Name = "colIngredient_Unit";
            this.colIngredient_Unit.Visible = true;
            this.colIngredient_Unit.VisibleIndex = 2;
            this.colIngredient_Unit.Width = 57;
            // 
            // colIngredient_Content
            // 
            this.colIngredient_Content.Caption = "Hàm lượng";
            this.colIngredient_Content.FieldName = "Ingredient_Content";
            this.colIngredient_Content.Name = "colIngredient_Content";
            this.colIngredient_Content.Visible = true;
            this.colIngredient_Content.VisibleIndex = 3;
            this.colIngredient_Content.Width = 77;
            // 
            // grcDanhMuc
            // 
            this.grcDanhMuc.ContextMenuStrip = this.contextMenuStrip1;
            this.grcDanhMuc.DataMember = "Ingredient";
            this.grcDanhMuc.DataSource = this.sqlDataSource1;
            this.grcDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.TextStringFormat = "Trang {0} / {1}";
            this.grcDanhMuc.Location = new System.Drawing.Point(284, 60);
            this.grcDanhMuc.MainView = this.gvDanhMuc;
            this.grcDanhMuc.Name = "grcDanhMuc";
            this.grcDanhMuc.Size = new System.Drawing.Size(447, 335);
            this.grcDanhMuc.TabIndex = 2;
            this.grcDanhMuc.UseEmbeddedNavigator = true;
            this.grcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression11.ColumnName = "Ingredient_Name";
            table3.MetaSerializable = "0|0|125|140";
            table3.Name = "Ingredient";
            columnExpression11.Table = table3;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "Ingredient_ID";
            columnExpression12.Table = table3;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "Ingredient_Note";
            columnExpression13.Table = table3;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "Ingredient_Unit";
            columnExpression14.Table = table3;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "Ingredient_Content";
            columnExpression15.Table = table3;
            column15.Expression = columnExpression15;
            selectQuery3.Columns.Add(column11);
            selectQuery3.Columns.Add(column12);
            selectQuery3.Columns.Add(column13);
            selectQuery3.Columns.Add(column14);
            selectQuery3.Columns.Add(column15);
            selectQuery3.Name = "Ingredient";
            selectQuery3.Tables.Add(table3);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // MedicineIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 395);
            this.Controls.Add(this.grcDanhMuc);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicineIngredient";
            this.Text = "Danh mục thành phần thuốc";
            this.Load += new System.EventHandler(this.MedicineIngredient_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).EndInit();
            this.xtraTabContarol1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHamLuongTPT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraTab.XtraTabControl xtraTabContarol1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnTao;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsCapNhat;
        private System.Windows.Forms.ToolStripMenuItem cmsXoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbTrangThai;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SearchControl searchControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit txtHamLuongTPT;
        private DevExpress.XtraEditors.TextEdit txtDonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colIngredient_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colIngredient_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colIngredient_Note;
        private DevExpress.XtraGrid.Columns.GridColumn colIngredient_Unit;
        private DevExpress.XtraGrid.Columns.GridColumn colIngredient_Content;
        private DevExpress.XtraGrid.GridControl grcDanhMuc;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}