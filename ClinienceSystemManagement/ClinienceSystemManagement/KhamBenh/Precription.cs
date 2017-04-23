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

namespace ClinienceSystemManagement.KhamBenh
{
    public partial class Precription : DevExpress.XtraEditors.XtraForm
    {
        public int Id;
        public int nDisPre = 0;
        public String[] _getCheckedDiseasePre = new String[1000000];
        public Precription()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
            sqlDataSource3.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource4.Fill();
        }


        private void FillDataUpdate()
        {
            if (Id != 0)
            {
                DataClinienceDataContext db = new DataClinienceDataContext();
                var precription = db.Precriptions.Where(i => i.Precription_ID == Id).SingleOrDefault();
               // var precription_disease = db.Precription_Diseases.Where(i => i.Precription_ID == Id).ToArray();
                if (precription != null)
                {
                    txtMa.EditValue = precription.Precription_ID;
                    txtMa.ReadOnly = true;
                    lbKhamThucThe.Text = precription.Precription_Checkup;
                    lbChanDoan.Text = precription.Precription_Diagnose;
                    for (int i = 0; i < nDisPre; i++)
                    {
                        String diseaseId = _getCheckedDiseasePre[i];
                        lbMaBenh.Text = lbMaBenh.Text +", "+ diseaseId;
                    }

                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Reset()
        {
            lkeTenThuoc.Text = "";
            txtSoLuong.Text = "";
            txtChiDan.Text = "";
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (lkeTenThuoc.Text == "Chọn thuốc")
                {
                    lkeTenThuoc.Focus();
                    lbTrangThai.Text = "*Vui lòng chọn thuốc";
                }
                else
                {
                    if (txtSoLuong.Value.ToString() == "0" || txtSoLuong.Value < 0)
                    {              
                        lbTrangThai.Text = "*Vui lòng vào nhập số lượng";
                        txtSoLuong.Focus();
                    }
                    else
                    {
                        string group = lkeTenThuoc.GetColumnValue("Medicine_ID").ToString();
                        int medicineId = Convert.ToInt32(group);
                        DataClinienceDataContext db = new DataClinienceDataContext();
                        var medicine = db.Medicines.Where(i => i.Medicine_ID == medicineId).SingleOrDefault();
                        int price = Convert.ToInt32(medicine.Medicine_Price);
                        int quantity = Convert.ToInt32(txtSoLuong.Value.ToString());
                        String note = Convert.ToString(txtChiDan.Text);
                        int amout = (quantity * price);
                        int money = BLL_Precription.GetTotalMoney(Id);
                        lbTien.Text = Convert.ToString(money);
                        BLL_Precription.InsertPrecriptionMedicine(Id, medicineId, quantity, note, amout);
                        sqlDataSource3.Fill();
                        Reset();
                    }
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Thuốc này đã được thêm vào toa", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Precription_Load(object sender, EventArgs e)
        {
            FillDataUpdate();
            String preId = Convert.ToString(txtMa.Text);
            String filter = "[Precription_ID] ='" + preId + "'";
            gvDanhMuc.ActiveFilterString = filter;
            gvDiUng.ActiveFilterString = filter;
            int money = BLL_Precription.GetTotalMoney(Id);
            lbTien.Text = Convert.ToString(money);
        }

        private void cmsXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Clinience", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = gvDanhMuc.FocusedRowHandle;
                    string colID = "Medicine_ID";
                    object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
                    if (value != null)
                    {
                        int medicineId = (int)value;
                        BLL_Precription.DeletePrecriptionMedicine(medicineId,Id);
                        sqlDataSource3.Fill();
                        int money = BLL_Precription.GetTotalMoney(Id);
                        lbTien.Text = Convert.ToString(money);
                        XtraMessageBox.Show("Đã xóa thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int money = BLL_Precription.GetTotalMoney(Id);
                BLL_Precription.UpdatePrecriptionMoney(money, Id);
                String treatment = Convert.ToString(txtDieuTri.Text);
                BLL_Precription.UpdateTreatment(treatment, Id);
                this.Close();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lỗi: ", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiUng_Click(object sender, EventArgs e)
        {
            Allergic al = new Allergic();
            al.Id = (int)Id;
            al.Show();
            sqlDataSource4.Fill();
        }

        private void csmXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Clinience", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = gvDiUng.FocusedRowHandle;
                    string colID = "Allergic_ID";
                    object value = gvDiUng.GetRowCellValue(rowIndex, colID);
                    if (value != null)
                    {
                        DataClinienceDataContext dc = new DataClinienceDataContext();
                        var allregic = dc.Allergics.Where(s => s.Allergic_ID == (int)value).SingleOrDefault();
                        if (allregic != null)
                        {
                            dc.Allergics.DeleteOnSubmit(allregic);
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
                XtraMessageBox.Show("Không được phép xóa đối tượng này, đối tượng đã được thêm ở một danh mục khác", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sqlDataSource4.Fill();
        }
    }
}