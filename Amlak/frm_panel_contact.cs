using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using BusinessEntity;
using BusinessLogicLayer;

namespace Amlak
{
    public partial class frm_panel_contact : Form
    {
        public frm_panel_contact()
        {
            InitializeComponent();
        }
        bool flag = false;
        int id;
        public void DGVPersian()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["FullName"].HeaderText = "نام و نام خانوادگی";
            dataGridView1.Columns["Number"].HeaderText = "شماره تلفن";
            dataGridView1.Columns["Address"].HeaderText = "آدرس";
            dataGridView1.Columns["Address"].Width = 300;
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
            }
            catch (Exception exp)
            {
                MessageBox.Show("خطا در بارگزاری اطلاعات", exp.Message);
            }
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = true;
            contact human = new contact();
            Bll_contact h = new Bll_contact();
            human = h.SearchById(id);
            textBox4.Text = human.FullName;
            textBox3.Text = human.Number;
            textBox2.Text = human.Address;
            button1.Text = "بروزرسانی";

        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_contact h = new Bll_contact();
            h.delete(id);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = h.ReadAll();
            DGVPersian();
        }

        
        
        private void frm_panel_contact_Load(object sender, EventArgs e)
        {
            Bll_contact h = new Bll_contact();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = h.ReadAll();
            DGVPersian();
        }
        

        private void جزئیاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_contact bll = new Bll_contact();
            contact c = new contact();
            c = bll.SearchById(id);
            frmShowContact f = new frmShowContact();
            f.labelFullName.Text = c.FullName;
            f.labelNumber.Text = c.Number;
            f.labelAddress.Text = c.Address;
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stiReport1.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((textBox4.Text.Trim()).Length == 0)
            {
                MessageBox.Show("نام و نام خانوادگی خالی است");
            }
            else if ((textBox3.Text.Trim()).Length != 11)
            {
                MessageBox.Show("شماره تلفن معتبر نمی باشد");
            }
            else if ((textBox2.Text.Trim()).Length == 0)
            {
                MessageBox.Show("آدرس خالی است");
            }
            else
            {
                if (!flag)
                {
                    contact human = new contact();
                    human.FullName = textBox4.Text;
                    human.Number = textBox3.Text;
                    human.Address = textBox2.Text;
                    Bll_contact h = new Bll_contact();
                    h.create(human);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = h.ReadAll();
                    DGVPersian();
                    textBox2.ResetText();
                    textBox3.Clear();
                    textBox4.Clear();
                    MessageBox.Show("مخاطب افزوده شد");
                }
                else
                {
                    contact human = new contact();
                    human.FullName = textBox4.Text;
                    human.Number = textBox3.Text;
                    human.Address = textBox2.Text;
                    Bll_contact h = new Bll_contact();
                    h.update(human, id);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = h.ReadAll();
                    DGVPersian();
                    button1.Text = "ثبت نام";
                    flag = false;
                    textBox2.ResetText();
                    textBox3.Clear();
                    textBox4.Clear();
                    MessageBox.Show("با موفقیت ویرایش شد");
                }
            }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن عدد مجاز نیست");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن حروف مجاز نیست");
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Bll_contact h = new Bll_contact();
            if ((textBox1.Text.Trim()).Length == 0)
            {
                dataGridView1.DataSource = h.SearchByNumber(textBox5.Text);
                DGVPersian();
            }
            else if ((textBox5.Text.Trim()).Length == 0)
            {
                dataGridView1.DataSource = h.SearchByName(textBox1.Text);
                DGVPersian();
            }
            textBox5.Clear();
            textBox1.Clear();
        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن حروف مجاز نیست");
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن عدد مجاز نیست");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("وارد کردن حروف مجاز نیست");
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            stiReport1.Show();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
            }
            catch (Exception exp)
            {
                MessageBox.Show("خطا در بارگزاری اطلاعات", exp.Message);
            }
        }

        private void ارسالپیامکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTextSms frm = new frmTextSms();
            Bll_contact bll = new Bll_contact();
            contact c = new contact();
            c = bll.SearchById(id);
            frmTextSms.Number = c.Number;
            frmTextSms.N = c.FullName;
            frm.Show();
        }
    }
}
