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
    public partial class ClinienceCost : DevExpress.XtraEditors.XtraForm
    {
        public ClinienceCost()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FillData()
        {
            DataClinienceDataContext db = new DataClinienceDataContext();
            var clinience = db.Cliniences.Where(i => i.Clinience_ID == 1).SingleOrDefault();
            if (clinience != null)
            {
                txtGiaHienTai.Text = Convert.ToString(clinience.Clinience_Cost);
            }
        }
        private void ClinienceCost_Load(object sender, EventArgs e)
        {
            FillData();
            txtGiaHienTai.ReadOnly = true;
            txtGiaMoi.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int cost = Convert.ToInt32(txtGiaMoi.Text);
                BLL_Clinience.UpdateClinienceCost(1, cost);
                this.Close();
                XtraMessageBox.Show("Cập nhật thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi" + ex.Message, "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}