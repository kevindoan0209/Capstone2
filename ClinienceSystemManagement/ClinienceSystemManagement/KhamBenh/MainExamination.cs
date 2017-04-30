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
using DevExpress.XtraReports;
using CrystalDecisions.Windows.Forms;

namespace ClinienceSystemManagement.KhamBenh
{
    public partial class MainExamination : DevExpress.XtraEditors.XtraForm
    {
        public int Id;
        public int doctorId;
        public int AppointmentId;
        public int PreId;
        private String[] _getCheckedDisease = new String[1000000];
        private String[] _getCheckedPara = new String[1000000];
        private int nDis = 0;
        private int nPara = 0;
        private bool _checkExistingDis = false;
        private bool _checkExistingPara = false;
        public Boolean openForm = true;
        public MainExamination()
        {
            InitializeComponent();


            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource5.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource6.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource7.Fill();
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
                    txtThanNhiet.EditValue = patient.Patient_Temperature;
                    txtHuyetThu.EditValue = patient.Patient_BloodPressureThu;
                    txtHuyetTr.EditValue = patient.Patient_BloodPressureTr;
                    txtMach.EditValue = patient.Patient_Pulse;
                    txtNhipTho.EditValue = patient.Patient_Breathing;
                    txtChieuCao.EditValue = patient.Patient_Height;
                    txtCanNang.EditValue = patient.Patient_Weight;
                    txtVong2.EditValue = patient.Patient_Waist;
                    txtVong3.EditValue = patient.Patient_Hips;
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
        public void Disable(Boolean turn)
        {
            panelControl4.Enabled = turn;
            panelControl1.Enabled = turn;
        }
        private void MainExamination_Load(object sender, EventArgs e)
        {
            if (openForm == true)
            {
                FillData();
                txtToaThuoc.ReadOnly = true;
                Disable(false);
            }
            else
            {
                FillData();
                txtToaThuoc.ReadOnly = true;
                Disable(true);
            }
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
            txtLuuY.Text = "";
            txtChanDoan.Text = "";
            txtKhamThucThe.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                {
                    lbTrangThai.Text = "*Chưa có thông tin bệnh nhân";
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
                    String note = Convert.ToString(txtLuuY.Text);
                    String diagnose = Convert.ToString(txtChanDoan.Text);
                    String checkup = Convert.ToString(txtKhamThucThe.Text);
                    DateTime date = DateTime.Now;
                    int money = 0;
                    BLL_Precription.UpdatePrecription(PreId,note, date, money, diagnose, checkup, Id, doctorId);
                    for (int i = 0; i < nDis; i++)
                    {
                        String diseaseId = _getCheckedDisease[i];
                        BLL_Precription.InsertPrecriptionDisease(diseaseId, PreId);
                    }

                    for (int i = 0; i < nPara; i++)
                    {
                        String paraId = _getCheckedPara[i];
                        BLL_Precription.InsertPrecriptionParaclinical(paraId, PreId);
                    }
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    XtraMessageBox.Show("Cập nhật bệnh án thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void lnkThemBenh_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                DiseaseDetail dd = new DiseaseDetail();
                dd.ShowDialog();
            }
            else
            {
                lbTrangThai.Text = "*Chưa có thông tin bệnh nhân";
                btnTiepNhan.Focus();
            }
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            if (btnLuu.Enabled == true)
            {
                lbTrangThai.Text = "*Vui lòng cập nhật thông tin bệnh án";
                btnLuu.Focus();
            }
            else
            {
                if (Id != 0)
                {
                    Form frm = this.IsExits(typeof(Precription));
                    if (frm != null)
                    {
                        frm.Activate();
                    }
                    else
                    {
                        txtToaThuoc.Text = "Đã có toa thuốc";
                        Precription ex = new Precription();
                        ex.Id = (int)PreId;
                        ex._getCheckedDiseasePre = _getCheckedDisease;
                        ex.nDisPre = nDis;
                        ex.Show();
                    }
                }
                else
                {
                    lbTrangThai.Text = "*Chưa có thông tin bệnh nhân";
                }
            }
        }
        private int findValueOfArrary(String[] a, int n, String x)
        {
            for (int i = 0; i < n; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }
        private void deleteValueOfArray(String[] a, int n, String x)
        {
            int vt = findValueOfArrary(a, n, x);
            if (vt == -1)
                XtraMessageBox.Show("Lỗi", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                for (int i = vt; i < (n - 1); i++)
                    a[i] = a[i + 1];
                //n--;
            }
        }

        private void gvDanhMuc_SelectionChanged_1(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int rowIndex = gvDanhMuc.FocusedRowHandle;
            string colID = "Paraclinical_ID";
            object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
            if (value != null)
            {
                DataClinienceDataContext dc = new DataClinienceDataContext();
                var para = dc.Paraclinicals.Where(s => s.Paraclinical_ID == (String)value).SingleOrDefault();
                if (para != null)
                {
                    try
                    {
                        String paraId = para.Paraclinical_ID;
                        for (int i = 0; i < nPara; i++)
                        {
                            if (_getCheckedPara[i] == paraId)
                            {
                                _checkExistingPara = true;
                            }
                        }

                        if (_checkExistingPara == true)
                        {
                            deleteValueOfArray(_getCheckedPara, nPara, paraId);
                            _checkExistingPara = false;
                            nPara--;
                        }
                        else
                        {
                            _getCheckedPara[nPara++] = paraId;
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi" + ex.Message, "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            if (btnLuu.Enabled == true)
            {
                lbTrangThai.Text = "*Chưa có thông tin bệnh án";
                btnLuu.Focus();
            }
            else
            {
                Report.ServiceBills m = new ClinienceSystemManagement.Report.ServiceBills();
                m.SetDataSource(BLL_Report.PrecriptionBill(PreId));
                CrystalReportViewer cv = new CrystalReportViewer();
                cv.Dock = DockStyle.Fill;
                cv.ReportSource = m;
                cv.DisplayGroupTree = false;
                Form f = new Form();
                f.WindowState = FormWindowState.Maximized;
                f.Controls.Add(cv);
                f.ShowDialog();
            }
        }

        private void btnToaThuoc_Click(object sender, EventArgs e)
        {
            if (txtToaThuoc.Text == "Chưa có toa thuốc")
            {
                lbTrangThai.Text = "*Chưa có toa thuốc";
                hyperlinkLabelControl1.Focus();
            }
            else
            {
                Report.PrecriptionBills m = new ClinienceSystemManagement.Report.PrecriptionBills();
                m.SetDataSource(BLL_Report.PrecriptionBill(PreId));
                CrystalReportViewer cv = new CrystalReportViewer();
                cv.Dock = DockStyle.Fill;
                cv.ReportSource = m;
                cv.DisplayGroupTree = false;
                Form f = new Form();
                f.WindowState = FormWindowState.Maximized;
                f.Controls.Add(cv);
                f.ShowDialog();
            }
        }

        private void gridLookUpEdit1View_SelectionChanged_1(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            gvBenh.Text = "Đã có mã bệnh";
            int rowIndex = gridLookUpEdit1View.FocusedRowHandle;
            string colID = "Disease_ID";
            object value = gridLookUpEdit1View.GetRowCellValue(rowIndex, colID);
            if (value != null)
            {
                DataClinienceDataContext dc = new DataClinienceDataContext();
                var disease = dc.Diseases.Where(s => s.Disease_ID == (String)value).SingleOrDefault();
                if (disease != null)
                {
                    try
                    {
                        String diseaseId = disease.Disease_ID;
                        for (int i = 0; i < nDis; i++)
                        {
                            if (_getCheckedDisease[i] == diseaseId)
                            {
                                _checkExistingDis = true;
                            }
                        }

                        if (_checkExistingDis == true)
                        {
                            deleteValueOfArray(_getCheckedDisease, nDis, diseaseId);
                            _checkExistingDis = false;
                            nDis--;
                        }
                        else
                        {
                            _getCheckedDisease[nDis++] = diseaseId;
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi" + ex.Message, "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExits(typeof(Payment));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Payment pm = new Payment();
                pm.preId = (int)PreId;
                pm.ShowDialog();
            }         
        }
    }
}