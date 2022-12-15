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
    public partial class frmRegisterSMS : Form
    {
        public frmRegisterSMS()
        {
            InitializeComponent();
        }

        private void gunaTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن حروف مجاز نمی باشد");
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (TextBoxUserName.Text.Trim().Length==0)
            {
                MessageBox.Show("نام کاربری خالی است");
                TextBoxUserName.Select();
            }
            else if (TextBoxPassWord.Text.Trim().Length==0)
            {
                MessageBox.Show("رمز عبور خالی است");
                TextBoxPassWord.Select();
            }
            else if (TextBoxNumber.Text.Trim().Length==0)
            {
                MessageBox.Show("شماره خالی است");
                TextBoxNumber.Select();
            }
            else if (TextBoxName.Text.Trim().Length==0)
            {
                MessageBox.Show("نام املاک خالی است");
                TextBoxName.Select();
            }
            else
            {
                UserWebService.Users s = new UserWebService.Users();
                string UserName=TextBoxUserName.Text;
                string password=TextBoxPassWord.Text;
                double w = s.GetUserCredit(UserName, password, UserName);
                string[] smsw = s.GetUserNumbers(UserName, password);
                var q = from i in smsw select i;
                if (w==0 || q.Count()==0 || smsw[0]!=TextBoxNumber.Text)
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
                }
                else
                {

                    UserSms h = new UserSms();
                    h.UserName = TextBoxUserName.Text;
                    h.Password = TextBoxPassWord.Text;
                    h.Number = TextBoxNumber.Text;
                    h.Name = TextBoxName.Text;
                    Bll_Sms bll = new Bll_Sms();
                    bll.Create(h);
                    MessageBox.Show("با موفقیت ثبت شد");
                    this.Close();
                }
            }
        }
    }
}
