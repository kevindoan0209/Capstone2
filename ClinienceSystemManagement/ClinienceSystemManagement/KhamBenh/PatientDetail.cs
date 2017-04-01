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
                    XtraMessageBox.Show("Vui lòng nhập họ và tên", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTen.Focus();
                }
                else
                {
                    if (lkeBacSi.Text == "Chọn bác sĩ")
                    {
                        XtraMessageBox.Show("Vui lòng chọn bác sĩ", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lkeBacSi.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(dtNgayKham.Text))
                        {
                            XtraMessageBox.Show("Vui lòng chọn ngày khám", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dtNgayKham.Focus();
                        }
                        else
                        {
                            string name = txtTen.Text;
                            string image = txtAnh.Text;
                            DateTime birthdate = DateTime.Parse(dtNamSinh.Text);
                            DateTime date = DateTime.Parse(dtNgayKham.Text);
                            DateTime time = DateTime.Parse(dtGioKham.Text);
                            string gioitinh;
                            if (rbNam.Checked == true)
                            {
                                gioitinh = "Nam";
                            }
                            else
                            {
                                gioitinh = "Nữ";
                            }
                            string phone = txtSDT.Text;
                            string email = txtEmail.Text;
                            string job = txtNgheNghiep.Text;
                            string address = txtDiaChi.Text;
                            string city = txtThanhPho.Text;
                            string note = txtGhiChu.Text;
                            string reason = txtLyDo.Text;
                            string complain = txtThanPhien.Text;
                            string group = lkeBacSi.GetColumnValue("Account_ID").ToString();
                            int doctor = Convert.ToInt32(group.ToString());
                         //   BLL_Paraclinical.UpdateParaclinical(name, id, valueMin, valueMax, anotherName, unit, category, link, note, description, referenceValue, groupId);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
    }
}