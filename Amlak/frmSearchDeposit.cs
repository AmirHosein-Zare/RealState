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
    public partial class frmSearchDeposit : Form
    {
        public frmSearchDeposit()
        {
            InitializeComponent();
        }
        Bll_Deposit bll = new Bll_Deposit();
        string UserName = "";
        public void DGV()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Columns["id"].HeaderText = "کد کاربر";
            dataGridView1.Columns["FullName"].HeaderText = "نام و نام خانوادگی";
            dataGridView1.Columns["Number"].HeaderText = "شماره تماس";
            dataGridView1.Columns["KindDeposit"].HeaderText = "نوع تقاضا";
            dataGridView1.Columns["KindUser"].HeaderText = "نوع کاربری";
            dataGridView1.Columns["Grade"].HeaderText = "طبقه";
            dataGridView1.Columns["UserName"].HeaderText = "نام کاربری";
            dataGridView1.Columns["Foundation"].HeaderText = "زیربنا";
            dataGridView1.Columns["Room"].HeaderText = "خواب";
            dataGridView1.Columns["Meter"].HeaderText = "متراژ";
            dataGridView1.Columns["Address"].HeaderText = "آدرس";
            dataGridView1.Columns["Explain"].Visible = false;
            dataGridView1.Columns["Parking"].HeaderText = "پارکینگ";
            dataGridView1.Columns["Elavator"].HeaderText = "آسانسور";
            dataGridView1.Columns["Store"].HeaderText = "انباری";
            dataGridView1.Columns["RemoteDoor"].HeaderText = "درب ریموت";
            dataGridView1.Columns["FullAmount"].HeaderText = "مبلغ کل";
            dataGridView1.Columns["MeterAmount"].HeaderText = "مبلغ هر متر";
            dataGridView1.Columns["MortgageAmount"].HeaderText = "مبلغ رهن";
            dataGridView1.Columns["RentAmount"].HeaderText = "مبلغ اجاره";
            dataGridView1.Columns["Change"].HeaderText = "معاوضه";
            dataGridView1.Columns["ShDate"].Visible = false;
            dataGridView1.Columns["MDate"].Visible = false;
            dataGridView1.Columns["PictureAddress1"].Visible = false;
            dataGridView1.Columns["PictureAddress2"].Visible = false;
            dataGridView1.Columns["PictureAddress3"].Visible = false;
            dataGridView1.Columns["XLocation"].Visible = false;
            dataGridView1.Columns["YLocation"].Visible = false;
        }
        public void clearControl()
        {
            TextBoxAddress.Clear();
            TextBoxF2.Text = "0";
            TextBoxFullA.Text = "0";
            TextBoxId.Clear();
            TextBoxMeter.Text = "0";
            TextBoxMeterA.Text = "0";
            TextBoxMortgage.Text = "0";
            TextBoxNumber.Clear();
            TextBoxRent.Text = "0";
            TextBoxRoom.Text = "0";
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextBoxNumber.Text.Trim().Length>0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bll.SearchByNumber(TextBoxNumber.Text);
                DGV();
            }
            else if (TextBoxId.Text.Trim().Length>0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bll.SearchId(int.Parse(TextBoxId.Text));
                DGV();
            }
            if (ComboBoxBusiness.Visible == true)
            {
                UserName = ComboBoxBusiness.Text;
            }
            else if (ComboBoxGround.Visible == true)
            {
                UserName = ComboBoxGround.Text;
            }
            else if (ComboBoxHome.Visible == true)
            {
                UserName = ComboBoxHome.Text;
            }
            if (ComboBoxKDeposit.Text.Trim() == "فروش" && (ComboBoxKUser.Text == "تجاری" || ComboBoxKUser.Text == "زمین"))
            {
                if (TextBoxFullA.Text == "0" && TextBoxMeterA.Text == "0" && TextBoxMeter.Text == "0")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bll.Search(ComboBoxKDeposit.Text, ComboBoxKUser.Text, UserName, TextBoxAddress.Text);
                    DGV();
                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bll.Search(ComboBoxKDeposit.Text, ComboBoxKUser.Text, UserName, TextBoxAddress.Text, long.Parse(TextBoxFullA.Text.Replace(",", "")), long.Parse(TextBoxMeterA.Text.Replace(",", "")), int.Parse(TextBoxMeter.Text));
                    DGV();
                }
            }
            else if (ComboBoxKDeposit.Text.Trim() == "فروش"  && ComboBoxKUser.Text == "مسکونی")
            {
                if (TextBoxFullA.Text != "0" || TextBoxMeterA.Text != "0" || TextBoxMeter.Text != "0" || TextBoxRoom.Text != "0" || TextBoxF2.Text != "0")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bll.Search(ComboBoxKDeposit.Text, ComboBoxKUser.Text, UserName, TextBoxAddress.Text, long.Parse(TextBoxFullA.Text.Replace(",", "")), long.Parse(TextBoxMeterA.Text.Replace(",", "")), int.Parse(TextBoxMeter.Text), int.Parse(TextBoxF2.Text), int.Parse(TextBoxRoom.Text));
                    DGV();
                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bll.Search(ComboBoxKDeposit.Text, ComboBoxKUser.Text, UserName, TextBoxAddress.Text);
                    DGV();
                }
            }
            else if ((ComboBoxKDeposit.Text.Trim() == "رهن و اجاره" || ComboBoxKDeposit.Text.Trim() == "رهن کامل" || ComboBoxKDeposit.Text.Trim() == "اجاره") && (ComboBoxKUser.Text == "تجاری" || ComboBoxKUser.Text == "زمین"))
            {
                TextBoxF2.Enabled = false;
                TextBoxRoom.Enabled = false;
                if (TextBoxMortgage.Text != "0" || TextBoxRent.Text != "0" || TextBoxMeter.Text != "0")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bll.Search2(ComboBoxKDeposit.Text, ComboBoxKUser.Text, UserName, TextBoxAddress.Text, long.Parse(TextBoxMortgage.Text.Replace(",", "")), long.Parse(TextBoxRent.Text.Replace(",", "")), int.Parse(TextBoxMeter.Text.Replace(",", "")));
                    DGV();
                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bll.Search(ComboBoxKDeposit.Text, ComboBoxKUser.Text, UserName, TextBoxAddress.Text);
                    DGV();
                }
            }
            else if ((ComboBoxKDeposit.Text.Trim() == "رهن و اجاره" || ComboBoxKDeposit.Text.Trim() == "رهن کامل" || ComboBoxKDeposit.Text.Trim() == "اجاره") && ComboBoxKUser.Text == "مسکونی")
            {
                if (TextBoxMortgage.Text != "0" || TextBoxRent.Text != "0" || TextBoxMeter.Text != "0" || TextBoxRoom.Text != "0" || TextBoxF2.Text != "0")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bll.Search2(ComboBoxKDeposit.Text, ComboBoxKUser.Text, UserName, TextBoxAddress.Text, long.Parse(TextBoxMortgage.Text.Replace(",", "")), long.Parse(TextBoxRent.Text.Replace(",", "")), int.Parse(TextBoxMeter.Text), Convert.ToInt32(TextBoxF2.Text), int.Parse(TextBoxRoom.Text));
                    DGV();
                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bll.Search(ComboBoxKDeposit.Text, ComboBoxKUser.Text, UserName, TextBoxAddress.Text);
                    DGV();
                }
            }
            ComboBoxKDeposit.SelectedIndex = -1;
            ComboBoxKUser.SelectedIndex = -1;
            ComboBoxBusiness.SelectedIndex = -1;
            ComboBoxGround.SelectedIndex = -1;
            ComboBoxHome.SelectedIndex = -1;
            clearControl();
        }

        private void frmSearchDeposit_Load(object sender, EventArgs e)
        {
            Bll_Deposit bll = new Bll_Deposit();
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

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_Deposit bll = new Bll_Deposit();
            bll.Delete(id);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll.ReadAll();
            DGV();
        }

        private void نمایشاینموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSave_Deposit_Show f = new frmSave_Deposit_Show();
            Deposit n = new Deposit();
            Bll_Deposit bll = new Bll_Deposit();
            n = bll.SearchById(id);
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

        private void TextBoxId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBoxMeter_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBoxRoom_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBoxF2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBoxMeterA_KeyPress(object sender, KeyPressEventArgs e)
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
        public void enabletextbox()
        {
            TextBoxMortgage.Enabled = true;
            TextBoxRent.Enabled = true;
            TextBoxFullA.Enabled = true;
            TextBoxMeterA.Enabled = true;
        }

        private void ComboBoxKDeposit_Leave(object sender, EventArgs e)
        {
            enabletextbox();
            if (ComboBoxKDeposit.Text.Trim() == "فروش" )
            {
                TextBoxMortgage.Enabled = false;
                TextBoxRent.Enabled = false;
            }
            else if (ComboBoxKDeposit.Text == "رهن و اجاره")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
            }
            else if (ComboBoxKDeposit.Text.Trim() == "اجاره")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
                TextBoxMortgage.Enabled = false;
            }
            else if (ComboBoxKDeposit.Text.Trim() == "رهن کامل")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
                TextBoxRent.Enabled = false;
            }
        }
        public void visiblecombo()
        {
            ComboBoxBusiness.Visible = false;
            ComboBoxGround.Visible = false;
            ComboBoxHome.Visible = false;
        }
        public void enableButton()
        {
            TextBoxF2.Enabled = true;
            TextBoxRoom.Enabled = true;
        }
        private void ComboBoxKUser_Leave(object sender, EventArgs e)
        {
            visiblecombo();
            enableButton();
            if (ComboBoxKUser.Text == "مسکونی")
            {
                ComboBoxHome.Visible = true;
                label8.Text = "مسکونی";
            }
            else if (ComboBoxKUser.Text == "زمین")
            {
                ComboBoxGround.Visible = true;
                label8.Text = "زمین";

                TextBoxF2.Enabled = false;
                TextBoxRoom.Enabled = false;
            }
            else if (ComboBoxKUser.Text == "تجاری")
            {
                ComboBoxBusiness.Visible = true;
                label8.Text = "تجاری";
            }
            else if (ComboBoxKUser.Text == "سایر")
            {
                label8.Text = "";
            }
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

        private void TextBoxMeterA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxMeterA.Text.Length > 0)
                {
                    TextBoxMeterA.TextChanged -= TextBoxMeterA_TextChanged;
                    TextBoxMeterA.Text = TextBoxMeterA.Text.Replace(",", "");
                    TextBoxMeterA.Text = String.Format("{0:N0}", long.Parse(TextBoxMeterA.Text));
                    TextBoxMeterA.TextChanged += TextBoxMeterA_TextChanged;
                    TextBoxMeterA.SelectionStart = TextBoxMeterA.Text.Length;
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

        private void ارسالپیامکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTextSms frm = new frmTextSms();
            Deposit d = new Deposit();
            Bll_Deposit bll = new Bll_Deposit();
            d = bll.SearchById(id);
            frmTextSms.Number = d.Number;
            frmTextSms.N = d.FullName;
            frm.TextBoxText.Text = "با توجه به درخواست شما جهت" + " " + d.KindDeposit + "-" + d.UserName + " " + "در تاریخ" + d.ShDate + "موردی با مشخصات مشابه به این بنگاه سپرده شده است.جهت تعیین تکلیف در اسرع وقت به بنگاه مراجعه فرمایید.";
            frm.ShowDialog();
        }

        private void چاپمواردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stiReport1.ClearAllStates();
            stiReport1.RegBusinessObject("SearchDeposit", dataGridView1.DataSource);
            stiReport1.Render();
            stiReport1.Show();
        }

        private void ComboBoxKDeposit_SelectedIndexChanged(object sender, EventArgs e)
        {
            enabletextbox();
            if (ComboBoxKDeposit.Text.Trim() == "فروش")
            {
                TextBoxMortgage.Enabled = false;
                TextBoxRent.Enabled = false;
            }
            else if (ComboBoxKDeposit.Text == "رهن و اجاره")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
            }
            else if (ComboBoxKDeposit.Text.Trim() == "اجاره")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
                TextBoxMortgage.Enabled = false;
            }
            else if (ComboBoxKDeposit.Text.Trim() == "رهن کامل")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
                TextBoxRent.Enabled = false;
            }
        }

        private void ComboBoxKUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            visiblecombo();
            enableButton();
            if (ComboBoxKUser.Text == "مسکونی")
            {
                ComboBoxHome.Visible = true;
                label8.Text = "مسکونی";
            }
            else if (ComboBoxKUser.Text == "زمین")
            {
                ComboBoxGround.Visible = true;
                label8.Text = "زمین";

                TextBoxF2.Enabled = false;
                TextBoxRoom.Enabled = false;
            }
            else if (ComboBoxKUser.Text == "تجاری")
            {
                ComboBoxBusiness.Visible = true;
                label8.Text = "تجاری";
            }
            else if (ComboBoxKUser.Text == "سایر")
            {
                label8.Text = "";
            }
        }
    }
}
