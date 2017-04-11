using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BussinessLogicLayer;
using DevExpress.XtraEditors;
using System.Threading;
using PresentationLayer;

namespace ClinienceSystemManagement
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {

        public Login()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String TenDangNhap = txtTenDangNhap.Text;
            String MatKhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
               // XtraMessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lbTrangThai.Text = "*Vui lòng nhập tên đăng nhập và mật khẩu";
                txtTenDangNhap.Focus();
            }
            else
            {
                try
                {
                    int count = BLL_Human.Select_CheckUserNameSoftware(TenDangNhap).Rows.Count;
                    if (count < 0)
                    {
                       // XtraMessageBox.Show("Tài khoản không được phép truy cập", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lbTrangThai.Text = "*Tài khoản không được phép truy cập";
                        txtTenDangNhap.Focus();
                    }
                    else {
                        DataTable dt = BLL_Human.Login(TenDangNhap, MatKhau);
                        if (dt.Rows.Count > 0)
                        {
                            DataRow dr = dt.Rows[0];
                            string name = dr["Account_Name"].ToString();
                            int id = Convert.ToInt32(dr["Account_ID"]);
                            int type = Convert.ToInt32(dr["Account_Type_ID"]);
                            Home.UserName = name;
                            Home.Id = id;
                            Home.Type = type;
                            this.DialogResult = DialogResult.OK;
                            //XtraMessageBox.Show("Đăng nhập thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            //XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lbTrangThai.Text = "*Tên đăng nhập hoặc mật khẩu không hợp lệ";
                            txtTenDangNhap.Text = "";
                            txtMatKhau.Text = "";
                            txtTenDangNhap.Focus();
                        }
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

        private void cbxHienMatKhai_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHienMatKhai.Checked)
            {
                this.txtMatKhau.Properties.UseSystemPasswordChar = false;   
            }
            else
            {
                this.txtMatKhau.Properties.UseSystemPasswordChar = true;  
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    Thread.Sleep(100);
            //}
        }

        private void txtTenDangNhap_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtTenDangNhap.Text.Length > 20 || txtTenDangNhap.Text.Length < 5)
            {
                lbTrangThai.Text = "*Tên đăng nhập phải từ 5 đến 20 kí tự";
                txtTenDangNhap.Focus();
            }
        }

        private void txtMatKhau_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtTenDangNhap.Text.Length > 10 || txtTenDangNhap.Text.Length < 4)
            {
                lbTrangThai.Text = "*Mật khẩu phải từ 4 đến 10 kí tự";
                txtTenDangNhap.Focus();
            }
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsSymbol(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
            {
                lbTrangThai.Text = "*Không được phép nhập kí tự đặc biệt";
                e.Handled = true;
            }          
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsSymbol(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
            {
                lbTrangThai.Text = "*Không được phép nhập kí tự đặc biệt";
                e.Handled = true;
            }
        }
    }
}