﻿using System;
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
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource4.Fill();
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
                    XtraMessageBox.Show("Vui lòng nhập tên thuốc", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTen.Focus();
                }
                else
                {
                    if (lkeDonVi.Text == "Chọn đơn vị")
                    {
                        XtraMessageBox.Show("Vui lòng chọn đơn vị", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        XtraMessageBox.Show("Vui lòng nhập tên thuốc", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtTen.Focus();
                    }
                    else
                    {
                        if (lkeDonVi.Text == "Chọn đơn vị")
                        {
                            XtraMessageBox.Show("Vui lòng chọn đơn vị", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}