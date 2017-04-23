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

namespace ClinienceSystemManagement.TroGiup
{
    public partial class About : DevExpress.XtraEditors.XtraForm
    {
        public About()
        {
            InitializeComponent();
        }
        private void FillData()
        {
                DataClinienceDataContext db = new DataClinienceDataContext();
                var clinience = db.Cliniences.Where(i => i.Clinience_ID == 1).SingleOrDefault();
                if (clinience != null)
                {
                lbTen.Text = clinience.Clinience_Name;
                lbFax.Text = clinience.Clinience_Fax;
                lbEmail.Text = clinience.Clinience_Email;
                lbDiaChi.Text = clinience.Clinience_Address;
                lbDienThoai.Text = clinience.Clinience_Tel;
            }
        }
        private void About_Load(object sender, EventArgs e)
        {
            FillData();
        }
    }
}