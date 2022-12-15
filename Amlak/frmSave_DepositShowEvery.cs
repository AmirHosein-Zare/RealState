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
    public partial class frmSave_DepositShowEvery : Form
    {
        public frmSave_DepositShowEvery()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void نمایشاینموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSave_Deposit_Show f = new frmSave_Deposit_Show();
            Deposit n = new Deposit();
            Bll_Deposit bll = new Bll_Deposit();
            n = bll.SearchById(id);
            frmSave_Deposit_Show.id1 = id;
            frmShowPicture.id1 = id;
            f.labelName.Text = n.FullName;
            f.labelNumber.Text = n.Number;
            f.labelKDeposit.Text = n.KindDeposit;
            f.labelKUser.Text = n.KindUser;
            f.labelUserName.Text = n.UserName;
            f.labelRoom.Text = Convert.ToString(n.Room);
            f.labelMeter.Text = Convert.ToString(n.Meter);
            f.labelAddress.Text = n.Address;
            f.labelF.Text = n.Foundation.ToString();
            f.labelGrade.Text = n.Grade;
            f.labelDate.Text = n.ShDate;
            if (n.KindDeposit.Trim() == "فروش")
            {
                f.labelAMount.Text = "مبلغ کل:";
                f.labelMeterAmount.Text = "مبلغ هر متر:";
                f.labelMeterA.Text = GlobalFunction.SeparateHundred(n.MeterAmount.ToString());
                f.labelFullA.Text = GlobalFunction.SeparateHundred(n.FullAmount.ToString());
            }
            else if (n.KindDeposit.Trim() == "رهن و اجاره")
            {
                f.labelAMount.Text = "مبلغ رهن:";
                f.labelFullA.Text = GlobalFunction.SeparateHundred(n.MortgageAmount.ToString());
                f.labelMeterAmount.Text = "مبلغ اجاره:";
                f.labelMeterA.Text = GlobalFunction.SeparateHundred(n.RentAmount.ToString());
            }
            else if (n.KindDeposit.Trim() == "رهن کامل")
            {
                f.labelAMount.Text = "مبلغ رهن:";
                f.labelFullA.Text = GlobalFunction.SeparateHundred(n.MortgageAmount.ToString());
                f.labelMeterA.Visible = false;
                f.labelMeterAmount.Visible = false;
            }
            else if (n.KindDeposit.Trim() == "اجاره")
            {
                f.labelMeterAmount.Text = "مبلغ اجاره:";
                f.labelMeterA.Text = GlobalFunction.SeparateHundred(n.RentAmount.ToString());
                f.labelAMount.Visible = false;
                f.labelFullA.Visible = false;
            }
            if (n.Parking.Trim() == "دارد")
            {
                f.CheckBoxParking.Checked = true;

            }
            if (n.Elavator.Trim() == "دارد")
            {
                f.CheckBoxElavator.Checked = true;
            }
            if (n.Store.Trim() == "دارد")
            {
                f.CheckBoxStore.Checked = true;
            }
            if (n.RemoteDoor.Trim() == "دارد")
            {
                f.CheckBoxRemote.Checked = true;
            }
            if (n.Change.Trim() == "هست")
            {
                f.gunaCheckBox1.Checked = true;
            }
            f.labelExplain.Text = n.Explain;
            f.Show();
        }
        int id;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = (int)DataGridView1.Rows[e.RowIndex].Cells["id"].Value;
            }
            catch (Exception exp)
            {
                MessageBox.Show("خطا در بارگزاری اطلاعات", exp.Message);
            }
        }
        string Ts;
        private void ارسالپیامکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTextSms frm = new frmTextSms();
            Deposit d = new Deposit();
            Bll_Deposit bll = new Bll_Deposit();
            d = bll.SearchById(id);
            frmTextSms.Number = d.Number;
            frmTextSms.N = d.FullName;
            frm.TextBoxText.Text = "با توجه به درخواست شما جهت" +" "+ d.KindDeposit  + "-" + d.UserName + " " + "در تاریخ" + d.ShDate + "موردی با مشخصات مشابه به این بنگاه سپرده شده است.جهت تعیین تکلیف در اسرع وقت به بنگاه مراجعه فرمایید.";
            frm.ShowDialog();
        }
        public void DGV()
        {
            DataGridView1.ClearSelection();
            DataGridView1.Columns["id"].HeaderText = "کد کاربر";
            DataGridView1.Columns["FullName"].Visible = false;
            DataGridView1.Columns["Number"].Visible = false;
            DataGridView1.Columns["KindDeposit"].HeaderText = "نوع تقاضا";
            DataGridView1.Columns["KindUser"].Visible = false;
            DataGridView1.Columns["UserName"].HeaderText = "نام کاربری";
            DataGridView1.Columns["Foundation"].HeaderText = "زیربنا";
            DataGridView1.Columns["Room"].HeaderText = "خواب";
            DataGridView1.Columns["Meter"].HeaderText = "متراژ";
            DataGridView1.Columns["Address"].HeaderText = "آدرس";
            DataGridView1.Columns["Explain"].Visible = false;
            DataGridView1.Columns["Parking"].HeaderText = "پارکینگ";
            DataGridView1.Columns["Elavator"].HeaderText = "آسانسور";
            DataGridView1.Columns["Store"].HeaderText = "انباری";
            DataGridView1.Columns["RemoteDoor"].HeaderText = "درب ریموت";
            DataGridView1.Columns["FullAmount"].HeaderText = "مبلغ کل";
            DataGridView1.Columns["MeterAmount"].HeaderText = "مبلغ هر متر";
            DataGridView1.Columns["MortgageAmount"].HeaderText = "مبلغ رهن";
            DataGridView1.Columns["RentAmount"].HeaderText = "مبلغ اجاره";
            DataGridView1.Columns["Change"].HeaderText = "معاوضه";
            DataGridView1.Columns["Grade"].HeaderText = "طبقه";
            DataGridView1.Columns["ShDate"].Visible = false;
            DataGridView1.Columns["MDate"].Visible = false;
            DataGridView1.Columns["PictureAddress1"].Visible = false;
            DataGridView1.Columns["PictureAddress2"].Visible = false;
            DataGridView1.Columns["PictureAddress3"].Visible = false;
            DataGridView1.Columns["XLocation"].Visible = false;
            DataGridView1.Columns["YLocation"].Visible = false;
        }
        private void جستجویمواردمشابهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_Deposit bll = new Bll_Deposit();
            Deposit d = new Deposit();
            d = bll.SearchById(id);
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = bll.Search(d.KindDeposit, d.KindUser, d.UserName, "");
            DGV();
        }

        private void بازبینیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_Deposit bll = new Bll_Deposit();
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = bll.ReadAll();
            DGV();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_Deposit bll = new Bll_Deposit();
            bll.Delete(id);
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = bll.ReadAll();
            DGV();
        }
    }
    
}
