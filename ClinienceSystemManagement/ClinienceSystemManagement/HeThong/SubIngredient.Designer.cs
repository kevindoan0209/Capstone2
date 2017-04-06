namespace ClinienceSystemManagement.HeThong
{
    partial class SubIngredient
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
            DevExpress.DataAccess.Sql.TableInfo tableInfo6 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo9 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo10 = new DevExpress.DataAccess.Sql.ColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubIngredient));
            DevExpress.DataAccess.Sql.TableQuery tableQuery6 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo7 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo11 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo12 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery7 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo2 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo8 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo9 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo13 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo14 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery8 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo10 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo15 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo16 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lbTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabContarol1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource4 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).BeginInit();
            this.xtraTabContarol1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            tableQuery5.Name = "Paraclinical_Group";
            tableInfo6.Name = "Paraclinical_Group";
            columnInfo9.Name = "Paraclinical_Group_ID";
            columnInfo10.Name = "Paraclinical_Group_Name";
            tableInfo6.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo9,
            columnInfo10});
            tableQuery5.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo6});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery5});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbTrangThai.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbTrangThai.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lbTrangThai.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.lbTrangThai.Location = new System.Drawing.Point(27, 14);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(0, 15);
            this.lbTrangThai.TabIndex = 35;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbTrangThai);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 199);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(334, 40);
            this.panelControl1.TabIndex = 10;
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(234, 8);
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
            this.btnLuu.Location = new System.Drawing.Point(153, 8);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 25);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // xtraTabContarol1
            // 
            this.xtraTabContarol1.Location = new System.Drawing.Point(24, 12);
            this.xtraTabContarol1.Name = "xtraTabContarol1";
            this.xtraTabContarol1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabContarol1.Size = new System.Drawing.Size(291, 175);
            this.xtraTabContarol1.TabIndex = 11;
            this.xtraTabContarol1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtGhiChu);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Controls.Add(this.txtTen2);
            this.xtraTabPage2.Controls.Add(this.txtTen);
            this.xtraTabPage2.Controls.Add(this.txtMa);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(285, 147);
            this.xtraTabPage2.Text = "Thành phần";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Ghi chú:";
            // 
            // txtTen2
            // 
            this.txtTen2.Location = new System.Drawing.Point(102, 10);
            this.txtTen2.Name = "txtTen2";
            this.txtTen2.Size = new System.Drawing.Size(80, 13);
            this.txtTen2.TabIndex = 25;
            this.txtTen2.Text = "Tên thành phần:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(102, 29);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(163, 20);
            this.txtTen.TabIndex = 24;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(22, 29);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(67, 20);
            this.txtMa.TabIndex = 23;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(18, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Mã:";
            // 
            // bindingSource4
            // 
            this.bindingSource4.DataMember = "Ingredient";
            this.bindingSource4.DataSource = this.sqlDataSource4;
            // 
            // sqlDataSource4
            // 
            this.sqlDataSource4.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource4.Name = "sqlDataSource4";
            tableQuery6.Name = "Ingredient";
            tableInfo7.Name = "Ingredient";
            columnInfo11.Name = "Ingredient_ID";
            columnInfo12.Name = "Ingredient_Name";
            tableInfo7.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo11,
            columnInfo12});
            tableQuery6.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo7});
            this.sqlDataSource4.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery6});
            this.sqlDataSource4.ResultSchemaSerializable = resources.GetString("sqlDataSource4.ResultSchemaSerializable");
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            tableQuery7.Name = "Medincine_Ingredient";
            relationColumnInfo2.NestedKeyColumn = "Ingredient_ID";
            relationColumnInfo2.ParentKeyColumn = "Ingredient_ID";
            relationInfo2.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo2});
            relationInfo2.NestedTable = "Ingredient";
            relationInfo2.ParentTable = "Medincine_Ingredient";
            tableQuery7.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo2});
            tableInfo8.Name = "Medincine_Ingredient";
            tableInfo9.Name = "Ingredient";
            columnInfo13.Name = "Ingredient_ID";
            columnInfo14.Name = "Ingredient_Name";
            tableInfo9.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo13,
            columnInfo14});
            tableQuery7.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo8,
            tableInfo9});
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery7});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Medincine_Ingredient";
            this.bindingSource2.DataSource = this.sqlDataSource2;
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource3.Name = "sqlDataSource3";
            tableQuery8.Name = "Ingredient";
            tableInfo10.Name = "Ingredient";
            columnInfo15.Name = "Ingredient_Name";
            columnInfo16.Name = "Ingredient_ID";
            tableInfo10.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo15,
            columnInfo16});
            tableQuery8.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo10});
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery8});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "Ingredient";
            this.bindingSource3.DataSource = this.sqlDataSource3;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Paraclinical_Group";
            this.bindingSource1.DataSource = this.sqlDataSource1;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(22, 74);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(243, 59);
            this.txtGhiChu.TabIndex = 28;
            // 
            // SubIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 239);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.xtraTabContarol1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubIngredient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thành phần";
            this.Load += new System.EventHandler(this.SubIngredient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).EndInit();
            this.xtraTabContarol1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.LabelControl lbTrangThai;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraTab.XtraTabControl xtraTabContarol1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.BindingSource bindingSource4;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource4;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.LabelControl txtTen2;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
    }
}