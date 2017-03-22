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

namespace ClinienceSystemManagement.HeThong
{
    public partial class ThemDanhMucCanLamSang : DevExpress.XtraEditors.XtraForm
    {
        public ThemDanhMucCanLamSang()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void reset()
        {
            txtTen.Text = "";
            txtMa.Text = "";
            txtGiaTriNho.Text = "";
            txtGiaTriLon.Text = "";
            txtTenKhac.Text = "";
            txtDonVi.Text = "";
            txtDanhMuc.Text = "";
            txtDiaChi.Text = "";
            txtGhiChu.Text = "";
            txtMoTa.Text = "";
            txtThamChieu.Text = "";
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                if ( string.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên cận lâm sàng", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTen.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtMa.Text))
                    {
                        MessageBox.Show("Vui lòng nhập mã cận lâm sàng", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMa.Focus();
                    }
                    else
                    {
                        string tenCanLamSang = txtTen.Text;
                        string ma = txtMa.Text;
                        int giaTriNho = Convert.ToInt32(txtGiaTriNho.Value.ToString());
                        int giaTriLon = Convert.ToInt32(txtGiaTriLon.Value.ToString());
                        string tengKhac = txtTenKhac.Text;
                        string donVi = txtDonVi.Text;
                        string danhMuc = txtDanhMuc.Text;
                        string diaChi = txtDiaChi.Text;
                        string ghiChu = txtGhiChu.Text;
                        string moTa = txtMoTa.Text;
                        string thamChieu = txtThamChieu.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}