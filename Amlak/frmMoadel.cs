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

namespace Amlak
{
    public partial class frmMoadel : Form
    {
        public frmMoadel()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void visibleControl()
        {
            labelEmpty2.Visible = false;
            labelEmpty.Visible = false;
            TextBoxEmpty.Visible = false;
        }
        private void ComboBox1_Leave(object sender, EventArgs e)
        {
            if (ComboBox1.Text.Trim()=="تبدیل رهن")
            {
                TextBoxEmpty.Visible = true;
                labelEmpty.Text = ":مبلغ رهن پیشنهادی";
                labelEmpty.Visible = true;
                labelEmpty2.Text = ":مبلغ اجاره";
                labelEmpty2.Visible = true;
            }
            else if (ComboBox1.Text.Trim()=="تبدیل اجاره")
            {
                TextBoxEmpty.Visible = true;
                labelEmpty.Text = ":مبلغ اجاره پیشنهادی";
                labelEmpty.Visible = true;
                labelEmpty2.Text = ":مبلغ رهن";
                labelEmpty2.Visible = true;
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (ComboBox1.Text.Trim() == "")
            {
                MessageBox.Show("نوع تبدیل خالی است");
            }
            else if (TextBoxRatio.Text.Trim().Length == 0)
            {
                MessageBox.Show("نرخ تبدیل خالی است");
            }
            else if (TextBoxMortgage.Text.Trim().Length == 0)
            {
                MessageBox.Show("مبلغ رهن خالی است");
            }
            else if (TextBoxRent.Text.Trim().Length == 0)
            {
                MessageBox.Show("مبلغ اجاره خالی است");
            }
            else if (TextBoxEmpty.Text.Trim().Length == 0)
            {
                MessageBox.Show("مبلغ رهن یا اجاره پیشنهادی خالی است");
            }
            else
            {
                if (ComboBox1.Text.Trim() == "تبدیل رهن")
                {

                    double Mortgage = double.Parse(TextBoxMortgage.Text.Replace(",", ""));
                    double Rent = double.Parse(TextBoxRent.Text.Replace(",", ""));
                    double Ratio = double.Parse(TextBoxRatio.Text.Replace(",", ""));
                    double Empty = double.Parse(TextBoxEmpty.Text.Replace(",", ""));
                    if (Mortgage < Empty)
                    {
                        double Final = (Empty-Mortgage) / 1000000;
                        Final *= Ratio;
                        Final -= Rent;
                        TextBox7.Text = GlobalFunction.SeparateHundred(Final.ToString()) + "تومان";
                    }
                    else if(Empty<=Mortgage)
                    {
                        //calculate
                        double Final = (Mortgage - Empty) / 1000000;
                        Final *= Ratio;
                        Final += Rent;
                        TextBox7.Text = GlobalFunction.SeparateHundred(Final.ToString()) + "تومان";

                    }
                }
                else if (ComboBox1.Text.Trim() == "تبدیل اجاره")
                {
                    double Mortgage = double.Parse(TextBoxMortgage.Text.Replace(",", ""));
                    double Rent = double.Parse(TextBoxRent.Text.Replace(",", ""));
                    double Ratio = double.Parse(TextBoxRatio.Text.Replace(",", ""));
                    double Empty = double.Parse(TextBoxEmpty.Text.Replace(",", ""));
                    //calculate
                    if (Rent>Empty)
                    {
                        double Final = ((Rent - Empty) / Ratio) * 1000000;
                        Final += Mortgage;
                        TextBox7.Text = GlobalFunction.SeparateHundred(Final.ToString()) + "تومان";
                    }
                    else if (Empty>=Rent)
                    {
                        double Final = ((Empty-Rent) / Ratio) * 1000000;
                        Final -= Mortgage;
                        TextBox7.Text = GlobalFunction.SeparateHundred(Final.ToString()) + "تومان";
                    }
                }
            }
        }

        private void TextBoxMortgage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxMortgage.Text.Length > 0)
                {
                    TextBoxMortgage.TextChanged -= TextBoxMortgage_TextChanged;
                    TextBoxMortgage.Text = TextBoxMortgage.Text.Replace(",", "");
                    TextBoxMortgage.Text = String.Format("{0:N0}", long.Parse(TextBoxMortgage.Text));
                    TextBoxMortgage.TextChanged += TextBoxMortgage_TextChanged;
                    TextBoxMortgage.SelectionStart = TextBoxMortgage.Text.Length;
                }
            }
            catch { }
        }

        private void TextBoxRent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxRent.Text.Length > 0)
                {
                    TextBoxRent.TextChanged -= TextBoxRent_TextChanged;
                    TextBoxRent.Text = TextBoxRent.Text.Replace(",", "");
                    TextBoxRent.Text = String.Format("{0:N0}", long.Parse(TextBoxRent.Text));
                    TextBoxRent.TextChanged += TextBoxRent_TextChanged;
                    TextBoxRent.SelectionStart = TextBoxRent.Text.Length;
                }
            }
            catch { }
        }

        private void TextBoxEmpty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxEmpty.Text.Length > 0)
                {
                    TextBoxEmpty.TextChanged -= TextBoxEmpty_TextChanged;
                    TextBoxEmpty.Text = TextBoxEmpty.Text.Replace(",", "");
                    TextBoxEmpty.Text = String.Format("{0:N0}", long.Parse(TextBoxEmpty.Text));
                    TextBoxEmpty.TextChanged += TextBoxEmpty_TextChanged;
                    TextBoxEmpty.SelectionStart = TextBoxEmpty.Text.Length;
                }
            }
            catch { }
        }

        private void TextBoxRatio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxRatio.Text.Length > 0)
                {
                    TextBoxRatio.TextChanged -= TextBoxRatio_TextChanged;
                    TextBoxRatio.Text = TextBoxRatio.Text.Replace(",", "");
                    TextBoxRatio.Text = String.Format("{0:N0}", long.Parse(TextBoxRatio.Text));
                    TextBoxRatio.TextChanged += TextBoxRatio_TextChanged;
                    TextBoxRatio.SelectionStart = TextBoxRatio.Text.Length;
                }
            }
            catch { }
        }

        private void frmMoadel_Load(object sender, EventArgs e)
        {
            int n = 30000;
            TextBoxRatio.Text = GlobalFunction.SeparateHundred(n.ToString());
        }

        private void TextBoxRatio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن حروف مجاز نیست");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void TextBoxMortgage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن حروف مجاز نیست");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void TextBoxRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن حروف مجاز نیست");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void TextBoxEmpty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن حروف مجاز نیست");
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
