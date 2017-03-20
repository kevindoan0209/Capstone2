using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BussinessLogicLayer;
using PresentationLayer;

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
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu");
                txtTenDangNhap.Focus();
            }
            else
            {
                try
                {
                    DataTable dt = BLL_Account.DangNhap(TenDangNhap, MatKhau);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        MessageBox.Show("Đăng nhập thành công");
                        this.DialogResult = DialogResult.OK;
                        TrangChu trangchu = new TrangChu();
                        trangchu.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại ! Tên đăng nhập hoặc mật khẩu không hợp lệ");
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
            this.Close();
        }
    }
}