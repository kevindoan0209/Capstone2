using ClinienceSystemManagement;
using ClinienceSystemManagement.DatHen;
using ClinienceSystemManagement.Hệ_Thống;
using ClinienceSystemManagement.HeThong;
using ClinienceSystemManagement.KhamBenh;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Home()
        {
            InitializeComponent();
        }
        private string TenDangNhap;
        public Home(string Text)
        {
            TenDangNhap = Text;
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
            HumanDetail hd = new HumanDetail();
            hd.ShowDialog();
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
            if (frm != null)
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
            Form frm = this.IsExits(typeof(MedicineUnit));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                MedicineUnit medicine = new MedicineUnit();
                medicine.MdiParent = this;
                medicine.Show();
            }
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
                MedicineIngredient medicine = new MedicineIngredient();
                medicine.MdiParent = this;
                medicine.Show();
            }
        }

        private void btnNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.IsExits(typeof(Human));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Human human = new Human();
                human.MdiParent = this;
                human.Show();
            }
        }

        private void btnBarThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = XtraMessageBox.Show("Bạn có thật sự muốn thoát", "Clinience", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBarDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất", "Clinience", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Login();
            }
        }

        private void btnLichHen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.IsExits(typeof(Appointment));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Appointment appointment = new Appointment();
                appointment.MdiParent = this;
                appointment.Show();
            }
        }

        private void btnBenhNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.IsExits(typeof(Patient));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Patient patient = new Patient();
                patient.MdiParent = this;
                patient.Show();
            }
        }
    }
}
