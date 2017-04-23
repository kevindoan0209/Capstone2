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
using DataAccessLayer;

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

        private void FillData()
        {
            DataClinienceDataContext db = new DataClinienceDataContext();
            var clinience = db.Cliniences.Where(i => i.Clinience_ID == 1).SingleOrDefault();
            if (clinience != null)
            {
                txtTen.Text = clinience.Clinience_Name;
                txtFax.Text = clinience.Clinience_Fax;
                txtEmail.Text = clinience.Clinience_Email;
                txtDiaChi.Text = clinience.Clinience_Address;
                txtDienThoai.Text = clinience.Clinience_Tel;
                txtGia.Text = Convert.ToString(clinience.Clinience_Cost);
            }
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
                    if (txtGia.Text == "0")
                    {
                        lbTrangThai.Text = "*Vui lòng nhập giá khám";
                        txtGia.Focus();
                    }
                    else
                    {
                        String name = Convert.ToString(txtTen.Text);
                        String tel = Convert.ToString(txtDienThoai.Text);
                        String address = Convert.ToString(txtDiaChi.Text);
                        String email = Convert.ToString(txtEmail.Text);
                        String fax = Convert.ToString(txtFax.Text);
                        int cost = Convert.ToInt32(txtGia.Text);
                        BLL_Clinience.UpdateClinience(name, tel, email, address, fax, cost, 1);
                        this.Close();
                        XtraMessageBox.Show("Cập nhật thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi" + ex.Message, "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ClinienceDetail_Load(object sender, EventArgs e)
        {
            FillData();
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