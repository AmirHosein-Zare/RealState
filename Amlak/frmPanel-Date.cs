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
    public partial class frmPanel_Date : Form
    {
        public frmPanel_Date()
        {
            InitializeComponent();
        }
        bool flag = false;
        public void DGVPersian()
        {
            dataGridViewX1.ClearSelection();
            dataGridViewX1.Columns["id"].Visible = false;
            dataGridViewX1.Columns["title"].HeaderText = "عنوان";
            dataGridViewX1.Columns["explain"].HeaderText = "توضیحات";
            dataGridViewX1.Columns["date"].HeaderText = "تاریخ";
            dataGridViewX1.Columns["Hour"].HeaderText = "ساعت";
        }
            
        int id;
        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewX1.Rows[dataGridViewX1.CurrentRow.Index].Cells["id"].Value);
        }

        private void frmPanel_Date_Load(object sender, EventArgs e)
        {
            Bll_Datetime bll = new Bll_Datetime();
            dataGridViewX1.DataSource = null;
            dataGridViewX1.DataSource = bll.ReadAll();
            DGVPersian();
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Text = "ویرایش";
                flag = true;
                Datetime d = new Datetime();
                Bll_Datetime bll = new Bll_Datetime();
                d = bll.searchByid(id);
                textBox1.Text = d.title;
                textBox2.Text = d.explain;
                bPersianCalenderTextBox1.Text = d.Date;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bll_Datetime bll = new Bll_Datetime();
                bll.delete(id);
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = bll.ReadAll();
                DGVPersian();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void جزئیاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_Datetime bll = new Bll_Datetime();
            Datetime d = new Datetime();
            frmShowDate f = new frmShowDate();
            d = bll.searchByid(id);
            f.labelTitle.Text = d.title;
            f.labelExplain.Text = d.explain;
            f.labelDate.Text = d.Date;
            f.labelTime.Text = d.Hour;
            f.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((textBox1.Text.Trim()).Length == 0)
            {
                MessageBox.Show("عنوان خالی است");
            }
            else if ((bPersianCalenderTextBox1.Text.Trim()).Length == 0)
            {
                MessageBox.Show("تاریخ خالی است");
            }
            else if ((textBox3.Text.Trim()).Length == 0 && (textBox4.Text.Trim()).Length == 0)
            {
                MessageBox.Show("ساعت خالی است");
            }
            else
            {
                if (!flag)
                {
                    Datetime d = new Datetime();
                    d.title = textBox1.Text;
                    d.explain = textBox2.Text;
                    d.Hour = textBox3.Text.Trim() + ":" + textBox4.Text.Trim();
                    d.Date = bPersianCalenderTextBox1.Text;
                    Bll_Datetime bll = new Bll_Datetime();
                    bll.create(d);
                    dataGridViewX1.DataSource = null;
                    dataGridViewX1.DataSource = bll.ReadAll();
                    DGVPersian();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    bPersianCalenderTextBox1.Clear();
                }
                else
                {
                    Datetime d = new Datetime();
                    Bll_Datetime bll = new Bll_Datetime();
                    d.title = textBox1.Text;
                    d.explain = textBox2.Text;
                    d.Date = bPersianCalenderTextBox1.Text;
                    d.Hour = textBox3.Text.Trim() + ":" + textBox4.Text.Trim();
                    bll.update(id, d);
                    dataGridViewX1.DataSource = null;
                    dataGridViewX1.DataSource = bll.ReadAll();
                    DGVPersian();
                    button1.Text = "ثبت";
                    flag = false;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    bPersianCalenderTextBox1.Clear();
                }
            }
        }

        private void bPersianCalenderTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Bll_Datetime bll = new Bll_Datetime();
            if ((bPersianCalenderTextBox2.Text.Trim()).Length == 0)
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = bll.searchBytitle(textBox5.Text);
                DGVPersian();
            }
            else if ((textBox5.Text.Trim()).Length == 0)
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = bll.searchBydate(bPersianCalenderTextBox2.Text);
                DGVPersian();
            }
            textBox5.Clear();
            bPersianCalenderTextBox2.Clear();
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = (int)dataGridViewX1.Rows[e.RowIndex].Cells["id"].Value;
            }
            catch (Exception exp)
            {
                MessageBox.Show("خطا در بارگزاری اطلاعات", exp.Message);
            }
        }
    }
}
