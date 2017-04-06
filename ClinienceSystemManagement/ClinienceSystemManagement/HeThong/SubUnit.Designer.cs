namespace ClinienceSystemManagement.HeThong
{
    partial class SubUnit
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
            DevExpress.DataAccess.Sql.TableQuery tableQuery29 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo36 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo57 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo58 = new DevExpress.DataAccess.Sql.ColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubUnit));
            DevExpress.DataAccess.Sql.TableQuery tableQuery30 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo8 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo8 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo37 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo38 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo59 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo60 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery31 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo39 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo61 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo62 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery32 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo40 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo63 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo64 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource4 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabContarol1 = new DevExpress.XtraTab.XtraTabControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).BeginInit();
            this.xtraTabContarol1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(22, 74);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(243, 59);
            this.txtGhiChu.TabIndex = 28;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "Ingredient";
            this.bindingSource3.DataSource = this.sqlDataSource3;
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource3.Name = "sqlDataSource3";
            tableQuery29.Name = "Ingredient";
            tableInfo36.Name = "Ingredient";
            columnInfo57.Name = "Ingredient_Name";
            columnInfo58.Name = "Ingredient_ID";
            tableInfo36.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo57,
            columnInfo58});
            tableQuery29.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo36});
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery29});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Medincine_Ingredient";
            this.bindingSource2.DataSource = this.sqlDataSource2;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            tableQuery30.Name = "Medincine_Ingredient";
            relationColumnInfo8.NestedKeyColumn = "Ingredient_ID";
            relationColumnInfo8.ParentKeyColumn = "Ingredient_ID";
            relationInfo8.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo8});
            relationInfo8.NestedTable = "Ingredient";
            relationInfo8.ParentTable = "Medincine_Ingredient";
            tableQuery30.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo8});
            tableInfo37.Name = "Medincine_Ingredient";
            tableInfo38.Name = "Ingredient";
            columnInfo59.Name = "Ingredient_ID";
            columnInfo60.Name = "Ingredient_Name";
            tableInfo38.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo59,
            columnInfo60});
            tableQuery30.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo37,
            tableInfo38});
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery30});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // sqlDataSource4
            // 
            this.sqlDataSource4.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource4.Name = "sqlDataSource4";
            tableQuery31.Name = "Ingredient";
            tableInfo39.Name = "Ingredient";
            columnInfo61.Name = "Ingredient_ID";
            columnInfo62.Name = "Ingredient_Name";
            tableInfo39.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo61,
            columnInfo62});
            tableQuery31.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo39});
            this.sqlDataSource4.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery31});
            this.sqlDataSource4.ResultSchemaSerializable = resources.GetString("sqlDataSource4.ResultSchemaSerializable");
            // 
            // bindingSource4
            // 
            this.bindingSource4.DataMember = "Ingredient";
            this.bindingSource4.DataSource = this.sqlDataSource4;
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
            this.txtTen2.Size = new System.Drawing.Size(54, 13);
            this.txtTen2.TabIndex = 25;
            this.txtTen2.Text = "Tên đơn vị:";
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
            // xtraTabContarol1
            // 
            this.xtraTabContarol1.Location = new System.Drawing.Point(24, 10);
            this.xtraTabContarol1.Name = "xtraTabContarol1";
            this.xtraTabContarol1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabContarol1.Size = new System.Drawing.Size(291, 175);
            this.xtraTabContarol1.TabIndex = 13;
            this.xtraTabContarol1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbTrangThai);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 198);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(333, 40);
            this.panelControl1.TabIndex = 12;
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
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            tableQuery32.Name = "Paraclinical_Group";
            tableInfo40.Name = "Paraclinical_Group";
            columnInfo63.Name = "Paraclinical_Group_ID";
            columnInfo64.Name = "Paraclinical_Group_Name";
            tableInfo40.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo63,
            columnInfo64});
            tableQuery32.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo40});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery32});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Paraclinical_Group";
            this.bindingSource1.DataSource = this.sqlDataSource1;
            // 
            // SubUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 238);
            this.Controls.Add(this.xtraTabContarol1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm đơn vị";
            this.Load += new System.EventHandler(this.SubUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).EndInit();
            this.xtraTabContarol1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private System.Windows.Forms.BindingSource bindingSource3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource4;
        private System.Windows.Forms.BindingSource bindingSource4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl txtTen2;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabControl xtraTabContarol1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbTrangThai;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}