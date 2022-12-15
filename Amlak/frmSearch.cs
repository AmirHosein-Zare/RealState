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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }
        public void ChangeColor()
        {
            Color c = System.Drawing.ColorTranslator.FromHtml("#000040");
            Button1.BaseColor = c;
            Button2.BaseColor = c;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            ChangeColor();
            Button1.BaseColor = Color.Silver;
            //open form
            this.panelFormLoader.Controls.Clear();
            frmSearchApplicant frm = new frmSearchApplicant() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ChangeColor();
            Button2.BaseColor = Color.Silver;
            //open form
            this.panelFormLoader.Controls.Clear();
            frmSearchDeposit frm = new frmSearchDeposit() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(frm);
            frm.Show();
        }    
    }
}
