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
    public partial class frmTextSms : Form
    {
        public frmTextSms()
        {
            InitializeComponent();
        }
        bool flag = false;
        public void DGV()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Columns["id"].Visible=false;
            dataGridView1.Columns["Text"].HeaderText = "متن";
            dataGridView1.Columns["Text"].Width = 500;
        }
        private void TextBoxText_TextChanged(object sender, EventArgs e)
        {

        }
        public static string Number;
        public static string N;
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (TextBoxText.Text.Trim().Length == 0)
            {
                MessageBox.Show("متن پیام خالی است");
                TextBoxText.Select();
            }
            else
            {
                if (!flag)
                {
                    Bll_Sms bll = new Bll_Sms();
                    UserSms h = new UserSms();
                    h = bll.ReturnUser();
                    contact c = new contact();
                    string username = h.UserName;
                    string password = h.Password;
                    string from = h.Number;
                    string to = Number;
                    string text = "آقا/خانم" + " " + N + " " + "عزیز" + "\n" + TextBoxText.Text + "\n" + h.Name;
                    bool isFlash = false;
                    SendWebService.Send soapClient = new SendWebService.Send();
                    try
                    {
                        soapClient.SendSimpleSMS(username, password, new string[] { to }, from, text, isFlash);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("خطا");
                    }
                    if (CheckBoxSave.Checked)
                    {
                        SmsText s = new SmsText();
                        Bll_SmsText bs = new Bll_SmsText();
                        s.Text = TextBoxText.Text;
                        bs.create(s);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = bs.ReadAll();
                        DGV();
                    }
                    TextBoxText.Clear();
                    MessageBox.Show("پیام ارسال شد");
                }
                else
                {
                    Bll_SmsText bs = new Bll_SmsText();
                    SmsText s = new SmsText();
                    s.Text = TextBoxText.Text;
                    bs.Update(id,s);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bs.ReadAll();
                    DGV();
                    flag = false;
                    ButtonSend.Text = "ارسال";
                    TextBoxText.Clear();
                    MessageBox.Show("متن با موفقیت ویرایش شد");
                }
            }
        }

        private void frmTextSms_Load(object sender, EventArgs e)
        {
            Bll_SmsText bll = new Bll_SmsText();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll.ReadAll();
            DGV();
        }
        int id;
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
            Bll_SmsText bll = new Bll_SmsText();
            SmsText s = new SmsText();
            s = bll.SearchById(id);
            TextBoxText.Text = s.Text;
            flag = true;
            ButtonSend.Text = "ویرایش";
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_SmsText bll = new Bll_SmsText();
            bll.delete(id);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll.ReadAll();
            DGV();
        }

        private void انتخابمتنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmsText s = new SmsText();
            Bll_SmsText bll = new Bll_SmsText();
            s = bll.SearchById(id);
            TextBoxText.Text = s.Text;
        }
    }
}
