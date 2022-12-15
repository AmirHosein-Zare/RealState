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
    public partial class frmSms : Form
    {
        public frmSms()
        {
            InitializeComponent();
        }
        public void ChangeColor()
        {
            Color c = System.Drawing.ColorTranslator.FromHtml("#000040");
            ButtonSend.BaseColor = c;
            ButtonReceive.BaseColor = c;
        }
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            ChangeColor();
            ButtonSend.BaseColor = Color.Silver;
            //open form
            this.panelFormLoader.Controls.Clear();
            frmSendSms frm = new frmSendSms() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void ButtonReceive_Click(object sender, EventArgs e)
        {
            ChangeColor();
            ButtonReceive.BaseColor = Color.Silver;
            //open form
            this.panelFormLoader.Controls.Clear();
            frmReceiveSms frm = new frmReceiveSms() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(frm);
            frm.Show();
        }
    }
}
