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
using System.Data.Entity;

namespace Amlak
{
    public partial class frmSave__ApplicantShowEveryThing : Form
    {
        public frmSave__ApplicantShowEveryThing()
        {
            InitializeComponent();
        }
        public void DGV()
        {
            DataGridView1.ClearSelection();
            DataGridView1.Columns["id"].HeaderText = "کد کاربر";
            DataGridView1.Columns["FullName"].HeaderText = "نام و نام خانوادگی";
            DataGridView1.Columns["Number"].Visible=false;
            DataGridView1.Columns["KindNeed"].HeaderText = "نوع تقاضا";
            DataGridView1.Columns["KindUser"].Visible=false;
            DataGridView1.Columns["UserName"].HeaderText = "نام کاربری";
            DataGridView1.Columns["Foundation"].HeaderText = "زیربنا";
            DataGridView1.Columns["Room"].HeaderText = "خواب";
            DataGridView1.Columns["Meter"].HeaderText = "متراژ";
            DataGridView1.Columns["Address"].HeaderText = "آدرس";
            DataGridView1.Columns["Explain"].Visible = false;
            DataGridView1.Columns["MDate"].Visible = false;
            DataGridView1.Columns["ShDate"].Visible = false;
            DataGridView1.Columns["Parking"].HeaderText = "پارکینگ";
            DataGridView1.Columns["Elavator"].HeaderText = "آسانسور";
            DataGridView1.Columns["Store"].HeaderText = "انباری";
            DataGridView1.Columns["RemoteDoor"].HeaderText = "درب ریموت";
            if (DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells["FullAmount"].Value == null)
            {
                DataGridView1.Columns["FullAmount"].Visible = false;
            }
            else
            {
                DataGridView1.Columns["FullAmount"].HeaderText = "مبلغ کل";
            }
            if (DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells["MeterAmount"].Value == null)
            {
                DataGridView1.Columns["MeterAmount"].Visible = false;
            }
            else
            {
                DataGridView1.Columns["MeterAmount"].HeaderText = "مبلغ هر متر";
            }
            if (DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells["MortgageAmount"].Value == null)
            {
                DataGridView1.Columns["MortgageAmount"].Visible = false;
            }
            else
            {
                DataGridView1.Columns["MortgageAmount"].HeaderText = "مبلغ رهن";
            }
            if (DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells["RentAmount"].Value == null)
            {
                DataGridView1.Columns["RentAmount"].Visible = false;
            }
            else
            {
                DataGridView1.Columns["RentAmount"].HeaderText = "مبلغ اجاره";
            }
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

        private void frmSave__ApplicantShowEveryThing_Load(object sender, EventArgs e)
        {

        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_Need bll = new Bll_Need();
            bll.Delete(id);
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = bll.Read();
            DGV();
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

        private void نمایشاینموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSave_Applacant_Show f = new frmSave_Applacant_Show();
            Need n = new Need();
            Bll_Need bll = new Bll_Need();
            n = bll.SearchById(id);
            f.labelName.Text = n.FullName;
            f.labelNumber.Text = n.Number;
            f.labelKNeed.Text = n.KindNeed;
            f.labelKUser.Text = n.KindUser;
            f.labelUserName.Text = n.UserName;
            f.labelRoom.Text = Convert.ToString(n.Room);
            f.labelMeter.Text = Convert.ToString(n.Meter);
            f.labelAddress.Text = n.Address;
            f.labelF.Text = n.Foundation.ToString();
            f.labelDate.Text = n.ShDate;
            if (n.KindNeed.Trim() == "خرید" || n.KindNeed.Trim() == "پیش خرید")
            {
                f.labelAMount.Text = "مبلغ کل:";
                f.labelMeterAmount.Text = "مبلغ هر متر:";
                f.labelMeterA.Text = GlobalFunction.SeparateHundred(n.MeterAmount.ToString());
                f.labelFullA.Text = GlobalFunction.SeparateHundred(n.FullAmount.ToString());
            }
            else if (n.KindNeed.Trim() == "رهن و اجاره")
            {
                f.labelAMount.Text = "مبلغ رهن:";
                f.labelFullA.Text = GlobalFunction.SeparateHundred(n.MortgageAmount.ToString());
                f.labelMeterAmount.Text = "مبلغ اجاره:";
                f.labelMeterA.Text = GlobalFunction.SeparateHundred(n.RentAmount.ToString());
            }
            else if (n.KindNeed.Trim() == "رهن کامل")
            {
                f.labelAMount.Text = "مبلغ رهن:";
                f.labelFullA.Text = GlobalFunction.SeparateHundred(n.MortgageAmount.ToString());
                f.labelMeterA.Visible = false;
                f.labelMeterAmount.Visible = false;
            }
            else if (n.KindNeed.Trim() == "اجاره")
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
            f.labelExplain.Text = n.Explain;
            f.Show();
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ارسالپیامکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTextSms frm = new frmTextSms();
            Need d = new Need();
            Bll_Need bll = new Bll_Need();
            d = bll.SearchById(id);
            frmTextSms.Number = d.Number;
            frmTextSms.N = d.FullName;
            frm.TextBoxText.Text = "با توجه به درخواست شما جهت" + " " + d.KindNeed+"-"+d.UserName + " " + "در تاریخ" + d.ShDate + "موردی با مشخصات مشابه به این بنگاه سپرده شده است.جهت تعیین تکلیف در اسرع وقت به بنگاه مراجعه فرمایید.";
            frm.ShowDialog();
        }

        private void بازبینیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_Need bll = new Bll_Need();
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = bll.Read();
            DGV();
        }

        private void جستجویمواردمشابهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_Need bll = new Bll_Need();
            DataGridView1.DataSource = null;
            Need n = new Need();
            n = bll.SearchById(id);
            DataGridView1.DataSource = bll.Search(n.KindNeed, n.KindUser, n.UserName, "");
            DGV();
        }
    }
}
