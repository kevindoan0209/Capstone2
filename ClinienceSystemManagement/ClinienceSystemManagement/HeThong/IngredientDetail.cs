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
    public partial class IngredientDetail : DevExpress.XtraEditors.XtraForm
    {
        public int Id;
        public bool isAdd = true;
        public IngredientDetail()
        {
            InitializeComponent();
            sqlDataSource4.Fill();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //     if (isAdd == false)
                //   {
                //       SaveUpdate();
                //   }
                //    else
                //   {
                if (string.IsNullOrEmpty(lkeThanhPhan.Text))
                {
                    XtraMessageBox.Show("Vui lòng nhập mã bệnh", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lkeThanhPhan.Focus();
                }
                else
                {
                    int medicineId = 25;
                    string group = lkeThanhPhan.GetColumnValue("Ingredient_ID").ToString();
                    int ingredientId = Int32.Parse(group);
                    string unit = txtDonVi.Text;
                    double content = Convert.ToDouble(txtHamLuongTPT.Value.ToString());
                    BLL_Medicine.InsertMeIn(medicineId, ingredientId, unit, content);
                    XtraMessageBox.Show("Đã thêm thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                //  }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", ex.Message);
            }
        }
    }
}