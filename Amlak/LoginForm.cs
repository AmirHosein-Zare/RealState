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
using System.IO;
using FoxLearn.License;

namespace Amlak
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LicenseForm lf = new LicenseForm();
            lf.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            BLL_login bll = new BLL_login();
            if (bll.login(textBox1.Text, textBox2.Text) == 0)
            {
                label3.Visible = true;
            }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.PasswordChar = (char)0149;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BLL_login bll = new BLL_login();
            if (bll.login(textBox1.Text, textBox2.Text) == 1)
            {
                label3.Text = "خوش آمدید";
                MainForm m = new MainForm();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("رمز ورود یا نام کاربری اشتباه است");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else if (textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
