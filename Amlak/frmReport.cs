using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amlak
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (RadioButtonApplicant.Checked)
            {
                stiReport2.Show();
            }
            else if (RadioButtonDeposit.Checked)
            {
                stiReport1.Show();
            }
            else
            {
                MessageBox.Show("یک گزینه را انتخاب کنید");
            }
        }
    }
}
