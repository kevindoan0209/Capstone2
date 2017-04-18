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
    public partial class Precription : DevExpress.XtraEditors.XtraForm
    {
        public Precription()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
        }
    }
}