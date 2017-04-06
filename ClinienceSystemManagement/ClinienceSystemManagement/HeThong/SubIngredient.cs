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

namespace ClinienceSystemManagement.HeThong
{
    public partial class SubIngredient : DevExpress.XtraEditors.XtraForm
    {
        public SubIngredient()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    // XtraMessageBox.Show("Vui lòng nhập tên thành phần", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lbTrangThai.Text = "*Nhập tên thành phần";
                    txtTen2.Focus();
                }
                else
                {
                    string name = txtTen.Text;
                    string description = txtGhiChu.Text;
                    BLL_Medicine.InsertIngredient(name, description);
                    lbTrangThai.Text = "";
                    this.Close();
                    XtraMessageBox.Show("Đã thêm thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lbTrangThai.Text = "*Mã đối tượng này đã tồn tại";
            }
        }

        private void SubIngredient_Load(object sender, EventArgs e)
        {
            txtMa.ReadOnly = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}