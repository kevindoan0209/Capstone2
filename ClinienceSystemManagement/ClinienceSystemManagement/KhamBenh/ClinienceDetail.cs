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
    public partial class ClinienceDetail : DevExpress.XtraEditors.XtraForm
    {
        public ClinienceDetail()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void ClinienceDetail_Load(object sender, EventArgs e)
        {

        }
    }
}