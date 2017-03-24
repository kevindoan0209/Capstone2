using ClinienceSystemManagement;
using ClinienceSystemManagement.Hệ_Thống;
using ClinienceSystemManagement.HeThong;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Login()
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Login();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất", "Clinience", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Login();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = XtraMessageBox.Show("Bạn có thật sự muốn thoát", "Clinience", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
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
        private void btnLamSang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.IsExits(typeof(DanhMucCanLamSang));
            if(frm != null)
            {
                frm.Activate();
            }
            else
            {
                DanhMucCanLamSang formCanLamSang = new DanhMucCanLamSang();
                formCanLamSang.MdiParent = this;
                formCanLamSang.Show();
            }
        }

        private void btnThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.IsExits(typeof(DanhMucThuoc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                DanhMucThuoc formThuoc = new DanhMucThuoc();
                formThuoc.MdiParent = this;
                formThuoc.Show();
            }
        }

        private void btnBenh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.IsExits(typeof(Disease));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Disease disease = new Disease();
                disease.MdiParent = this;
                disease.Show();
            }
        }

        private void btnDonVi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThanhPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.IsExits(typeof(MedicineIngredient));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                MedicineIngredient mi = new MedicineIngredient();
                mi.MdiParent = this;
                mi.Show();
            }
        }
    }
}
