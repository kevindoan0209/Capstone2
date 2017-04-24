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
    public partial class Statictis : DevExpress.XtraEditors.XtraForm
    {
        public Statictis()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Statictis_Load(object sender, EventArgs e)
        {

        }
    }
}