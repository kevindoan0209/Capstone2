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
            System.Windows.Forms.GroupBox groupBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchControl2 = new DevExpress.XtraEditors.SearchControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnTiepNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnXemBenhNhan = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhienKham = new DevExpress.XtraEditors.SimpleButton();
            this.btnXemPhienKham = new DevExpress.XtraEditors.SimpleButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(groupBox2);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(293, 445);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.searchControl2);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 50);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // searchControl2
            // 
            this.searchControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchControl2.Location = new System.Drawing.Point(12, 18);
            this.searchControl2.Name = "searchControl2";
            this.searchControl2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.searchControl2.Properties.Appearance.Options.UseFont = true;
            this.searchControl2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl2.Properties.NullValuePrompt = "Nhập vào thông tin tìm kiếm...";
            this.searchControl2.Size = new System.Drawing.Size(251, 24);
            this.searchControl2.TabIndex = 5;
            this.searchControl2.ToolTip = "Nhập vào thông tin tìm kiếm";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton2);
            this.panelControl2.Controls.Add(this.btnLamMoi);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(293, 396);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(416, 49);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(293, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(416, 396);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(19, 11);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 28);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTiepNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnTiepNhan.Image")));
            this.btnTiepNhan.Location = new System.Drawing.Point(48, 33);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(174, 28);
            this.btnTiepNhan.TabIndex = 3;
            this.btnTiepNhan.Text = "Tiếp nhận bệnh nhân mới";
            this.btnTiepNhan.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXemBenhNhan
            // 
            this.btnXemBenhNhan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnXemBenhNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXemBenhNhan.Image")));
            this.btnXemBenhNhan.Location = new System.Drawing.Point(48, 67);
            this.btnXemBenhNhan.Name = "btnXemBenhNhan";
            this.btnXemBenhNhan.Size = new System.Drawing.Size(174, 28);
            this.btnXemBenhNhan.TabIndex = 8;
            this.btnXemBenhNhan.Text = "Xem bệnh nhân";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(110, 11);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(142, 28);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Kết xuất danh sách";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.btnXemPhienKham);
            groupBox2.Controls.Add(this.btnPhienKham);
            groupBox2.Controls.Add(this.btnTiepNhan);
            groupBox2.Controls.Add(this.btnXemBenhNhan);
            groupBox2.Location = new System.Drawing.Point(7, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(276, 186);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // btnPhienKham
            // 
            this.btnPhienKham.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPhienKham.Image = ((System.Drawing.Image)(resources.GetObject("btnPhienKham.Image")));
            this.btnPhienKham.Location = new System.Drawing.Point(48, 101);
            this.btnPhienKham.Name = "btnPhienKham";
            this.btnPhienKham.Size = new System.Drawing.Size(174, 28);
            this.btnPhienKham.TabIndex = 9;
            this.btnPhienKham.Text = "Tạo phiên khám mới";
            // 
            // btnXemPhienKham
            // 
            this.btnXemPhienKham.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnXemPhienKham.Image = ((System.Drawing.Image)(resources.GetObject("btnXemPhienKham.Image")));
            this.btnXemPhienKham.Location = new System.Drawing.Point(48, 135);
            this.btnXemPhienKham.Name = "btnXemPhienKham";
            this.btnXemPhienKham.Size = new System.Drawing.Size(174, 28);
            this.btnXemPhienKham.TabIndex = 10;
            this.btnXemPhienKham.Text = "Xem phiên khám";
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 445);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Patient";
            this.Text = "Bệnh nhân";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SearchControl searchControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnXemPhienKham;
        private DevExpress.XtraEditors.SimpleButton btnPhienKham;
        private DevExpress.XtraEditors.SimpleButton btnTiepNhan;
        private DevExpress.XtraEditors.SimpleButton btnXemBenhNhan;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
    }
}