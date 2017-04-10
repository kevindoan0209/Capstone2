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
        }

        private void PatientDetail_Load(object sender, EventArgs e)
        {
            txtMa.ReadOnly = true;
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
                var patientstatus = db.PatientStatus.Where(i => i.Account_ID == Id).SingleOrDefault();        
                if (account != null)
                {
                    txtMa.EditValue = account.Account_ID;
                    txtTen.EditValue = account.Account_Name;
                    txtDiaChi.EditValue = human.Account_Address;
                    txtEmail.EditValue = human.Account_Email;
                    txtThanhPho.EditValue = human.Account_City;
                    txtSDT.EditValue = human.Account_Phone;
                    txtLyDo.EditValue = patientstatus.PatientStatus_Issue;
                    txtThanPhien.EditValue = patientstatus.PatientStatus_Complain;
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
                }
            }
        }
        private void SaveUpdate()
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    lbTrangThai.Text = "*Vui lòng nhập họ và tên";
                    // XtraMessageBox.Show("Vui lòng nhập họ và tên", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                            string reason = txtLyDo.Text;
                            string complain = txtThanPhien.Text;
                           
                            if (string.IsNullOrEmpty(txtAnh.Text))
                            {
                                if (isAdd == false)
                                {
                                    int id = Convert.ToInt32(txtMa.Text);
                                    BLL_Human.UpdateAccountPatientNoImage(id, name);
                                    BLL_Human.UpdateHumanPatient(id, age, sex, email, phone, job, city, address);
                                    //BLL_Human.UpdateStatusPatient(id,complain, reason);
                                    XtraMessageBox.Show("Cập nhật thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    BLL_Human.InsertAccountPatientNoImage(name);
                                    int lastID = BLL_Human.GetLastIdAccount();
                                    BLL_Human.InsertHumanPatient(lastID, age, sex, email, phone, job, city, address);
                                    BAL_Patient.InsertPatientNoValue(lastID);
                                    BLL_Human.InsertStatusPatient(complain, reason, lastID);
                                    XtraMessageBox.Show("Đã thêm thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                            {
                                if (isAdd == false)
                                {
                                    int id = Convert.ToInt32(txtMa.Text);
                                    BLL_Human.UpdateAccountPatient(id, name,image);
                                    BLL_Human.UpdateHumanPatient(id, age, sex, email, phone, job, city, address);
                                    //   BLL_Human.UpdateStatusPatient(id,complain, reason);
                                    XtraMessageBox.Show("Cập nhật thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    BLL_Human.InsertAccountPatient(name, image);
                                    int lastID = BLL_Human.GetLastIdAccount();
                                    BLL_Human.InsertHumanPatient(lastID, age, sex, email, phone, job, city, address);
                                    BAL_Patient.InsertPatientNoValue(lastID);
                                    BLL_Human.InsertStatusPatient(complain, reason, lastID);
                                    XtraMessageBox.Show("Đã thêm thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
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