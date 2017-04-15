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
using BussinessLogicLayer;
using DataAccessLayer;

namespace ClinienceSystemManagement.KhamBenh
{
    public partial class SubExamination : DevExpress.XtraEditors.XtraForm
    {
        public int Id;
        public bool isAdd = true;
        public SubExamination()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource2.Fill();
        }

        private void PatientDetail_Load(object sender, EventArgs e)
        {
            txtMa.ReadOnly = true;
            FillDataUpdate();
        }
        private void FillDataUpdate()
        {
            if (Id != 0)
            {
                DataClinienceDataContext db = new DataClinienceDataContext();
                var account = db.Accounts.Where(i => i.Account_ID == Id).SingleOrDefault();
                if (account != null)
                {
                    txtMa.EditValue = account.Account_ID;
                    txtTen.Text = account.Account_Name;                     
                    txtMa.ReadOnly = true;
                }
            }
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

        private void btnLuu_Click(object sender, EventArgs e)
        {

                if (string.IsNullOrEmpty(txtLyDo.Text))
                {
                    lbTrangThai.Text = "*Vui lòng nhập lí do khám";
                    txtLyDo.Focus();
                }
                else
                {
                    if (lkeBacSi.Text == "Bác sĩ")
                    {
                        lbTrangThai.Text = "*Vui lòng chọn bác sĩ";
                        lkeBacSi.Focus();
                    }
                    else {
                        DateTime beginDate = dtNgayBatDau.DateTime;
                        DateTime endDate = dtNgayKetThuc.DateTime;
                        String reason = txtLyDo.Text;
                        String complain = txtThanPhien.Text;
                        int patientId = Convert.ToInt32(txtMa.Text);
                        string group = lkeBacSi.GetColumnValue("Account_ID").ToString();
                        int doctorId = Convert.ToInt32(group);
                        BLL_Appointment.InsertNewAppointment(beginDate, endDate, reason, complain, patientId, doctorId);
                        XtraMessageBox.Show("Tạo phiên khám thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Form frm = this.IsExits(typeof(MainExamination));
                        if (frm != null)
                        {
                            frm.Activate();
                        }
                        else
                        {
                            MainExamination me = new MainExamination();
                           // me.MdiParent = this;
                            me.Show();
                        }
                    }
                }
            

        }
    }
}