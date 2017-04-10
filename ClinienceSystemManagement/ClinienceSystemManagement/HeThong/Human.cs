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

namespace ClinienceSystemManagement.HeThong
{
    public partial class Human : DevExpress.XtraEditors.XtraForm
    {
        public Human()
        {
            InitializeComponent();
            sqlDataSource9.Fill();
          
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
            Form frm = this.IsExits(typeof(HumanDetail));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                HumanDetail hd = new HumanDetail();
                hd.isAdd = true;
                hd.ShowDialog();
                sqlDataSource9.Fill();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            sqlDataSource9.Fill();
        }

        private void cmsCapNhat_Click(object sender, EventArgs e)
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
                sqlDataSource9.Fill();
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
                            sqlDataSource9.Fill();
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