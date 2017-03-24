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
using DataAccessLayer;
using BussinessLogicLayer;

namespace ClinienceSystemManagement.HeThong
{
    public partial class DiseaseDetail : DevExpress.XtraEditors.XtraForm
    {
        public string Id = null;
        public bool isAdd = true;
        public DiseaseDetail()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtMoTa.Text = "";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DiseaseDetail_Load(object sender, EventArgs e)
        {
            FillDataUpdate();
        }
        private void FillDataUpdate()
        {
            if (Id != null)
            {
                DataClinienceDataContext db = new DataClinienceDataContext();
                var diseases = db.Diseases.Where(i => i.Disease_ID == Id).SingleOrDefault();
                if (diseases != null)
                {
                    txtMa.EditValue = diseases.Disease_ID;
                    txtTen.EditValue = diseases.Disease_Name;
                    txtMoTa.EditValue = diseases.Disease_Description;
                    txtMa.ReadOnly = true;
                }
            }
        }
        private void SaveUpdate()
        {
            try
            {
                if (string.IsNullOrEmpty(txtMa.Text))
                {
                    XtraMessageBox.Show("Vui lòng nhập mã bệnh", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMa.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtTen.Text))
                    {
                        XtraMessageBox.Show("Vui lòng nhập tên bệnh", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtTen.Focus();
                    }
                    else
                    {
                        string name = txtTen.Text;
                        string id = txtMa.Text;
                        string description = txtMoTa.Text;
                        BLL_Disease.Update(id, name, description);
                        this.Close();
                        XtraMessageBox.Show("Cập nhật thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdd == false)
                {
                    SaveUpdate();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtMa.Text))
                    {
                        XtraMessageBox.Show("Vui lòng nhập mã bệnh", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMa.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtTen.Text))
                        {
                            XtraMessageBox.Show("Vui lòng nhập tên bệnh", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTen.Focus();
                        }
                        else
                        {
                            string name = txtTen.Text;
                            string id = txtMa.Text;
                            string description = txtMoTa.Text;
                            BLL_Disease.Insert(id, name, description);
                            this.Close();                 
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mã đối tượng này đã tồn tại");
            }
        }
    }
}
