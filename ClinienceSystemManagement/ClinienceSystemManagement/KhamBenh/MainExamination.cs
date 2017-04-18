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

namespace ClinienceSystemManagement.KhamBenh
{
    public partial class MainExamination : DevExpress.XtraEditors.XtraForm
    {
        public int Id;
        public MainExamination()
        {
            InitializeComponent();

        }
        public void FillData()
        {
            if (Id != 0)
            {
                DataClinienceDataContext db = new DataClinienceDataContext();
                var account = db.Accounts.Where(i => i.Account_ID == Id).SingleOrDefault();
                var human = db.Humans.Where(i => i.Account_ID == Id).SingleOrDefault();
                var patient = db.Patients.Where(i => i.Account_ID == Id).SingleOrDefault();
               // var appointment = db.Appointmentsses.Where(i => i.Account_ID_Patient == Id).SingleOrDefault();  
                if (account != null)
                {
                    lbTen.Text = account.Account_Name;
                    lbDiaChi.Text = human.Account_Address;
                    lbEmail.Text = human.Account_Email;
                    lbThanhPho.Text = human.Account_City;
                    lbSoDienThoai.Text = human.Account_Phone;
                    lbGioiTinh.Text = human.Account_Sex;
                  //  txtLyDo.EditValue = appointment.Appointment_Issue;
                   // txtThanPhien.EditValue = appointment.Appointment_Complain;
                   // lbTuoi.Text = Convert.ToString(human.Account_Age);
                    DateTime age = Convert.ToDateTime(human.Account_Age);
                    int ageInYrs = DateTime.Now.Year - age.Year;
                    lbTuoi.Text = ageInYrs + " tuổi";
                    lbCongViec.Text = human.Account_Job;
                    peAnh.EditValue = account.Account_Image;
                }
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
        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExits(typeof(Examination));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Examination ex = new Examination();
                ex.isAdd = true;
                ex.ShowDialog();
            }
        }

        private void MainExamination_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
                SubPatientDetail sp = new SubPatientDetail();
                sp.Id = (int)Id;
                sp.ShowDialog();
        }


    }
}