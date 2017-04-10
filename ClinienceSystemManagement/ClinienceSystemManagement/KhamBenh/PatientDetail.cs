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
                            string note = txtGhiChu.Text;
                            DateTime age = dtNamSinh.DateTime;
                            string reason = txtLyDo.Text;
                            string complain = txtThanPhien.Text;
                            if (string.IsNullOrEmpty(txtAnh.Text))
                            {
                                BLL_Human.InsertAccountPatientNoImage(name);
                                int lastID = BLL_Human.GetLastIdAccount();
                                BLL_Human.InsertHumanPatient(lastID, age, sex, email, phone, job, city, address);
                                BAL_Patient.InsertPatientNoValue(lastID);
                                BLL_Human.InsertStatusPatient(complain, reason, lastID);
                                XtraMessageBox.Show("Đã thêm thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message);
            }
        }
    }
}