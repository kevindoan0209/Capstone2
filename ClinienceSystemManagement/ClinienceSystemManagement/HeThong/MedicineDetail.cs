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
    public partial class MedicineDetail : DevExpress.XtraEditors.XtraForm
    {
        public int Id;
        public bool isAdd = true;
        public MedicineDetail()
        {
            InitializeComponent();
            sqlDataSource4.Fill();
        }

        private Form IsExits(Type type)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == type)
                {
                    return f;
                }
            }
            return null;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MedicineDetail_Load(object sender, EventArgs e)
        {
            FillDataUpdate();
            txtMa.ReadOnly = true;
            if (isAdd == true)
            {
                txtGia.Text = "0";
            }
        }
        public void FillDataUpdate()
        {
            if (Id != 0)
            {
                DataClinienceDataContext db = new DataClinienceDataContext();
                var medicines = db.Medicines.Where(i => i.Medicine_ID == (int)Id).SingleOrDefault();
                if (medicines != null)
                {
                    txtTen.EditValue = medicines.Medicine_Name;
                    txtLopThuoc.EditValue = medicines.Medicine_Class;
                    txtSuDung.EditValue = medicines.Medicine_Usage;
                    txtGhiChu.EditValue = medicines.Medicine_Note;
                    txtGia.EditValue = medicines.Medicine_Price;
                    txtMa.EditValue = medicines.Medicine_ID;
                    lkeDonVi.EditValue = medicines.Unit_ID;
                    txtMa.ReadOnly = true;
                }
            }
        }
        private void SaveUpdate()
        {
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    //XtraMessageBox.Show("Vui lòng nhập tên thuốc", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lbTrangThai.Text = "*Vui lòng nhập tên thuốc";
                    txtTen.Focus();
                }
                else
                {
                    if (lkeDonVi.Text == "Chọn đơn vị")
                    {
                        //XtraMessageBox.Show("Vui lòng chọn đơn vị", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lbTrangThai.Text = "*Vui lòng chọn đơn vị";
                        lkeDonVi.Focus();
                    }
                    else
                    {
                        int id = Int32.Parse(txtMa.Text);
                        string name = txtTen.Text;
                        string mclass = txtLopThuoc.Text;
                        string usage = txtSuDung.Text;
                        string note = txtGhiChu.Text;
                        int price = Int32.Parse(txtGia.Text);
                        string group = lkeDonVi.GetColumnValue("Unit_ID").ToString();
                        int unitid = Int32.Parse(group);
                        BLL_Medicine.UpdateMedicine(id, name, mclass, usage, note, price, unitid);
                        this.Close();
                        XtraMessageBox.Show("Cập nhật thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
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
                        //XtraMessageBox.Show("Vui lòng nhập tên thuốc", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lbTrangThai.Text = "*Vui lòng nhập tên thuốc";
                        txtTen.Focus();
                    }
                    else
                    {
                        if (lkeDonVi.Text == "Chọn đơn vị")
                        {
                            //XtraMessageBox.Show("Vui lòng chọn đơn vị", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lbTrangThai.Text = "*Vui lòng chọn đơn vị";
                            lkeDonVi.Focus();
                        }
                        else
                        {
                            string name = txtTen.Text;
                            string mclass = txtLopThuoc.Text;
                            string usage = txtSuDung.Text;
                            string note = txtGhiChu.Text;
                            int price = Int32.Parse(txtGia.Text);
                            string group = lkeDonVi.GetColumnValue("Unit_ID").ToString();
                            int unitid = Convert.ToInt32(group);
                            BLL_Medicine.InsertMedicine(name, mclass, usage, note, price, unitid);
                            this.Close();
                            XtraMessageBox.Show("Đã thêm thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void csmThem_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExits(typeof(IngredientDetail));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                IngredientDetail id = new IngredientDetail();
                id.isAdd = true;
                id.ShowDialog();
                sqlDataSource4.Fill();
            }
        }

        private void csmCapNhat_Click(object sender, EventArgs e)
        {
            int rowIndex = gvDanhMuc.FocusedRowHandle;
            string colID = "Account_ID";
            object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
            if (value != null)
            {
                HumanDetail md = new HumanDetail();
                md.Id = (int)value;
                md.isAdd = false;
                md.ShowDialog();
                sqlDataSource4.Fill();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn đối tượng để cập nhật", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void csmXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Clinience", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = gvDanhMuc.FocusedRowHandle;
                    string colID = "Account_ID";
                    object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
                    if (value != null)
                    {
                        DataClinienceDataContext dc = new DataClinienceDataContext();
                        var account = dc.Accounts.Where(s => s.Account_ID == (int)value).SingleOrDefault();
                        if (account != null)
                        {
                            dc.Accounts.DeleteOnSubmit(account);
                            dc.SubmitChanges();
                            sqlDataSource4.Fill();
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
                XtraMessageBox.Show("Không được phép xóa đối tượng này, đối tượng đã được thêm ở một danh mục khác", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkChon_CheckedChanged(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Không được phép xóa đối tượng này, đối tượng đã được thêm ở một danh mục khác", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void gvDanhMuc_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int rowIndex = gvDanhMuc.FocusedRowHandle;
            string colID = "Ingredient_ID";
            object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
            if (value != null)
            {
                DataClinienceDataContext dc = new DataClinienceDataContext();
                var ingredient = dc.Ingredients.Where(s => s.Ingredient_ID == (int)value).SingleOrDefault();
                if (ingredient != null)
                {
                    try
                    {
                        int medicineId = 25;
                        int ingredientId = ingredient.Ingredient_ID;
                        string unit = "";
                        double content = 10;
                        BLL_Medicine.InsertMeIn(medicineId, ingredientId, unit, content);
                        XtraMessageBox.Show("Đã thêm thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("Mã đối tượng này đã được thêm", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}