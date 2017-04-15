namespace ClinienceSystemManagement.KhamBenh
{
    partial class Examination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Examination));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery4 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtThanPhien = new DevExpress.XtraEditors.MemoEdit();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtLyDo = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.LabelControl();
            this.lkeBacSi = new DevExpress.XtraEditors.LookUpEdit();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanPhien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeBacSi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(341, 16);
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
            this.btnLuu.Location = new System.Drawing.Point(260, 16);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 25);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Tạo";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbTrangThai);
            this.panelControl1.Controls.Add(this.txtMa);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 445);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(438, 53);
            this.panelControl1.TabIndex = 7;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbTrangThai.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbTrangThai.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lbTrangThai.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.lbTrangThai.Location = new System.Drawing.Point(23, 19);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(0, 15);
            this.lbTrangThai.TabIndex = 34;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(244, 18);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(10, 20);
            this.txtMa.TabIndex = 27;
            this.txtMa.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.dtNgayKetThuc);
            this.groupBox2.Controls.Add(this.lkeBacSi);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.dtNgayBatDau);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.txtThanPhien);
            this.groupBox2.Controls.Add(this.labelControl11);
            this.groupBox2.Controls.Add(this.txtLyDo);
            this.groupBox2.Controls.Add(this.labelControl10);
            this.groupBox2.Location = new System.Drawing.Point(22, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 418);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tình trạng tiếp nhận";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(152, 364);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Ngày bắt đầu:";
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.EditValue = new System.DateTime(2017, 4, 15, 10, 37, 57, 812);
            this.dtNgayBatDau.Location = new System.Drawing.Point(152, 383);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayBatDau.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayBatDau.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtNgayBatDau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtNgayBatDau.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtNgayBatDau.Size = new System.Drawing.Size(107, 20);
            this.dtNgayBatDau.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 364);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Bác sĩ khám:";
            // 
            // txtThanPhien
            // 
            this.txtThanPhien.Location = new System.Drawing.Point(17, 244);
            this.txtThanPhien.Name = "txtThanPhien";
            this.txtThanPhien.Size = new System.Drawing.Size(360, 110);
            this.txtThanPhien.TabIndex = 22;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression7.ColumnName = "Account_ID";
            table3.MetaSerializable = "0|0|125|180";
            table3.Name = "Account";
            columnExpression7.Table = table3;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "Account_Name";
            columnExpression8.Table = table3;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "Account_Type_ID";
            columnExpression9.Table = table3;
            column9.Expression = columnExpression9;
            selectQuery3.Columns.Add(column7);
            selectQuery3.Columns.Add(column8);
            selectQuery3.Columns.Add(column9);
            selectQuery3.FilterString = "[Account.Account_Type_ID] = 2";
            selectQuery3.GroupFilterString = "";
            selectQuery3.Name = "Account";
            selectQuery3.Tables.Add(table3);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(18, 225);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(57, 13);
            this.labelControl11.TabIndex = 24;
            this.labelControl11.Text = "Than phiền:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(17, 68);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(360, 146);
            this.txtLyDo.TabIndex = 23;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(17, 49);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(58, 13);
            this.labelControl10.TabIndex = 22;
            this.labelControl10.Text = "Lý do khám:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Bệnh nhân:";
            // 
            // txtTen
            // 
            this.txtTen.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.txtTen.Location = new System.Drawing.Point(87, 23);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(0, 16);
            this.txtTen.TabIndex = 29;
            // 
            // lkeBacSi
            // 
            this.lkeBacSi.Location = new System.Drawing.Point(18, 383);
            this.lkeBacSi.Name = "lkeBacSi";
            this.lkeBacSi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeBacSi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_ID", "Account_ID", 79, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Name", "Bác sĩ", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Type_ID", "Account_Type_ID", 96, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.lkeBacSi.Properties.DataSource = this.accountBindingSource1;
            this.lkeBacSi.Properties.DisplayMember = "Account_Name";
            this.lkeBacSi.Properties.NullText = "Bác sĩ";
            this.lkeBacSi.Properties.ValueMember = "Account_ID";
            this.lkeBacSi.Size = new System.Drawing.Size(116, 20);
            this.lkeBacSi.TabIndex = 30;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_ClinienceSystemManagement_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            columnExpression10.ColumnName = "Account_ID";
            table4.MetaSerializable = "0|0|125|180";
            table4.Name = "Account";
            columnExpression10.Table = table4;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "Account_Name";
            columnExpression11.Table = table4;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "Account_Type_ID";
            columnExpression12.Table = table4;
            column12.Expression = columnExpression12;
            selectQuery4.Columns.Add(column10);
            selectQuery4.Columns.Add(column11);
            selectQuery4.Columns.Add(column12);
            selectQuery4.FilterString = "[Account.Account_Type_ID] = 2";
            selectQuery4.GroupFilterString = "";
            selectQuery4.Name = "Account";
            selectQuery4.Tables.Add(table4);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery4});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // accountBindingSource1
            // 
            this.accountBindingSource1.DataMember = "Account";
            this.accountBindingSource1.DataSource = this.sqlDataSource2;
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.EditValue = new System.DateTime(2017, 4, 15, 10, 37, 57, 812);
            this.dtNgayKetThuc.Location = new System.Drawing.Point(270, 383);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayKetThuc.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayKetThuc.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtNgayKetThuc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtNgayKetThuc.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtNgayKetThuc.Size = new System.Drawing.Size(107, 20);
            this.dtNgayKetThuc.TabIndex = 31;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(270, 364);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 13);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Ngày kết thúc:";
            // 
            // Examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Examination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiên khám mới";
            this.Load += new System.EventHandler(this.PatientDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanPhien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeBacSi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.MemoEdit txtThanPhien;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.MemoEdit txtLyDo;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl lbTrangThai;
        private DevExpress.XtraEditors.DateEdit dtNgayBatDau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lkeBacSi;
        private System.Windows.Forms.BindingSource accountBindingSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtNgayKetThuc;
    }
}