namespace ClinienceSystemManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ClinienceSystemManagement.LoadingScreen), true, true);
            this.Clinience = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbxHienMatKhai = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.Clinience.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxHienMatKhai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Clinience
            // 
            this.Clinience.CanvasColor = System.Drawing.SystemColors.Control;
            this.Clinience.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.Clinience.Controls.Add(this.cbxHienMatKhai);
            this.Clinience.Controls.Add(this.labelControl3);
            this.Clinience.Controls.Add(this.line1);
            this.Clinience.Controls.Add(this.label2);
            this.Clinience.Controls.Add(this.labelControl2);
            this.Clinience.Controls.Add(this.txtTenDangNhap);
            this.Clinience.Controls.Add(this.labelControl1);
            this.Clinience.Controls.Add(this.txtMatKhau);
            this.Clinience.Controls.Add(this.btnDangNhap);
            this.Clinience.Controls.Add(this.btnThoat);
            this.Clinience.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Clinience.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.Clinience, "Clinience");
            this.Clinience.Name = "Clinience";
            // 
            // 
            // 
            this.Clinience.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuSide2;
            this.Clinience.Style.BackColorGradientAngle = 90;
            this.Clinience.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground;
            this.Clinience.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Clinience.Style.BorderBottomWidth = 1;
            this.Clinience.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Clinience.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Clinience.Style.BorderLeftWidth = 1;
            this.Clinience.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Clinience.Style.BorderRightWidth = 1;
            this.Clinience.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Clinience.Style.BorderTopWidth = 1;
            this.Clinience.Style.CornerDiameter = 4;
            this.Clinience.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.Clinience.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Clinience.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.Clinience.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.Clinience.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.Clinience.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // cbxHienMatKhai
            // 
            resources.ApplyResources(this.cbxHienMatKhai, "cbxHienMatKhai");
            this.cbxHienMatKhai.Name = "cbxHienMatKhai";
            this.cbxHienMatKhai.Properties.Caption = resources.GetString("cbxHienMatKhai.Properties.Caption");
            this.cbxHienMatKhai.CheckedChanged += new System.EventHandler(this.cbxHienMatKhai_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            this.labelControl3.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl3.Appearance.ForeColor")));
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.ForeColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.line1, "line1");
            this.line1.Name = "line1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.label2.Name = "label2";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            this.labelControl2.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl2.Appearance.ForeColor")));
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // txtTenDangNhap
            // 
            resources.ApplyResources(this.txtTenDangNhap, "txtTenDangNhap");
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtTenDangNhap.Properties.Appearance.Font")));
            this.txtTenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txtTenDangNhap.Properties.MaxLength = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl1.Appearance.ForeColor")));
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // txtMatKhau
            // 
            resources.ApplyResources(this.txtMatKhau, "txtMatKhau");
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtMatKhau.Properties.Appearance.Font")));
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnDangNhap.Appearance.Font")));
            this.btnDangNhap.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("btnDangNhap.Appearance.ForeColor")));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Appearance.Options.UseForeColor = true;
            this.btnDangNhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
            resources.ApplyResources(this.btnDangNhap, "btnDangNhap");
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnThoat.Appearance.Font")));
            this.btnThoat.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("btnThoat.Appearance.ForeColor")));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Appearance.Options.UseForeColor = true;
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 200;
            // 
            // Login
            // 
            this.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("Login.Appearance.BackColor")));
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.Clinience);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Login_Load);
            this.Clinience.ResumeLayout(false);
            this.Clinience.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxHienMatKhai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel Clinience;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit cbxHienMatKhai;
    }
}