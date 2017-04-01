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
    public partial class Patient : DevExpress.XtraEditors.XtraForm
    {
        public Patient()
        {
            InitializeComponent();
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExits(typeof(PatientDetail));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                PatientDetail pd = new PatientDetail();
                pd.isAdd = true;
                pd.ShowDialog();
             //   sqlDataSource1.Fill();
            }
        }
    }
}