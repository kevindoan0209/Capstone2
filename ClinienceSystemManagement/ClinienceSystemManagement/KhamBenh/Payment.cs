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
    public partial class Payment : DevExpress.XtraEditors.XtraForm
    {
        public int preId = 1023;
        public Payment()
        {
            InitializeComponent();
        }

        private void btnDiUng_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    lbTrangThai.Text = "*Vui lòng nhập tên chi phí";
                    txtTen.Focus();
                }
                else
                {
                    if (txtTien.Text == "0")
                    {
                        lbTrangThai.Text = "*Vui lòng nhập tên chi phí";
                        txtTien.Focus();
                    }
                    else
                    {
                        String name = Convert.ToString(txtTen.Text);
                        int money = Convert.ToInt32(txtTien.Text);
                        int bonus = Convert.ToInt32(lbChiPhiPhatSinh.Text);
                        txtChiPhiKhac.Text += ", " + name;
                        lbChiPhiPhatSinh.Text = Convert.ToString(bonus + money);
                        lbTongChiPhi.Text = Convert.ToString(Convert.ToDouble(lbChiPhiKhamBenh.Text) + Convert.ToDouble(lbChiPhiThuoc.Text) + Convert.ToDouble(lbChiPhiPhatSinh.Text));
                        int discount = Convert.ToInt32(lbGiamGia.Text);
                        int sum = Convert.ToInt32(lbTongChiPhi.Text);
                        double amount = sum - ((sum * discount) / 100);
                        lbChiPhiHienTai.Text = Convert.ToString(amount);
                        txtTen.Text = "";
                        txtTien.Text = "0";
                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi" + ex.Message, "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (btnThanhToan.Enabled == false)
            {
                int amount = Convert.ToInt32(lbChiPhiHienTai.Text);
                int discount = Convert.ToInt32(lbGiamGia.Text);
                BLL_Precription.UpdatePrecriptionAmountDiscount(amount, discount, preId);
                this.Close();
            }
            else
            {
                lbTrangThai.Text = "*Chưa thanh toán";
                btnThanhToan.Focus();
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtChiPhiKhac.ReadOnly = true;
            lbChiPhiKhamBenh.Text = "150000";
            int money = BLL_Precription.GetTotalMoney(preId);
            lbChiPhiThuoc.Text = Convert.ToString(money);
            lbTongChiPhi.Text = Convert.ToString(Convert.ToDouble(lbChiPhiKhamBenh.Text) + Convert.ToDouble(lbChiPhiThuoc.Text) + Convert.ToDouble(lbChiPhiPhatSinh.Text));
            int discount = Convert.ToInt32(lbGiamGia.Text);
            int sum = Convert.ToInt32(lbTongChiPhi.Text);
            double amount = sum - ((sum * discount) / 100);
            lbChiPhiHienTai.Text = Convert.ToString(amount);
        }
        private void Reset()
        {
            txtGiamGia.Text = "";
            txtTen.Text = "";
            txtTien.Text = "";
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtGiamGia.Text = "";
            lbGiamGia.Text = "0";
        }

        private void txtTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGiamGia.Value.ToString() == "0")
                {
                    lbTrangThai.Text = "*Vui lòng nhập giảm giá";
                    txtGiamGia.Focus();
                }
                else
                {
                    int discount = Convert.ToInt32(txtGiamGia.Value.ToString());
                    lbGiamGia.Text = Convert.ToString(discount);
                    lbTongChiPhi.Text = Convert.ToString(Convert.ToDouble(lbChiPhiKhamBenh.Text) + Convert.ToDouble(lbChiPhiThuoc.Text) + Convert.ToDouble(lbChiPhiPhatSinh.Text));
                    int sum = Convert.ToInt32(lbTongChiPhi.Text);
                    double amount = sum - ((sum * discount) / 100);
                    lbChiPhiHienTai.Text = Convert.ToString(amount);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi" + ex.Message, "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLamMoiCP_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtTien.Text = "0";
            txtChiPhiKhac.Text = "";
            lbChiPhiPhatSinh.Text = "0";

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(lbChiPhiHienTai.Text);
            btnThanhToan.Enabled = false;
            btnChiPhi.Enabled = false;
            btnKhuyenMai.Enabled = false;
            btnChiPhi.Enabled = false;
            btnLamMoiCP.Enabled = false;
            btnLamMoiKM.Enabled = false;
            txtChiPhiKhac.Enabled = false;
            txtGiamGia.Enabled = false;
            txtTen.Enabled = false;
            txtTien.Enabled = false;
            XtraMessageBox.Show("Số tiền phải trả: " + amount + " VND", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            ClinienceDetail cd = new ClinienceDetail();
            cd.ShowDialog();
           // lbChiPhiKhamBenh.Text = ""
        }
    }
}