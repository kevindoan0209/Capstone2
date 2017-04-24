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
    public partial class Examination : DevExpress.XtraEditors.XtraForm
    {
        public int Id;
        // public bool isAdd = true;
        public Examination()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource2.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource3.Fill();
        }

        private void PatientDetail_Load(object sender, EventArgs e)
        {
            dtNgayBatDau.EditValue = DateTime.Now;
            dtNgayKetThuc.EditValue = DateTime.Now;
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
        MainExamination ex = new MainExamination();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
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
                    else
                    {
                        if (dtNgayBatDau.DateTime >= dtNgayKetThuc.DateTime)
                        {
                            lbTrangThai.Text = "*Vui lòng chọn thời gian";
                            dtNgayKetThuc.Focus();
                        }
                        else
                        {
                            DateTime beginDate = dtNgayBatDau.DateTime;
                            DateTime endDate = dtNgayKetThuc.DateTime;
                            String reason = txtLyDo.Text;
                            String complain = txtThanPhien.Text;
                            string group = lkeBacSi.GetColumnValue("Account_ID").ToString();
                            int doctorId = Convert.ToInt32(group);
                            string group2 = lkeBenhNhan.GetColumnValue("Account_ID").ToString();
                            int patientId = Convert.ToInt32(group2);
                            BLL_Appointment.InsertNewAppointment(beginDate, endDate, reason, complain, patientId, doctorId);
                            String note = "";
                            DateTime date = DateTime.Now;
                            int money = 0;
                            BLL_Precription.InsertNewPrecription(note, date, money, patientId, doctorId);
                            int lastPreID = BLL_Precription.GetLastIdPrecription();
                            this.Close();
                            ex.PreId = (int)lastPreID;
                            ex.Id = (int)patientId;
                            ex.openForm = false;
                            ex.doctorId = (int)doctorId;
                            ex.FillData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message);
            }
        }
    }
}