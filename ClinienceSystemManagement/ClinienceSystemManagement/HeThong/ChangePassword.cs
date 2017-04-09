using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccessLayer;
using BussinessLogicLayer;

namespace ClinienceSystemManagement.HeThong
{
    public partial class ChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public int Id;
        public ChangePassword()
        {
            InitializeComponent();
        }
        public void FillDataUpdate()
        {
            if (Id != 0)
            {
                DataClinienceDataContext db = new DataClinienceDataContext();
                var account = db.Accounts.Where(i => i.Account_ID == (int)Id).SingleOrDefault();
                if (account != null)
                {
                    txtTen.EditValue = account.Account_Name;
                    txtMa.EditValue = account.Account_ID;
                    txtMa.ReadOnly = true;
                    txtTen.ReadOnly = true;
                }
            }
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                    if (string.IsNullOrEmpty(txtMatKhau.Text))
                    {
                        lbTrangThai.Text = "*Nhập mật khẩu";
                        txtMatKhau.Focus();
                    }
                    else
                    {
                        if (txtMatKhau.Text != txtMatKhau2.Text)
                        {
                            // XtraMessageBox.Show("Mật khẩu không trùng khớp", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lbTrangThai.Text = "*Mật khẩu không trùng khớp";
                            txtMatKhau2.Focus();
                        }
                        else
                        {
                            int id = Int32.Parse(txtMa.Text);
                            string name = txtTen.Text;
                            string password = txtMatKhau.Text;
                            BLL_Human.UpdateAccountPassword(id, name, password);
                            this.Close();
                            XtraMessageBox.Show("Đổi mật khẩu thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            FillDataUpdate();
        }

        private void cbxHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHienMatKhau.Checked)
            {
                this.txtMatKhau.Properties.UseSystemPasswordChar = false;
                this.txtMatKhau2.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMatKhau.Properties.UseSystemPasswordChar = true;
                this.txtMatKhau2.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}