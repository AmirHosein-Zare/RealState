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
    public partial class frmpanel : Form
    {
        public frmpanel()
        {
            InitializeComponent();
        }
        public void ButtonColor()
        {
            Color c = System.Drawing.ColorTranslator.FromHtml("#000040");
            button_calender.BaseColor = c;
            button_contact.BaseColor = c;
            button_map.BaseColor = c;
            button_report.BaseColor = c;
        }
        

        private void button_calender_Click_1(object sender, EventArgs e)
        {
            ButtonColor();
            button_calender.BaseColor = Color.Silver;
            
            //openform
            this.panel2.Controls.Clear();
            frmPanel_Date frm = new frmPanel_Date() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(frm);
            frm.Show();
        }

        private void button_contact_Click_1(object sender, EventArgs e)
        {
            //button color
            ButtonColor();
            button_contact.BaseColor = Color.Silver;

            //openform
            this.panel2.Controls.Clear();
            frm_panel_contact frm = new frm_panel_contact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(frm);
            frm.Show();
        }

        private void button_map_Click(object sender, EventArgs e)
        {
            ButtonColor();
            button_map.BaseColor = Color.Silver;
            //openform
            this.panel2.Controls.Clear();
            frmMap frm = new frmMap() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(frm);
            frm.Show();
        }

        private void button_report_Click_1(object sender, EventArgs e)
        {
            ButtonColor();
            button_report.BaseColor = Color.Silver;
            //openform
            this.panel2.Controls.Clear();
            frmReport frm = new frmReport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(frm);
            frm.Show();
        }
    }
}
