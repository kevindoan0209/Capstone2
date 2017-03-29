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
using ClinienceSystemManagement.HeThong;

namespace ClinienceSystemManagement.Hệ_Thống
{
    public partial class DanhMucThuoc : DevExpress.XtraEditors.XtraForm
    {
        public DanhMucThuoc()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExits(typeof(MedicineDetail));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                MedicineDetail md = new MedicineDetail();
                md.isAdd = true;
                md.ShowDialog();
                sqlDataSource1.Fill();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            sqlDataSource1.Fill();
        }


        private void cmsXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Clinience", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowIndex = gvDanhMuc.FocusedRowHandle;
                string colID = "Medicine_ID";
                object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
                if (value != null)
                {
                    DataClinienceDataContext dc = new DataClinienceDataContext();
                    var medicine = dc.Medicines.Where(s => s.Medicine_ID == (int)value).SingleOrDefault();
                    if (medicine != null)
                    {
                        dc.Medicines.DeleteOnSubmit(medicine);
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

        private void cmsCapNhat_Click(object sender, EventArgs e)
        {
            int rowIndex = gvDanhMuc.FocusedRowHandle;
            string colID = "Medicine_ID";
            object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
            if (value != null)
            {
                MedicineDetail md = new MedicineDetail();
                md.Id = (int)value;
                md.isAdd = false;
                md.ShowDialog();
                sqlDataSource1.Fill();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn đối tượng để cập nhật", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}