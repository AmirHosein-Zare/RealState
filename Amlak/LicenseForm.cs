using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoxLearn.License;
using BusinessEntity;
using BusinessLogicLayer;
using System.IO;

namespace Amlak
{
    public partial class LicenseForm : Form
    {
        

        public LicenseForm()
        {
            InitializeComponent();
        }

        private void LicenseForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = ComputerInfo.GetComputerId();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(textBox1.Text);
            string productkey = textBox2.Text;
            if (km.ValidKey(ref productkey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productkey , ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productkey;
                    lic.FullName = "Personal acounting";
                    if (kv.Type==LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }
                    km.SaveSuretyFile(string.Format(@"{0}\key.lic",Application.StartupPath),lic);
                    MessageBox.Show("فعال سازی برنامه با موفقیت انجام شد","پیغام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    groupBox2.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("کد لایسنس نامعتبر است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BLL_login bll = new BLL_login();
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text==textBox6.Text)
            {
                bll.register(new User_Login { Name = textBox3.Text, Username = textBox4.Text, Password = textBox5.Text ,PictureAddress=""});
                MessageBox.Show("اطلاعات ادمین ایجاد شد");
                ((LoginForm)Application.OpenForms["LoginForm"]).label3.Visible= false;
                this.Close();

            }
            else
            {
                MessageBox.Show("عدم تطابق رمز عبور");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'ا' && e.KeyChar <= 'ی') || (e.KeyChar >= '0' && e.KeyChar <= '9')) 
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن حروف فارسی مجاز نیست");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'ا' && e.KeyChar <= 'ی') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن حروف فارسی مجاز نیست");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'ا' && e.KeyChar <= 'ی') )
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن حروف فارسی مجاز نیست");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'ا' && e.KeyChar <= 'ی') )
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن حروف فارسی مجاز نیست");
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
