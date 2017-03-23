using ClinienceSystemManagement;
using ClinienceSystemManagement.Hệ_Thống;
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
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        private void DangNhap()
        {
            DangNhap dangnhap = new DangNhap();
            dangnhap.ShowDialog();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangNhap();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất", "Clinience", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DangNhap();
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
        private Form KiemTraTonTai(Type type)
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
            Form frm = this.KiemTraTonTai(typeof(DanhMucCanLamSang));
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
            Form frm = this.KiemTraTonTai(typeof(DanhMucThuoc));
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
    }
}
