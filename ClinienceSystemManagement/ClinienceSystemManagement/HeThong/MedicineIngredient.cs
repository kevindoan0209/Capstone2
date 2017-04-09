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
    public partial class MedicineIngredient : DevExpress.XtraEditors.XtraForm
    {
        public int Id;
        public bool isAdd = true;
        public MedicineIngredient()
        {
            InitializeComponent();
            sqlDataSource1.Fill();
        }

        private void Reset()
        {
            txtTen.Text = "";
            txtMa.Text = "";
            txtGhiChu.Text = "";
            txtHamLuongTPT.Text = "";
            txtDonVi.Text = "";
            sqlDataSource1.Fill();
        }
        private void FillDataUpdate()
        {
            if (Id != null)
            {
                DataClinienceDataContext db = new DataClinienceDataContext();
                var ing = db.Ingredients.Where(i => i.Ingredient_ID == (int)Id).SingleOrDefault();
                if (ing != null)
                {
                    txtMa.EditValue = ing.Ingredient_ID;
                    txtTen.EditValue = ing.Ingredient_Name;
                    txtGhiChu.EditValue = ing.Ingredient_Note;
                    txtHamLuongTPT.EditValue = ing.Ingredient_Content;
                    txtDonVi.EditValue = ing.Ingredient_Unit;
                    txtMa.ReadOnly = true;
                }
            }
        }
        private void SaveUpdate()
        {
            try
            {
                if (string.IsNullOrEmpty(txtMa.Text))
                {
                    // XtraMessageBox.Show("Vui lòng nhập mã thành phần", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lbTrangThai.Text = "*Vui lòng nhập mã thành phần";
                    txtMa.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtTen.Text))
                    {
                        //XtraMessageBox.Show("Vui lòng nhập tên thành phần", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lbTrangThai.Text = "*Vui lòng nhập tên thành phần";
                        txtTen.Focus();
                    }
                    else
                    {
                        string name = txtTen.Text;
                        string id = txtMa.Text;
                        string description = txtGhiChu.Text;
                        string unit = txtDonVi.Text;
                        double content = Convert.ToDouble(txtHamLuongTPT.Value.ToString());
                        BLL_Medicine.UpdateIngredient(id, name, description, unit, content);
                        Reset();
                        txtMa.ReadOnly = false;
                        isAdd = true;
                        lbTrangThai.Text = "";
                        XtraMessageBox.Show("Cập nhật thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdd == false)
                {
                    SaveUpdate();
                }
                else
                {
                        if (string.IsNullOrEmpty(txtTen.Text))
                        {
                            // XtraMessageBox.Show("Vui lòng nhập tên thành phần", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lbTrangThai.Text = "*Vui lòng nhập tên thành phần";
                            txtTen.Focus();
                        }
                        else
                        {
                            string name = txtTen.Text;
                            string description = txtGhiChu.Text;
                            string unit = txtDonVi.Text;
                            double content = Convert.ToDouble(txtHamLuongTPT.Value.ToString());
                            BLL_Medicine.InsertIngredient(name, description, unit, content);
                            Reset();
                            lbTrangThai.Text = "";
                            XtraMessageBox.Show("Đã thêm thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Mã đối tượng này đã tồn tại");
                lbTrangThai.Text = "*Mã đối tượng này đã tồn tại";
            }
        }

        private void MedicineIngredient_Load(object sender, EventArgs e)
        {
            FillDataUpdate();
            txtMa.ReadOnly = true;
        }

        private void cmsCapNhat_Click(object sender, EventArgs e)
        {
            int rowIndex = gvDanhMuc.FocusedRowHandle;
            string colID = "Ingredient_ID";
            object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
            if (value != null)
            {
                Id = (int)value;
                isAdd = false;
                FillDataUpdate();
                sqlDataSource1.Fill();

            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn đối tượng để cập nhật", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmsXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Clinience", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = gvDanhMuc.FocusedRowHandle;
                    string colID = "Ingredient_ID";
                    object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
                    if (value != null)
                    {
                        DataClinienceDataContext dc = new DataClinienceDataContext();
                        var ing = dc.Ingredients.Where(s => s.Ingredient_ID == (int)value).SingleOrDefault();
                        if (ing != null)
                        {
                            dc.Ingredients.DeleteOnSubmit(ing);
                            dc.SubmitChanges();
                            sqlDataSource1.Fill();
                            XtraMessageBox.Show("Đã xóa thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn đối tượng cần xóa", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Không được phép xóa đối tượng này, đối tượng đã được thêm ở một danh mục khác", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }
    }
}