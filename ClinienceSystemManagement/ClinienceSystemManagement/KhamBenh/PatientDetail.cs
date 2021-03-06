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
    public partial class PatientDetail : DevExpress.XtraEditors.XtraForm
    {
        public int Id;
        public bool isAdd = true;
        public PatientDetail()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }

        private void PatientDetail_Load(object sender, EventArgs e)
        {
            txtMa.ReadOnly = true;
            dtNgayBatDau.EditValue = DateTime.Now;
            dtNgayKetThuc.EditValue = DateTime.Now;
            FillDataUpdate();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void peAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                openFileDialog.FilterIndex = 4;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtAnh.Text = openFileDialog.FileName;
                    peAnh.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Không thể tải được ảnh", ex.Message);
            }
        }
        private void FillDataUpdate()
        {
            if (Id != 0)
            {
                DataClinienceDataContext db = new DataClinienceDataContext();
                var account = db.Accounts.Where(i => i.Account_ID == Id).SingleOrDefault();
                var human = db.Humans.Where(i => i.Account_ID == Id).SingleOrDefault();
                var patient = db.Patients.Where(i => i.Account_ID == Id).SingleOrDefault();
                //  var appointment = db.Appointmentsses.Where(i => i.Account_ID_Patient == Id).SingleOrDefault();
                // var patientstatus = db.PatientStatus.Where(i => i.Account_ID == Id).SingleOrDefault();
                if (account != null)
                {
                    txtMa.EditValue = account.Account_ID;
                    txtTen.EditValue = account.Account_Name;
                    txtDiaChi.EditValue = human.Account_Address;
                    txtEmail.EditValue = human.Account_Email;
                    txtThanhPho.EditValue = human.Account_City;
                    txtSDT.EditValue = human.Account_Phone;
                    //  txtLyDo.EditValue = appointment.Appointment_Issue;
                    // txtThanPhien.EditValue = appointment.Appointment_Complain;
                    dtNamSinh.EditValue = human.Account_Age;
                    txtNgheNghiep.EditValue = human.Account_Job;
                    string sex = human.Account_Sex;
                    if (sex == "Nam")
                    {
                        rbNam.Checked = true;
                    }
                    else
                    {
                        rbNu.Checked = true;
                    }
                    peAnh.EditValue = account.Account_Image;
                    txtMa.ReadOnly = true;
                    txtLyDo.ReadOnly = true;
                    txtThanPhien.ReadOnly = true;
                    txtLyDo.Text = "";
                    txtThanPhien.Text = "";
                }
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    lbTrangThai.Text = "*Vui lòng nhập họ và tên";
                    txtTen.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(dtNamSinh.Text))
                    {
                        lbTrangThai.Text = "*Vui chọn ngày /tháng /năm sinh";
                        txtTen.Focus();
                    }
                    else
                    {
                        if (rbNam.Checked == false && rbNu.Checked == false)
                        {
                            lbTrangThai.Text = "*Vui lòng chọn giới tính";
                        }
                        else
                        {

                            string name = txtTen.Text;
                            string image = txtAnh.Text;
                            //DateTime age = DateTime.Parse(dtNamSinh.Text);
                            string sex;
                            if (rbNam.Checked == true)
                            {
                                sex = "Nam";
                            }
                            else
                            {
                                sex = "Nữ";
                            }
                            string phone = txtSDT.Text;
                            string email = txtEmail.Text;
                            string job = txtNgheNghiep.Text;
                            string address = txtDiaChi.Text;
                            string city = txtThanhPho.Text;
                            DateTime age = dtNamSinh.DateTime;
                            if (string.IsNullOrEmpty(txtAnh.Text))
                            {
                                BLL_Human.InsertAccountPatientNoImage(name);
                                int lastID = BLL_Human.GetLastIdAccount();
                                BLL_Human.InsertHumanPatient(lastID, age, sex, email, phone, job, city, address);
                                BLL_Patient.InsertPatientNoValue(lastID);
                                XtraMessageBox.Show("Đã thêm thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                BLL_Human.InsertAccountPatient(name, image);
                                int lastID = BLL_Human.GetLastIdAccount();
                                BLL_Human.InsertHumanPatient(lastID, age, sex, email, phone, job, city, address);
                                BLL_Patient.InsertPatientNoValue(lastID);
                                XtraMessageBox.Show("Đã thêm thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    lbTrangThai.Text = "*Vui lòng nhập họ và tên";
                    txtTen.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(dtNamSinh.Text))
                    {
                        lbTrangThai.Text = "*Vui chọn ngày /tháng /năm sinh";
                        txtTen.Focus();
                    }
                    else
                    {
                        if (rbNam.Checked == false && rbNu.Checked == false)
                        {
                            lbTrangThai.Text = "*Vui lòng chọn giới tính";
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtLyDo.Text))
                            {
                                lbTrangThai.Text = "*Vui lòng nhập lý do khám";
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
                                        string name = txtTen.Text;
                                        string image = txtAnh.Text;
                                        //DateTime age = DateTime.Parse(dtNamSinh.Text);
                                        string sex;
                                        if (rbNam.Checked == true)
                                        {
                                            sex = "Nam";
                                        }
                                        else
                                        {
                                            sex = "Nữ";
                                        }
                                        string phone = txtSDT.Text;
                                        string email = txtEmail.Text;
                                        string job = txtNgheNghiep.Text;
                                        string address = txtDiaChi.Text;
                                        string city = txtThanhPho.Text;
                                        DateTime age = dtNamSinh.DateTime;
                                        string reason = txtLyDo.Text;
                                        string complain = txtThanPhien.Text;
                                        string group = lkeBacSi.GetColumnValue("Account_ID").ToString();
                                        int doctorId = Convert.ToInt32(group);
                                        DateTime beginDate = dtNgayBatDau.DateTime;
                                        DateTime endDate = dtNgayKetThuc.DateTime;

                                        if (string.IsNullOrEmpty(txtAnh.Text))
                                        {

                                            BLL_Human.InsertAccountPatientNoImage(name);
                                            int lastID = BLL_Human.GetLastIdAccount();
                                            BLL_Human.InsertHumanPatient(lastID, age, sex, email, phone, job, city, address);
                                            BLL_Patient.InsertPatientNoValue(lastID);
                                            BLL_Appointment.InsertNewAppointment(beginDate, endDate, reason, complain, lastID, doctorId);
                                            int lastAppointId = BLL_Appointment.GetLastIdAppointment();
                                            string label = "Khám bệnh: " + name;
                                            BLL_Appointment.InsertSchedule(beginDate, endDate, label,lastAppointId);
                                            String note = "";
                                            DateTime date = DateTime.Now;
                                            int money = 0;
                                            BLL_Precription.InsertNewPrecription(note, date, money, lastID, doctorId);
                                            int lastPreID = BLL_Precription.GetLastIdPrecription();
                                            XtraMessageBox.Show("Đã thêm thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                            MainExamination ex = new MainExamination();
                                            ex.PreId = (int)lastPreID;
                                            ex.Id = (int)lastID;
                                            ex.openForm = false;
                                            ex.Show();
                                        }
                                        else
                                        {
                                            BLL_Human.InsertAccountPatient(name, image);
                                            int lastID = BLL_Human.GetLastIdAccount();
                                            BLL_Human.InsertHumanPatient(lastID, age, sex, email, phone, job, city, address);
                                            BLL_Patient.InsertPatientNoValue(lastID);
                                            BLL_Appointment.InsertNewAppointment(beginDate, endDate, reason, complain, lastID, doctorId);
                                            int lastAppointId = BLL_Appointment.GetLastIdAppointment();
                                            string label = "Khám bệnh: " + name;
                                            BLL_Appointment.InsertSchedule(beginDate, endDate, label, lastAppointId);
                                            String note = "";
                                            DateTime date = DateTime.Now;
                                            int money = 0;
                                            BLL_Precription.InsertNewPrecription(note, date, money, lastID, doctorId);
                                            int lastPreID = BLL_Precription.GetLastIdPrecription();
                                            XtraMessageBox.Show("Đã thêm thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                            MainExamination ex = new MainExamination();
                                            ex.PreId = (int)lastPreID;
                                            ex.Id = (int)lastID;
                                            ex.openForm = false;
                                            ex.Show();
                                        }
                                    }
                                }
                            }
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