using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntity;
using BusinessLogicLayer;

namespace Amlak
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void ButtonColor()
        {
            Color c = System.Drawing.ColorTranslator.FromHtml("#000040");
            button_panel.BackColor =c;
            button_search.BackColor = c;
            button_setting.BackColor = c;
            button_Contract.BackColor = c;
            button_create.BackColor = c;
            button_kom.BackColor = c;
            button1.BackColor = c;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            escapeExitForm();
            user u = new user();
            label_name.Text = u.ReturnName();
            label_username.Text = u.ReturnUsername();
            PersianDateTime now = PersianDateTime.Now;
            labelDate.Text = now.ToString(PersianDateTimeFormat.Date);
            BLL_login bll = new BLL_login();
            if (bll.nullPic()==true)
            {

            }
            else if (bll.nullPic()==false)
            {
                picture_user.Image = Image.FromFile(u.Returnpic());
            }
        }

        private void button_panel_Click(object sender, EventArgs e)
        {
            //button color
            ButtonColor();
            Color c = System.Drawing.ColorTranslator.FromHtml("#457b9d");
            button_panel.BackColor = c;
            label_title.Text = "پنل کاربری";
            // load frmpanel
            this.panelFormLoader.Controls.Clear();
            frmpanel frm = new frmpanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            ButtonColor();
            Color c = System.Drawing.ColorTranslator.FromHtml("#457b9d");
            button_create.BackColor = c;
            label_title.Text = "ثبت اطلاعات";
            // load frmpanel
            this.panelFormLoader.Controls.Clear();
            frm_save frm = new frm_save() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            ButtonColor();
            Color c = System.Drawing.ColorTranslator.FromHtml("#457b9d");
            button_search.BackColor = c;
            label_title.Text = "جستجو";
            //open form
            this.panelFormLoader.Controls.Clear();
            frmSearch frm = new frmSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void button_kom_Click(object sender, EventArgs e)
        {
            ButtonColor();
            Color c = System.Drawing.ColorTranslator.FromHtml("#457b9d");
            button_kom.BackColor = c;
            label_title.Text = "محاسبات";
            //open form
            this.panelFormLoader.Controls.Clear();
            frmCalculate frm = new frmCalculate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void button_Contract_Click(object sender, EventArgs e)
        {
            ButtonColor();
            Color c = System.Drawing.ColorTranslator.FromHtml("#457b9d");
            button_Contract.BackColor = c;
            label_title.Text = "پیامک";
            //open form
            Bll_Sms bll = new Bll_Sms();
            frmRegisterSMS f = new frmRegisterSMS();
            if (bll.NumberOfUser()==false)
            {
                f.Show();
            }
            else if (bll.NumberOfUser()==true)
            {
                this.panelFormLoader.Controls.Clear();
                frmSms frm = new frmSms() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm.FormBorderStyle = FormBorderStyle.None;
                this.panelFormLoader.Controls.Add(frm);
                frm.Show();
            }
        }

        private void button_setting_Click(object sender, EventArgs e)
        {
            ButtonColor();
            Color c = System.Drawing.ColorTranslator.FromHtml("#457b9d");
            button_setting.BackColor = c;
            label_title.Text = "تنظیمات";
            //open form
            this.panelFormLoader.Controls.Clear();
            frmSettings frm = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            PersianDateTime now = PersianDateTime.Now;
            //MessageBox.Show(now.ToString(PersianDateTimeFormat.Date));
            Bll_Datetime bll = new Bll_Datetime();
            Datetime d = new Datetime();
            d.Hour = DateTime.Now.ToString("HH:mm");
            d.Date = now.ToString(PersianDateTimeFormat.Date);
            if (bll.Alarm(d))
            {
                MessageBox.Show(bll.ReturnAlarm(d));
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            PersianDateTime now = PersianDateTime.Now;
            //MessageBox.Show(now.ToString(PersianDateTimeFormat.Date));
            Bll_Datetime bll = new Bll_Datetime();
            Datetime d = new Datetime();
            d.Hour = DateTime.Now.ToString("HH:mm");
            d.Date = now.ToString(PersianDateTimeFormat.Date);
            if (bll.Alarm(d))
            {
                MessageBox.Show(":یادآور"+"\n"+bll.ReturnAlarm(d));
                
                int id = bll.Return(d).id;
                bll.delete(id);    
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm");
        }

        private void escape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Button escape;

        public void escapeExitForm()
        {
            this.escape = new Button();
            this.escape.Click += new EventHandler(this.escape_Click);
            this.CancelButton = this.escape;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonColor();
            Color c = System.Drawing.ColorTranslator.FromHtml("#457b9d");
            button1.BackColor = c;
            label_title.Text = "شناسنامه نرم افزار";
            //open form
            this.panelFormLoader.Controls.Clear();
            frmDetail frm = new frmDetail() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(frm);
            frm.Show();
        }
    }
}
