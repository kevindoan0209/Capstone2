namespace ClinienceSystemManagement.KhamBenh
{
    partial class ClinienceCost
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
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClinienceCost));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery6 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table7 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Table table8 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery7 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table9 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery8 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table10 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.sqlDataSource4 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.txtGiaMoi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtGiaHienTai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaMoi.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaHienTai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource4
            // 
            this.sqlDataSource4.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource4.Name = "sqlDataSource4";
            columnExpression9.ColumnName = "Ingredient_ID";
            table6.Name = "Ingredient";
            columnExpression9.Table = table6;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "Ingredient_Name";
            columnExpression10.Table = table6;
            column10.Expression = columnExpression10;
            selectQuery5.Columns.Add(column9);
            selectQuery5.Columns.Add(column10);
            selectQuery5.Name = "Ingredient";
            selectQuery5.Tables.Add(table6);
            this.sqlDataSource4.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery5});
            this.sqlDataSource4.ResultSchemaSerializable = resources.GetString("sqlDataSource4.ResultSchemaSerializable");
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            columnExpression11.ColumnName = "Ingredient_ID";
            table7.Name = "Ingredient";
            columnExpression11.Table = table7;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "Ingredient_Name";
            columnExpression12.Table = table7;
            column12.Expression = columnExpression12;
            selectQuery6.Columns.Add(column11);
            selectQuery6.Columns.Add(column12);
            selectQuery6.Name = "Medincine_Ingredient";
            relationColumnInfo2.NestedKeyColumn = "Ingredient_ID";
            relationColumnInfo2.ParentKeyColumn = "Ingredient_ID";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table7;
            table8.Name = "Medincine_Ingredient";
            join2.Parent = table8;
            selectQuery6.Relations.Add(join2);
            selectQuery6.Tables.Add(table8);
            selectQuery6.Tables.Add(table7);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery6});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Medincine_Ingredient";
            this.bindingSource2.DataSource = this.sqlDataSource2;
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
            columnExpression13.ColumnName = "Ingredient_Name";
            table9.Name = "Ingredient";
            columnExpression13.Table = table9;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "Ingredient_ID";
            columnExpression14.Table = table9;
            column14.Expression = columnExpression14;
            selectQuery7.Columns.Add(column13);
            selectQuery7.Columns.Add(column14);
            selectQuery7.Name = "Ingredient";
            selectQuery7.Tables.Add(table9);
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery7});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // txtGiaMoi
            // 
            this.txtGiaMoi.EditValue = "0";
            this.txtGiaMoi.Location = new System.Drawing.Point(21, 93);
            this.txtGiaMoi.Name = "txtGiaMoi";
            this.txtGiaMoi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGiaMoi.Size = new System.Drawing.Size(170, 20);
            this.txtGiaMoi.TabIndex = 34;
            this.txtGiaMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 74);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 13);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Giá phiên khám mới:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtGiaHienTai);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtGiaMoi);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Location = new System.Drawing.Point(26, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 133);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giá phiên khám";
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(184, 6);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 25);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbTrangThai);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 165);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(279, 40);
            this.panelControl1.TabIndex = 17;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbTrangThai.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbTrangThai.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lbTrangThai.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.lbTrangThai.Location = new System.Drawing.Point(29, 14);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(0, 15);
            this.lbTrangThai.TabIndex = 35;
            // 
            // btnLuu
            // 
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(103, 6);
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
            columnExpression15.ColumnName = "Paraclinical_Group_ID";
            table10.Name = "Paraclinical_Group";
            columnExpression15.Table = table10;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "Paraclinical_Group_Name";
            columnExpression16.Table = table10;
            column16.Expression = columnExpression16;
            selectQuery8.Columns.Add(column15);
            selectQuery8.Columns.Add(column16);
            selectQuery8.Name = "Paraclinical_Group";
            selectQuery8.Tables.Add(table10);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery8});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // bindingSource4
            // 
            this.bindingSource4.DataMember = "Ingredient";
            this.bindingSource4.DataSource = this.sqlDataSource4;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Paraclinical_Group";
            this.bindingSource1.DataSource = this.sqlDataSource1;
            // 
            // txtGiaHienTai
            // 
            this.txtGiaHienTai.EditValue = "0";
            this.txtGiaHienTai.Location = new System.Drawing.Point(21, 48);
            this.txtGiaHienTai.Name = "txtGiaHienTai";
            this.txtGiaHienTai.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGiaHienTai.Size = new System.Drawing.Size(170, 20);
            this.txtGiaHienTai.TabIndex = 36;
            this.txtGiaHienTai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit1_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 13);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Giá phiên khám hiện tại:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(197, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "VND";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(197, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 13);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "VND";
            // 
            // ClinienceCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 205);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClinienceCost";
            this.Text = "Clinience";
            this.Load += new System.EventHandler(this.ClinienceCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaMoi.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaHienTai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource4;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.XtraEditors.TextEdit txtGiaMoi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbTrangThai;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGiaHienTai;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}