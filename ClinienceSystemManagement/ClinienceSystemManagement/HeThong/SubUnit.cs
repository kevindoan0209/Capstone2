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
    public partial class SubUnit : DevExpress.XtraEditors.XtraForm
    {
        public SubUnit()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                    if (string.IsNullOrEmpty(txtTen.Text))
                    {
                        //XtraMessageBox.Show("Vui lòng nhập tên đơn vị", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lbTrangThai.Text = "*Nhập tên đơn vị";
                        txtTen.Focus();
                    }
                    else
                    {
                        string name = txtTen.Text;
                        string description = txtGhiChu.Text;
                        BLL_Medicine.InsertUnit(name, description);
                        lbTrangThai.Text = "";
                        this.Close();
                        XtraMessageBox.Show("Đã thêm thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SubUnit_Load(object sender, EventArgs e)
        {
            txtMa.ReadOnly = true;
        }
    }
}