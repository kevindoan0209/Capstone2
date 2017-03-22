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
using ClinienceSystemManagement.HeThong;

namespace ClinienceSystemManagement
{
    public partial class DanhMucCanLamSang : DevExpress.XtraEditors.XtraForm
    {
        public DanhMucCanLamSang()
        {
            InitializeComponent();
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
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(ThemDanhMucCanLamSang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                ThemDanhMucCanLamSang formThemCanLamSang = new ThemDanhMucCanLamSang();
                formThemCanLamSang.Show();
            }
        }
    }
}