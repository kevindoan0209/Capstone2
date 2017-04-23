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
using BussinessLogicLayer;

namespace ClinienceSystemManagement.KhamBenh
{
    public partial class ClinienceDetail : DevExpress.XtraEditors.XtraForm
    {
        public ClinienceDetail()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    lbTrangThai.Text = "*Vui lòng nhập tên";
                    txtTen.Focus();
                }
                else
                {
                    String name = Convert.ToString(txtTen.Text);
                    String tel = Convert.ToString(txtDienThoai.Text);
                    String address = Convert.ToString(txtDiaChi.Text);
                    String email = Convert.ToString(txtEmail.Text);
                    String fax = Convert.ToString(txtFax.Text);
                    int cost  = Convert.ToInt32(txtGia.Text);
                    BLL_Clinience.UpdateClinience(name, tel, email,address, fax, cost,1);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi" + ex.Message, "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ClinienceDetail_Load(object sender, EventArgs e)
        {

        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}