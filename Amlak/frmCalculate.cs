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
    public partial class frmCalculate : Form
    {
        public frmCalculate()
        {
            InitializeComponent();
        }
        public void SaveColor()
        {
            Color c = System.Drawing.ColorTranslator.FromHtml("#000040");
            ButtonKom.BaseColor = c;
            ButtonCalculate.BaseColor = c;
            ButtonMoadel.BaseColor = c;
        }
        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            SaveColor();
            ButtonKom.BaseColor = Color.Silver;
            //open form
            this.panelFormLoader.Controls.Clear();
            frmKomision frm = new frmKomision() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void ButtonMoadel_Click(object sender, EventArgs e)
        {
            SaveColor();
            ButtonMoadel.BaseColor = Color.Silver;
            //open form
            this.panelFormLoader.Controls.Clear();
            frmMoadel frm = new frmMoadel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            SaveColor();
            ButtonCalculate.BaseColor = Color.Silver;
            //open Calculator
            System.Diagnostics.Process.Start("calc.exe");
        }

        
    }
}
