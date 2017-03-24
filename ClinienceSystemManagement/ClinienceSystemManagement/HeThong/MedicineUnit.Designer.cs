﻿namespace ClinienceSystemManagement.HeThong
{
    partial class MedicineUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineUnit));
            DevExpress.DataAccess.Sql.TableQuery tableQuery5 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo5 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo13 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo14 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo15 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery6 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo6 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo16 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo17 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo18 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.btnTao = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabContarol1 = new DevExpress.XtraTab.XtraTabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource4 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnit_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit_Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXoa = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).BeginInit();
            this.xtraTabContarol1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(19, 280);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(191, 28);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "* Nhấn chuột phải trên danh sách \r\nđể xóa hoặc cập nhật dữ liệu";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.Name = "sqlDataSource2";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(144, 283);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Làm mới";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(19, 128);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 140);
            this.txtGhiChu.TabIndex = 23;
            // 
            // btnTao
            // 
            this.btnTao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTao.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTao.Image = ((System.Drawing.Image)(resources.GetObject("btnTao.Image")));
            this.btnTao.Location = new System.Drawing.Point(63, 283);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 25);
            this.btnTao.TabIndex = 9;
            this.btnTao.Text = "Lưu";
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(19, 109);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Ghi chú:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(19, 64);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(54, 13);
            this.labelControl12.TabIndex = 21;
            this.labelControl12.Text = "Tên đơn vị:";
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
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(19, 38);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(147, 20);
            this.txtMa.TabIndex = 3;
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource3.Name = "sqlDataSource3";
            tableQuery5.Name = "Ingredient";
            tableInfo5.Name = "Ingredient";
            columnInfo13.Name = "Ingredient_ID";
            columnInfo14.Name = "Ingredient_Name";
            columnInfo15.Name = "Ingredient_Note";
            tableInfo5.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo13,
            columnInfo14,
            columnInfo15});
            tableQuery5.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo5});
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery5});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // xtraTabPage2
            // 
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
            this.xtraTabPage2.Size = new System.Drawing.Size(238, 321);
            this.xtraTabPage2.Text = "Thông tin đơn vị";
            // 
            // xtraTabContarol1
            // 
            this.xtraTabContarol1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.xtraTabContarol1.Location = new System.Drawing.Point(21, 18);
            this.xtraTabContarol1.Name = "xtraTabContarol1";
            this.xtraTabContarol1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabContarol1.Size = new System.Drawing.Size(244, 349);
            this.xtraTabContarol1.TabIndex = 8;
            this.xtraTabContarol1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.xtraTabContarol1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 386);
            this.panel1.TabIndex = 2;
            // 
            // grcDanhMuc
            // 
            this.grcDanhMuc.ContextMenuStrip = this.contextMenuStrip2;
            this.grcDanhMuc.DataMember = "Medicine_Unit";
            this.grcDanhMuc.DataSource = this.sqlDataSource4;
            this.grcDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDanhMuc.Location = new System.Drawing.Point(284, 0);
            this.grcDanhMuc.MainView = this.gvDanhMuc;
            this.grcDanhMuc.Name = "grcDanhMuc";
            this.grcDanhMuc.Size = new System.Drawing.Size(432, 386);
            this.grcDanhMuc.TabIndex = 3;
            this.grcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            // 
            // sqlDataSource4
            // 
            this.sqlDataSource4.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource4.Name = "sqlDataSource4";
            tableQuery6.Name = "Medicine_Unit";
            tableInfo6.Name = "Medicine_Unit";
            columnInfo16.Name = "Unit_ID";
            columnInfo17.Name = "Unit_Name";
            columnInfo18.Name = "Unit_Note";
            tableInfo6.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo16,
            columnInfo17,
            columnInfo18});
            tableQuery6.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo6});
            this.sqlDataSource4.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery6});
            this.sqlDataSource4.ResultSchemaSerializable = resources.GetString("sqlDataSource4.ResultSchemaSerializable");
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDanhMuc.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDanhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnit_ID,
            this.colUnit_Name,
            this.colUnit_Note});
            this.gvDanhMuc.GridControl = this.grcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.OptionsFind.AlwaysVisible = true;
            this.gvDanhMuc.OptionsFind.FindNullPrompt = "Nhập vào thông tin tìm kiếm...";
            this.gvDanhMuc.OptionsView.EnableAppearanceEvenRow = true;
            // 
            // colUnit_ID
            // 
            this.colUnit_ID.Caption = "STT";
            this.colUnit_ID.FieldName = "Unit_ID";
            this.colUnit_ID.Name = "colUnit_ID";
            this.colUnit_ID.Visible = true;
            this.colUnit_ID.VisibleIndex = 0;
            this.colUnit_ID.Width = 89;
            // 
            // colUnit_Name
            // 
            this.colUnit_Name.Caption = "Tên đơn vị";
            this.colUnit_Name.FieldName = "Unit_Name";
            this.colUnit_Name.Name = "colUnit_Name";
            this.colUnit_Name.Visible = true;
            this.colUnit_Name.VisibleIndex = 1;
            this.colUnit_Name.Width = 203;
            // 
            // colUnit_Note
            // 
            this.colUnit_Note.Caption = "Ghi chú";
            this.colUnit_Note.FieldName = "Unit_Note";
            this.colUnit_Note.Name = "colUnit_Note";
            this.colUnit_Note.Visible = true;
            this.colUnit_Note.VisibleIndex = 2;
            this.colUnit_Note.Width = 122;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCapNhat,
            this.cmsXoa});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(153, 70);
            // 
            // cmsCapNhat
            // 
            this.cmsCapNhat.Name = "cmsCapNhat";
            this.cmsCapNhat.Size = new System.Drawing.Size(152, 22);
            this.cmsCapNhat.Text = "Cập nhât";
            this.cmsCapNhat.Click += new System.EventHandler(this.cmsCapNhat_Click);
            // 
            // cmsXoa
            // 
            this.cmsXoa.Name = "cmsXoa";
            this.cmsXoa.Size = new System.Drawing.Size(152, 22);
            this.cmsXoa.Text = "Xóa";
            this.cmsXoa.Click += new System.EventHandler(this.cmsXoa_Click);
            // 
            // MedicineUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 386);
            this.Controls.Add(this.grcDanhMuc);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicineUnit";
            this.Text = "Danh mục đơn vị thuốc";
            this.Load += new System.EventHandler(this.MedicineUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).EndInit();
            this.xtraTabContarol1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraEditors.SimpleButton btnTao;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabControl xtraTabContarol1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grcDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource4;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_Note;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cmsCapNhat;
        private System.Windows.Forms.ToolStripMenuItem cmsXoa;
    }
}