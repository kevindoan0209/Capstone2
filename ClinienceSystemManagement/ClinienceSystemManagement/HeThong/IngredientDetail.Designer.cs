namespace ClinienceSystemManagement.HeThong
{
    partial class IngredientDetail
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
            DevExpress.DataAccess.Sql.TableQuery tableQuery3 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo2 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo4 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo5 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo5 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo6 = new DevExpress.DataAccess.Sql.ColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientDetail));
            DevExpress.DataAccess.Sql.TableQuery tableQuery4 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo6 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo7 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo8 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtTen = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.txtDonVi = new DevExpress.XtraEditors.TextEdit();
            this.txtHamLuong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabContarol1 = new DevExpress.XtraTab.XtraTabControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHamLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).BeginInit();
            this.xtraTabContarol1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtTen);
            this.xtraTabPage2.Controls.Add(this.txtDonVi);
            this.xtraTabPage2.Controls.Add(this.txtHamLuong);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Controls.Add(this.labelControl11);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(285, 115);
            this.xtraTabPage2.Text = "Thành phần";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(26, 34);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTen.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ingredient_ID", "Ingredient_ID", 90, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ingredient_Name", "Thành phần", 93, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.txtTen.Properties.DataSource = this.bindingSource2;
            this.txtTen.Properties.DisplayMember = "Ingredient_Name";
            this.txtTen.Properties.NullText = "Chọn thành phần";
            this.txtTen.Properties.ValueMember = "Ingredient_ID";
            this.txtTen.Size = new System.Drawing.Size(228, 20);
            this.txtTen.TabIndex = 25;
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
            tableQuery3.Name = "Medincine_Ingredient";
            relationColumnInfo2.NestedKeyColumn = "Ingredient_ID";
            relationColumnInfo2.ParentKeyColumn = "Ingredient_ID";
            relationInfo2.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo2});
            relationInfo2.NestedTable = "Ingredient";
            relationInfo2.ParentTable = "Medincine_Ingredient";
            tableQuery3.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo2});
            tableInfo4.Name = "Medincine_Ingredient";
            tableInfo5.Name = "Ingredient";
            columnInfo5.Name = "Ingredient_ID";
            columnInfo6.Name = "Ingredient_Name";
            tableInfo5.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo5,
            columnInfo6});
            tableQuery3.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo4,
            tableInfo5});
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery3});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(140, 79);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(114, 20);
            this.txtDonVi.TabIndex = 23;
            // 
            // txtHamLuong
            // 
            this.txtHamLuong.Location = new System.Drawing.Point(26, 79);
            this.txtHamLuong.Name = "txtHamLuong";
            this.txtHamLuong.Size = new System.Drawing.Size(97, 20);
            this.txtHamLuong.TabIndex = 22;
            this.txtHamLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHamLuong_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(140, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Đơn vị:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Hàm lượng:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(26, 15);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(107, 13);
            this.labelControl11.TabIndex = 19;
            this.labelControl11.Text = "Tên thành phần dược:";
            // 
            // xtraTabContarol1
            // 
            this.xtraTabContarol1.Location = new System.Drawing.Point(23, 12);
            this.xtraTabContarol1.Name = "xtraTabContarol1";
            this.xtraTabContarol1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabContarol1.Size = new System.Drawing.Size(291, 143);
            this.xtraTabContarol1.TabIndex = 9;
            this.xtraTabContarol1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(234, 7);
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
            this.btnLuu.Location = new System.Drawing.Point(153, 7);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 25);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 167);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(329, 40);
            this.panelControl1.TabIndex = 8;
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
            tableQuery4.Name = "Paraclinical_Group";
            tableInfo6.Name = "Paraclinical_Group";
            columnInfo7.Name = "Paraclinical_Group_ID";
            columnInfo8.Name = "Paraclinical_Group_Name";
            tableInfo6.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo7,
            columnInfo8});
            tableQuery4.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo6});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery4});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // IngredientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 207);
            this.Controls.Add(this.xtraTabContarol1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngredientDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinience";
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHamLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContarol1)).EndInit();
            this.xtraTabContarol1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraTab.XtraTabControl xtraTabContarol1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.TextEdit txtDonVi;
        private DevExpress.XtraEditors.TextEdit txtHamLuong;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit txtTen;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
    }
}