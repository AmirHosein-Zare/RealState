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
    public partial class frmSave_applicant : Form
    {
        public frmSave_applicant()
        {
            InitializeComponent();
        }
        public bool flag = false;
        public void DGV()
        {
            Bll_Need bll = new Bll_Need();
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = bll.dg();
            DataGridView1.ClearSelection();
            DataGridView1.Columns["id"].HeaderText="کد کاربر";
            DataGridView1.Columns["FullName"].HeaderText = "نام و نام خانوادگی";
            DataGridView1.Columns["Number"].HeaderText = "شماره تماس";
            DataGridView1.Columns["ShDate"].Visible=false;
            DataGridView1.Columns["MDate"].Visible = false;
            DataGridView1.Columns["KindNeed"].HeaderText = "نوع تقاضا";
            DataGridView1.Columns["KindUser"].HeaderText = "نوع کاربری";
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
            
        }
        public string UserName1()
        {
            if (ComboBoxBusiness.Visible==true)
            {
                return ComboBoxBusiness.Text;
            }
            else if (ComboBoxGround.Visible==true)
            {
                return ComboBoxGround.Text;
            }
            else if (ComboBoxHome.Visible==true)
            {
                return ComboBoxHome.Text;
            }
            return "";
        }
        string UN;
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if ((ComboBoxKNeed.Text.Trim()).Length==0)
            {
                MessageBox.Show("نوع تقاضا خالی است");
            }
            else if ((ComboBoxKUser.Text.Trim()).Length==0)
            {
                MessageBox.Show("نوع کاربری خالی است");
            }
            else if ((TextBoxMeter.Text.Trim()).Length==0)
            {
                MessageBox.Show("متراژ خالی است ");
                TextBoxMeter.Select();
            }
            else if (TextBoxAddress.Text.Trim().Length==0)
            {
                MessageBox.Show("آدرس خالی است");
                TextBoxAddress.Select();
            }
            else if ((TextBoxFullA.Text.Trim()).Length==0 && TextBoxFullA.Enabled==true)
            {
                MessageBox.Show("مبلغ کل خالی است");
                TextBoxFullA.Select();
            }
            else if ((TextBoxMeterA.Text.Trim()).Length==0 && TextBoxMeterA.Enabled==true)
            {
                MessageBox.Show("مبلغ به ازای هر متر");
                TextBoxMeterA.Select();
            }
            else if ((TextBoxMortgage.Text.Trim()).Length==0 && TextBoxMortgage.Enabled==true)
            {
                MessageBox.Show("مبلغ رهن خالی است");
                TextBoxMortgage.Select();
            }
            else if ((TextBoxRent.Text.Trim()).Length==0 && TextBoxRent.Enabled==true)
            {
                MessageBox.Show("مبلغ اجاره خالی است");
                TextBoxRent.Select();
            }
            else if ((TextBoxFullName.Text.Trim()).Length==0 )
            {
                MessageBox.Show("نام و نام خانوادگی خالی است");
            }
            else if ((TextBoxNumber.Text.Trim()).Length == 0)
            {
                MessageBox.Show("شماره تماس خالی است");
            }
            else if ((ComboBoxBusiness.Text.Trim()).Length==0 && ComboBoxBusiness.Visible==true)
            {
                MessageBox.Show("نوع کاربری تجاری خالی است");
            }
            else if ((ComboBoxGround.Text.Trim()).Length==0 && ComboBoxGround.Visible==true)
            {
                MessageBox.Show("نوع کاربری زمین خالی است");
            }
            else if ((ComboBoxHome.Text.Trim()).Length==0 && ComboBoxHome.Visible==true)
            {
                MessageBox.Show("نوع کاربری مسکونی خالی است");
            }
            else
            {
                if (!flag)
                {
                    Need n = new Need();
                    n.FullName = TextBoxFullName.Text;
                    n.Number = TextBoxNumber.Text;
                    n.KindNeed = ComboBoxKNeed.Text;
                    n.KindUser = ComboBoxKUser.Text;
                    n.UserName = UserName1();
                    n.Foundation = Convert.ToInt32(TextBoxF2.Text);
                    n.Room = Convert.ToByte(TextBoxRoom.Text);
                    n.Meter = Convert.ToInt32(TextBoxMeter.Text);
                    n.Address = TextBoxAddress.Text;
                    PersianDateTime now = PersianDateTime.Now;
                    n.ShDate = now.ToString(PersianDateTimeFormat.Date);
                    DateTime d = DateTime.Now.Date;
                    n.MDate = d;
                    if (TextBoxFullA.Enabled==true)
                    {
                        n.FullAmount = long.Parse(TextBoxFullA.Text.Replace(",", ""));
                    }
                    if (TextBoxMeterA.Enabled==true)
                    {
                        n.MeterAmount = long.Parse(TextBoxMeterA.Text.Replace(",", ""));
                    }
                    if (TextBoxMortgage.Enabled==true)
                    {
                        n.MortgageAmount = long.Parse(TextBoxMortgage.Text.Replace(",", ""));
                    }
                    if (TextBoxRent.Enabled==true)
                    {
                        n.RentAmount = long.Parse(TextBoxRent.Text.Replace(",", ""));
                    }
                    n.Explain = TextBoxExplain.Text;
                    if (CheckBoxParking.Checked)
                    {
                        n.Parking = "دارد";
                    }
                    else
                    {
                        n.Parking = "ندارد";
                    }
                    if (CheckBoxElavator.Checked)
                    {
                        n.Elavator = "دارد";
                    }
                    else
                    {
                        n.Elavator = "ندارد";
                    }
                    if (CheckBoxStore.Checked)
                    {
                        n.Store = "دارد";
                    }
                    else
                    {
                        n.Store = "ندارد";
                    }
                    if (CheckBoxRemote.Checked)
                    {
                        n.RemoteDoor = "دارد";
                    }
                    else
                    {
                        n.RemoteDoor = "ندارد";
                    }
                    Bll_Need bll = new Bll_Need();
                    bll.create(n);
                    if (CheckBoxSms.Checked)
                    {
                        Bll_Sms bll1 = new Bll_Sms();
                        UserSms h = new UserSms();
                        h = bll1.ReturnUser();
                        contact c = new contact();
                        string username = h.UserName;
                        string password = h.Password;
                        string from = h.Number;
                        string to = TextBoxNumber.Text;
                        string text = "آقا/خانم" + " " + TextBoxFullName.Text + "\n" + "درخواست شما جهت " +
                        ComboBoxKNeed.Text + "-" + UN +" "+ "در  " + h.Name + "ثبت گردید." + "اطلاع رسانی های بعدی از طریق همین سامانه انجام می گردد."
                        + "\n" + h.Name;
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
                    }
                    if (CheckBoxContact.Checked)
                    {
                        contact c = new contact();
                        Bll_contact b = new Bll_contact();
                        c.FullName = TextBoxFullName.Text;
                        c.Number = TextBoxNumber.Text;
                        c.Address = TextBoxAddress.Text;
                        b.create(c);
                    }
                    //DataGridView1.DataSource = null;
                    //DataGridView1.DataSource = bll.Read();
                    DGV();
                    ComboBoxKNeed.ResetText();
                    ComboBoxKUser.ResetText();
                    ComboBoxBusiness.ResetText();
                    ComboBoxGround.ResetText();
                    ComboBoxHome.ResetText();
                    TextBoxAddress.Clear();
                    TextBoxExplain.Clear();
                    TextBoxFullName.Clear();
                    TextBoxNumber.Clear();
                    TextBoxRoom.Text = "0";
                    TextBoxRent.Text = "0";
                    TextBoxMortgage.Text = "0";
                    TextBoxFullA.Text = "0";
                    TextBoxMeterA.Text = "0";
                    TextBoxMeter.Text = "0";
                    TextBoxF2.Text = "0";
                    MessageBox.Show("با موفقیت ثبت شد");
                    
                }
                else
                {
                    Need n = new Need();
                    n.FullName = TextBoxFullName.Text;
                    n.Number = TextBoxNumber.Text;
                    n.KindNeed = ComboBoxKNeed.Text;
                    n.KindUser = ComboBoxKUser.Text;
                    n.UserName = UserName1();
                    n.Foundation = Convert.ToInt32(TextBoxF2.Text);
                    n.Room = Convert.ToByte(TextBoxRoom.Text);
                    n.Meter = Convert.ToInt32(TextBoxMeter.Text);
                    n.Address = TextBoxAddress.Text;
                    
                    if (TextBoxFullA.Enabled == true)
                    {
                        n.FullAmount = long.Parse(TextBoxFullA.Text.Replace(",", ""));
                    }
                    if (TextBoxMeterA.Enabled == true)
                    {
                        n.MeterAmount = long.Parse(TextBoxMeterA.Text.Replace(",", ""));
                    }
                    if (TextBoxMortgage.Enabled == true)
                    {
                        n.MortgageAmount = long.Parse(TextBoxMortgage.Text.Replace(",", ""));
                    }
                    if (TextBoxRent.Enabled == true)
                    {
                        n.RentAmount = long.Parse(TextBoxRent.Text.Replace(",", ""));
                    }
                    n.Explain = TextBoxExplain.Text;
                    if (CheckBoxParking.Checked)
                    {
                        n.Parking = "دارد";
                    }
                    else
                    {
                        n.Parking = "ندارد";
                    }
                    if (CheckBoxElavator.Checked)
                    {
                        n.Elavator = "دارد";
                    }
                    else
                    {
                        n.Elavator = "ندارد";
                    }
                    if (CheckBoxStore.Checked)
                    {
                        n.Store = "دارد";
                    }
                    else
                    {
                        n.Store = "ندارد";
                    }
                    if (CheckBoxRemote.Checked)
                    {
                        n.RemoteDoor = "دارد";
                    }
                    else
                    {
                        n.RemoteDoor = "ندارد";
                    }
                    Bll_Need bll = new Bll_Need();
                    bll.Update(n,id);
                    if (CheckBoxContact.Checked)
                    {
                        contact c = new contact();
                        Bll_contact b = new Bll_contact();
                        c.FullName = TextBoxFullName.Text;
                        c.Number = TextBoxNumber.Text;
                        c.Address = TextBoxAddress.Text;
                        b.create(c);
                    }
                    CheckBoxContact.Enabled = true;
                    CheckBoxSms.Enabled = true;
                    //DataGridView1.DataSource = null;
                    //DataGridView1.DataSource = bll.Read();
                    DGV();
                    ComboBoxKNeed.ResetText();
                    ComboBoxKUser.ResetText();
                    ComboBoxBusiness.ResetText();
                    ComboBoxGround.ResetText();
                    ComboBoxHome.ResetText();
                    TextBoxAddress.Clear();
                    TextBoxExplain.Clear();
                    TextBoxFullName.Clear();
                    TextBoxNumber.Clear();
                    TextBoxRoom.Text = "0";
                    TextBoxRent.Text = "0";
                    TextBoxMortgage.Text = "0";
                    TextBoxFullA.Text = "0";
                    TextBoxMeterA.Text = "0";
                    TextBoxMeter.Text = "0";
                    TextBoxF2.Text = "0";
                    ButtonSave.Text = "ثبت";
                    MessageBox.Show("با موفقیت ویرایش شد");
                    flag = false;
                }
            }
        }

        private void TextBoxF2_TextChanged(object sender, EventArgs e)
        {

        }
        public void enabletextbox()
        {
            TextBoxMortgage.Enabled = true;
            TextBoxRent.Enabled = true;
            TextBoxFullA.Enabled = true;
            TextBoxMeterA.Enabled = true;
        }
        private void ComboBox1_Leave(object sender, EventArgs e)
        {
            enabletextbox();
            if (ComboBoxKNeed.Text.Trim()=="خرید" || ComboBoxKNeed.Text=="پیش خرید")
            {
                TextBoxMortgage.Enabled = false;
                TextBoxRent.Enabled = false;
            }
            else if (ComboBoxKNeed.Text=="رهن و اجاره")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
            }
            else if (ComboBoxKNeed.Text.Trim()=="اجاره")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
                TextBoxMortgage.Enabled = false;
            }
            else if (ComboBoxKNeed.Text.Trim()=="رهن کامل")
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
        public void enableControl()
        {
            CheckBoxElavator.Enabled = true;
            CheckBoxParking.Enabled = true;
            CheckBoxRemote.Enabled = true;
            CheckBoxStore.Enabled = true;
            TextBoxF2.Enabled = true;
            TextBoxRoom.Enabled = true;
        }
        private void ComboBox2_Leave(object sender, EventArgs e)
        {
            visiblecombo();
            enableControl();
            if (ComboBoxKUser.Text == "مسکونی")
            {
                ComboBoxHome.Visible = true;
                label8.Text = "مسکونی";
            }
            else if (ComboBoxKUser.Text == "زمین")
            {
                ComboBoxGround.Visible = true;
                label8.Text = "زمین";
                CheckBoxElavator.Enabled = false;
                CheckBoxParking.Enabled = false;
                CheckBoxRemote.Enabled = false;
                CheckBoxStore.Enabled = false;
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
        int id;
        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells["id"].Value);
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBoxContact.Enabled = false;
            CheckBoxSms.Enabled = false;
            flag = true;
            Need n = new Need();
            Bll_Need bll = new Bll_Need();
            n = bll.SearchById(id);
            ComboBoxKNeed.Text = n.KindNeed;
            ComboBoxKUser.Text = n.KindUser;
            TextBoxRoom.Text = Convert.ToString(n.Room);
            TextBoxF2.Text = Convert.ToString(n.Foundation);
            TextBoxMeter.Text = Convert.ToString(n.Meter);
            TextBoxAddress.Text = n.Address;
            TextBoxExplain.Text = n.Explain;
            TextBoxFullA.Text = Convert.ToString(n.FullAmount);
            TextBoxFullName.Text = n.FullName;
            TextBoxNumber.Text = n.Number;
            TextBoxMeterA.Text = Convert.ToString(n.MeterAmount);
            TextBoxMortgage.Text = Convert.ToString(n.MortgageAmount);
            TextBoxRent.Text = Convert.ToString(n.RentAmount);
            if (n.Parking.Trim() == "دارد")
            {
                CheckBoxParking.Checked=true;
            }
            if (n.Elavator.Trim()== "دارد")
            {
                CheckBoxElavator.Checked = true;
            }
            if (n.Store.Trim()== "دارد")
            {
                CheckBoxStore.Checked = true;
            }
            if (n.RemoteDoor.Trim()== "دارد")
            {
                CheckBoxRemote.Checked = true;
            }
            ButtonSave.Text = "به روزرسانی";
            if (n.UserName=="آپارتمان" || n.UserName == "ویلایی" || n.UserName == "کلنگی" || n.UserName == "نیمه ساز" || n.UserName == "سایر")
            {
                ComboBoxHome.Visible = true;
                ComboBoxHome.Text = n.UserName;
            }
            else if (n.UserName == "دفتر" || n.UserName == "مغازه" || n.UserName == "انبار" || n.UserName == "سرقفلی" || n.UserName == "سایر" )
            {
                ComboBoxBusiness.Visible = true;
                ComboBoxBusiness.Text = n.UserName;
            }
            else if(n.UserName == "باغ شهری" || n.UserName == "کشاورزی" || n.UserName == "مسکونی" || n.UserName == "صنعتی-تولیدی" || n.UserName == "تجاری" || n.UserName == "سایر" )
            {
                ComboBoxGround.Visible = true;
                ComboBoxGround.Text = n.UserName;
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_Need bll = new Bll_Need();
            bll.Delete(id);
            DGV();
            MessageBox.Show("با موفقیت حذف شد");
        }

        private void frmSave_applicant_Load(object sender, EventArgs e)
        {
            Bll_Need bll = new Bll_Need();
            //DataGridView1.DataSource = null;
            //DataGridView1.DataSource = bll.Read();
            DGV();
            Bll_Sms s = new Bll_Sms();

            if (s.NumberOfUser() == false)
            {
                CheckBoxSms.Enabled = false;
            }
        }

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

        private void TextBoxNumber_TextChanged(object sender, EventArgs e)
        {

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

        private void نمایشToolStripMenuItem_Click(object sender, EventArgs e)
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
            if (n.Parking.Trim()=="دارد")
            {
                f.CheckBoxParking.Checked = true;

            }
            if (n.Elavator.Trim()=="دارد")
            {
                f.CheckBoxElavator.Checked = true;
            }
            if (n.Store.Trim()=="دارد")
            {
                f.CheckBoxStore.Checked = true;
            }
            if (n.RemoteDoor.Trim()=="دارد")
            {
                f.CheckBoxRemote.Checked = true;
            }
            f.labelExplain.Text = n.Explain;
            f.Show();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            frmSave__ApplicantShowEveryThing f = new frmSave__ApplicantShowEveryThing();
            Bll_Need bll = new Bll_Need();
            f.DataGridView1.DataSource = null;
            f.DataGridView1.DataSource = bll.Read();
            f.DataGridView1.ClearSelection();
            f.DataGridView1.Columns["id"].HeaderText = "کد کاربر";
            f.DataGridView1.Columns["FullName"].Visible=false;
            f.DataGridView1.Columns["Number"].Visible=false;
            f.DataGridView1.Columns["KindNeed"].HeaderText = "نوع تقاضا";
            f.DataGridView1.Columns["KindUser"].Visible=false;
            f.DataGridView1.Columns["UserName"].HeaderText = "نام کاربری";
            f.DataGridView1.Columns["Foundation"].HeaderText = "زیربنا";
            f.DataGridView1.Columns["Room"].HeaderText = "خواب";
            f.DataGridView1.Columns["Meter"].HeaderText = "متراژ";
            f.DataGridView1.Columns["Address"].HeaderText = "آدرس";
            f.DataGridView1.Columns["Explain"].Visible = false;
            f.DataGridView1.Columns["MDate"].Visible = false;
            f.DataGridView1.Columns["ShDate"].Visible = false;
            f.DataGridView1.Columns["Parking"].HeaderText = "پارکینگ";
            f.DataGridView1.Columns["Elavator"].HeaderText = "آسانسور";
            f.DataGridView1.Columns["Store"].HeaderText = "انباری";
            f.DataGridView1.Columns["RemoteDoor"].HeaderText = "درب ریموت";
            f.DataGridView1.Columns["FullAmount"].HeaderText = "مبلغ کل";
            f.DataGridView1.Columns["MeterAmount"].HeaderText = "مبلغ هر متر";           
            f.DataGridView1.Columns["MortgageAmount"].HeaderText = "مبلغ رهن";         
            f.DataGridView1.Columns["RentAmount"].HeaderText = "مبلغ اجاره";
            f.Show();
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

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
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
            frm.Show();
        }

        private void ComboBoxKNeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            enabletextbox();
            if (ComboBoxKNeed.Text.Trim() == "خرید" || ComboBoxKNeed.Text == "پیش خرید")
            {
                TextBoxMortgage.Enabled = false;
                TextBoxRent.Enabled = false;
            }
            else if (ComboBoxKNeed.Text == "رهن و اجاره")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
            }
            else if (ComboBoxKNeed.Text.Trim() == "اجاره")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
                TextBoxMortgage.Enabled = false;
            }
            else if (ComboBoxKNeed.Text.Trim() == "رهن کامل")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
                TextBoxRent.Enabled = false;
            }
        }

        private void ComboBoxKUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            visiblecombo();
            enableControl();
            if (ComboBoxKUser.Text == "مسکونی")
            {
                ComboBoxHome.Visible = true;
                label8.Text = "مسکونی";
            }
            else if (ComboBoxKUser.Text == "زمین")
            {
                ComboBoxGround.Visible = true;
                label8.Text = "زمین";
                CheckBoxElavator.Enabled = false;
                CheckBoxParking.Enabled = false;
                CheckBoxRemote.Enabled = false;
                CheckBoxStore.Enabled = false;
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
