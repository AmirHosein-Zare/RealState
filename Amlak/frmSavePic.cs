using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BusinessEntity;
using BusinessLogicLayer;

namespace Amlak
{
    public partial class frmSavePic : Form
    {
        public frmSavePic()
        {
            InitializeComponent();
        }
        OpenFileDialog f = new OpenFileDialog();
        
        
        
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim().Length==0)
            {
                MessageBox.Show("نام تصویر خالی است");
            }
            else
            {
                frmDeposit.Npic = TextBox1.Text;
                frmDeposit.picA = path1;
            }
            
        }

        private void frmSavePic_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
        
        Image pic1;
        string path1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام تصویر خالی است");
            }
            else
            {
                frmDeposit.picA2 = path2;
                frmDeposit.Npic2 = TextBox2.Text;
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام تصویر خالی است");
            }
            else
            {
                frmDeposit.picA3 = path3;
                frmDeposit.Npic3 = TextBox3.Text;
            }
        }
        string path2;
        Image pic2;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            f.Filter = "JPG(*.JPG)|*.JPG";
            if (f.ShowDialog() == DialogResult.OK)
            {
                pic2 = Image.FromFile(f.FileName);
                pictureBox2.Image = pic2;
                path2 = f.FileName;
            }
        }
        string path3;
        Image pic3;
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            f.Filter = "JPG(*.JPG)|*.JPG";
            if (f.ShowDialog() == DialogResult.OK)
            {
                pic3 = Image.FromFile(f.FileName);
                pictureBox3.Image = pic3;
                path3 = f.FileName;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            f.Filter = "JPG(*.JPG)|*.JPG";
            if (f.ShowDialog() == DialogResult.OK)
            {
                path1 = f.FileName;
                pic1 = Image.FromFile(f.FileName);
                pictureBox1.Image = pic1;
                //path1 = pictureBox1.ImageLocation;
            }
            else
            {
                MessageBox.Show("فایلی انتخاب نشده");

            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'ا' && e.KeyChar <= 'ی'))
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن حروف فارسی مجاز نیست");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'ا' && e.KeyChar <= 'ی'))
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
