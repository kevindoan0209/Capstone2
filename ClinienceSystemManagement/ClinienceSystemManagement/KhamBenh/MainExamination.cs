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
using ClinienceSystemManagement.HeThong;

namespace ClinienceSystemManagement.KhamBenh
{
    public partial class MainExamination : DevExpress.XtraEditors.XtraForm
    {
        public int Id;
        public int doctorId;
        public int AppointmentId;
        public MainExamination()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource2.Fill();
        }
        public void FillData()
        {
            if (Id != 0)
            {
                DataClinienceDataContext db = new DataClinienceDataContext();
                var account = db.Accounts.Where(i => i.Account_ID == Id).SingleOrDefault();
                var human = db.Humans.Where(i => i.Account_ID == Id).SingleOrDefault();
                var patient = db.Patients.Where(i => i.Account_ID == Id).SingleOrDefault();
                int lastID = BLL_Appointment.GetLastIdAppointment();
                var appointment = db.Appointmentsses.Where(i => i.Appointment_ID == lastID).SingleOrDefault();  
                if (account != null)
                {
                    lbTen.Text = account.Account_Name;
                    lbDiaChi.Text = human.Account_Address;
                    lbEmail.Text = human.Account_Email;
                    lbThanhPho.Text = human.Account_City;
                    lbSoDienThoai.Text = human.Account_Phone;
                    lbGioiTinh.Text = human.Account_Sex;
                    txtLyDo.EditValue = appointment.Appointment_Issue;
                    txtThanPhien.EditValue = appointment.Appointment_Complain;
                    lbNgayKham.Text = Convert.ToString(appointment.Appointment_StartDate);
                    int DoctorId = appointment.Account_ID_Doctor;
                    String name = BLL_Appointment.GetNameDoctor(DoctorId);
                    lbBacSi.Text = name;
                    DateTime age = Convert.ToDateTime(human.Account_Age);
                    int ageInYrs = DateTime.Now.Year - age.Year;
                    lbTuoi.Text = ageInYrs + " tuổi";
                    lbCongViec.Text = human.Account_Job;
                    peAnh.EditValue = account.Account_Image;
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
        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExits(typeof(Examination));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Examination ex = new Examination();
               // ex.MdiParent = this;
                ex.Show();
            }
        }

        private void MainExamination_Load(object sender, EventArgs e)
        {
            FillData();
            textEdit2.ReadOnly = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
            
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
                SubPatientDetail sp = new SubPatientDetail();
                sp.Id = (int)Id;
                sp.ShowDialog();
        }
        private void Reset()
        {
            txtThanNhiet.Text = "";
            txtHuyetThu.Text = "";
            txtHuyetTr.Text = "";
            txtMach.Text = "";
            txtNhipTho.Text = "";
            txtCanNang.Text = "";
            txtChieuCao.Text = "";
            txtVong2.Text = "";
            txtVong3.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                {
                    XtraMessageBox.Show("Chưa có thông tin bệnh nhân", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTiepNhan.Focus();
                }
                else
                {
                    int temp = Convert.ToInt32(txtThanNhiet.Value.ToString());
                    int bloodTh = Convert.ToInt32(txtHuyetThu.Value.ToString());
                    int bloodTr = Convert.ToInt32(txtHuyetTr.Value.ToString());
                    int pulse = Convert.ToInt32(txtMach.Value.ToString());
                    int breath = Convert.ToInt32(txtNhipTho.Value.ToString());
                    int weight = Convert.ToInt32(txtCanNang.Value.ToString());
                    int height = Convert.ToInt32(txtChieuCao.Value.ToString());
                    int waist = Convert.ToInt32(txtVong2.Value.ToString());
                    int hip = Convert.ToInt32(txtVong3.Value.ToString());
                    String reason = Convert.ToString(txtLyDo.Text);
                    String complain = Convert.ToString(txtThanPhien.Text);
                    int lastID = BLL_Appointment.GetLastIdAppointment();
                    BLL_Appointment.UpdateAppointment(lastID, reason, complain);
                    BLL_Patient.UpdatePatient(Id, temp, bloodTh, bloodTr, pulse, breath, weight, height, waist, hip);
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    String note = "";
                    DateTime date = DateTime.Now;
                    int money = 0;
                    BLL_Precription.InsertNewPrecription(note, date, money, Id, doctorId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message);
            }
        }

        private void lnkThemBenh_Click(object sender, EventArgs e)
        {
            DiseaseDetail dd = new DiseaseDetail();
            dd.ShowDialog();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            textEdit2.Text = "Đã có toa thuốc";
        }
    }
}