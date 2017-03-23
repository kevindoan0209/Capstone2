using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BussinessLogicLayer;
using PresentationLayer;
using DevExpress.XtraEditors;

namespace ClinienceSystemManagement
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String TenDangNhap = txtTenDangNhap.Text;
            String MatKhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenDangNhap.Focus();
            }
            else
            {
                try
                {
                    DataTable dt = BLL_TaiKhoan.DangNhap(TenDangNhap, MatKhau);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        this.DialogResult = DialogResult.OK;                 
                    }
                    else
                    {
                        XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenDangNhap.Text = "";
                        txtMatKhau.Text = "";
                        txtTenDangNhap.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }        
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = XtraMessageBox.Show("Bạn có thật sự muốn thoát", "Clinience", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}