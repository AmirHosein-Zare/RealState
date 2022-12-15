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
    public partial class frmKomision : Form
    {
        public frmKomision()
        {
            InitializeComponent();
        }

        private void TextBoxFullA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxFullA.Text.Length > 0)
                {
                    TextBoxFullA.TextChanged -= TextBoxFullA_TextChanged;
                    TextBoxFullA.Text = TextBoxFullA.Text.Replace(",", "");
                    TextBoxFullA.Text = String.Format("{0:N0}", long.Parse(TextBoxFullA.Text));
                    TextBoxFullA.TextChanged += TextBoxFullA_TextChanged;
                    TextBoxFullA.SelectionStart = TextBoxFullA.Text.Length;
                }
            }
            catch { }
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

        private void TextBoxFullA_KeyPress(object sender, KeyPressEventArgs e)
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
        public void visibleControl()
        {
            labelProfit.Visible = false;
            labelProfit2.Visible = false;
            TextBoxProfit.Visible = false;
            TextBoxProfit2.Visible = false;
            labelProfit.Text = ":سود اول";
            TextBoxProfit.Text = "0.5";
            labelD1.Visible = false;
            labelD2.Visible = false;
        }
        private void gunaComboBox1_Leave(object sender, EventArgs e)
        {
            visibleControl();
            TextBoxMortgage.Enabled = true;
            TextBoxRent.Enabled = true;
            TextBoxFullA.Enabled = true;
            if (gunaComboBox1.Text.Trim()=="خرید و فروش")
            {
                TextBoxMortgage.Enabled = false;
                TextBoxRent.Enabled = false;
                labelProfit.Visible = true;
                labelProfit2.Visible = true;
                TextBoxProfit.Visible = true;
                TextBoxProfit2.Visible = true;
                labelD1.Visible = true;
                labelD2.Visible = true;
            }
            else if (gunaComboBox1.Text.Trim()=="رهن و اجاره")
            {
                TextBoxFullA.Enabled = false;
                labelD1.Visible = true;
                labelProfit.Text = ":سود";
                labelProfit.Visible = true;
                TextBoxProfit.Text = "25";
                TextBoxProfit.Visible = true;
            }
        }
        double kom = 0;
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            kom = 0;
            if (gunaComboBox1.Text.Trim() == "خرید و فروش")
            {
                if (TextBoxFullA.Text.Trim().Length == 0)
                {
                    MessageBox.Show("قیمت کل خالی است");
                }
                else
                {
                    double value = double.Parse(TextBoxFullA.Text);
                    double profit1 = double.Parse(TextBoxProfit.Text) / 100;
                    double profit2 = double.Parse(TextBoxProfit2.Text) / 100;
                    double tax = double.Parse(TextBoxTax.Text) / 100;
                    if (value < 500000000)
                    {
                        kom = value * profit1;
                        kom += kom * tax;
                        gunaTextBox1.Text = GlobalFunction.SeparateHundred(kom.ToString()) + "تومان";
                    }
                    else
                    {
                        kom = 500000000 * profit1;
                        value = value - 500000000;
                        kom += value * profit2;
                        kom += kom * tax;
                        gunaTextBox1.Text = GlobalFunction.SeparateHundred(kom.ToString()) + "تومان";
                    }
                }
            }
            else if (gunaComboBox1.Text.Trim() == "رهن و اجاره")
            {
                if (TextBoxMortgage.Text.Trim().Length==0 && TextBoxRent.Text.Trim().Length==0)
                {
                    MessageBox.Show("مبلغ رهن یا اجاره خالی است");
                }
                else
                {
                    double valueMort = double.Parse(TextBoxMortgage.Text);
                    double valueRent = double.Parse(TextBoxRent.Text);
                    double profit = double.Parse(TextBoxProfit.Text) / 100;
                    double tax = double.Parse(TextBoxTax.Text) / 100;
                    valueMort /= 1000000;
                    valueMort *= 30000;
                    valueRent += valueMort;
                    kom = valueRent * profit;
                    kom += kom * tax;
                    gunaTextBox1.Text = GlobalFunction.SeparateHundred(kom.ToString()) + "تومان";
                }
            }
            TextBoxFullA.Clear();
            TextBoxMortgage.Clear();
            TextBoxRent.Clear();
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
