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
using System.IO;

namespace Amlak
{
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }
        OpenFileDialog f = new OpenFileDialog();
        public string SavePic(string code, string filepath)
        {
            string AppPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Pictures\";
            if (Directory.Exists(AppPath) == false)
            {
                Directory.CreateDirectory(AppPath);
            }
            string iName = code + ".jpg";
            try
            {
                //string filepath = f.FileName;
                File.Copy(filepath, AppPath + iName);
            }
            catch (Exception exp)
            {
                MessageBox.Show("خطا در بارگزاری اطلاعات", exp.Message);
            }
            return AppPath + iName;
        }
        public void DGV()
        {
            Bll_Deposit bll = new Bll_Deposit();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll.dg();
            dataGridView1.ClearSelection();
            dataGridView1.Columns["id"].HeaderText = "کد کاربر";
            dataGridView1.Columns["FullName"].HeaderText = "نام و نام خانوادگی";
            dataGridView1.Columns["Number"].HeaderText = "شماره تماس";
            dataGridView1.Columns["KindDeposit"].HeaderText = "نوع تقاضا";
            dataGridView1.Columns["KindUser"].HeaderText = "نوع کاربری";
            dataGridView1.Columns["UserName"].HeaderText = "نام کاربری";
            dataGridView1.Columns["Grade"].HeaderText = "طبقه";
            dataGridView1.Columns["Foundation"].HeaderText = "زیربنا";
            dataGridView1.Columns["Room"].HeaderText = "خواب";
            dataGridView1.Columns["Meter"].HeaderText = "متراژ";
            dataGridView1.Columns["Address"].HeaderText = "آدرس";
            dataGridView1.Columns["Explain"].Visible = false;
            dataGridView1.Columns["Change"].HeaderText = "معاوضه";
            dataGridView1.Columns["Parking"].HeaderText = "پارکینگ";
            dataGridView1.Columns["Elavator"].HeaderText = "آسانسور";
            dataGridView1.Columns["Store"].HeaderText = "انباری";
            dataGridView1.Columns["RemoteDoor"].HeaderText = "درب ریموت";           
            dataGridView1.Columns["FullAmount"].HeaderText = "مبلغ کل";
            dataGridView1.Columns["MeterAmount"].HeaderText = "مبلغ هر متر";
            dataGridView1.Columns["MortgageAmount"].HeaderText = "مبلغ رهن";
            dataGridView1.Columns["RentAmount"].HeaderText = "مبلغ اجاره";
            dataGridView1.Columns["ShDate"].Visible = false;
            dataGridView1.Columns["MDate"].Visible = false;
            dataGridView1.Columns["PictureAddress1"].Visible = false;
            dataGridView1.Columns["PictureAddress2"].Visible = false;
            dataGridView1.Columns["PictureAddress3"].Visible = false;
            dataGridView1.Columns["XLocation"].Visible = false;
            dataGridView1.Columns["YLocation"].Visible = false;
        }
        bool flag = false;
        //pic
        public static string picA;
        public static string Npic;
        public static string picA2;
        public static string Npic2;
        public static string picA3;
        public static string Npic3;
        public static double XLocation=0;
        public static double YLocation=0;
        string UN;
        string TS;
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            
            if ((ComboBoxKDeposit.Text.Trim()).Length==0)
            {
                MessageBox.Show("نوع سپرده خالی است");
            }
            else if ((ComboBoxKuser.Text.Trim()).Length==0)
            {
                MessageBox.Show("نوع کاربری خالی است");
            }
            else if ((TextBoxMeter.Text.Trim()).Length==0)
            {
                MessageBox.Show("متراژ خالی است");
            }
            else if ((TextBoxAddress.Text.Trim()).Length==0)
            {
                MessageBox.Show("آدرس خالی است");
            }
            else if ((TextBoxFullName.Text.Trim()).Length==0)
            {
                MessageBox.Show("نام و نام خانوادگی خالی است");
            }
            else if ((TextBoxNumber.Text.Trim()).Length==0)
            {
                MessageBox.Show("شماره تماس خالی است");
            }
            else if ((TextBoxFullA.Text.Trim()).Length == 0 && TextBoxFullA.Enabled == true)
            {
                MessageBox.Show("مبلغ کل خالی است");
                TextBoxFullA.Select();
            }
            else if ((TextBoxMeterA.Text.Trim()).Length == 0 && TextBoxMeterA.Enabled == true)
            {
                MessageBox.Show("مبلغ به ازای هر متر");
                TextBoxMeterA.Select();
            }
            else if ((TextBoxMortgage.Text.Trim()).Length == 0 && TextBoxMortgage.Enabled == true)
            {
                MessageBox.Show("مبلغ رهن خالی است");
                TextBoxMortgage.Select();
            }
            else if ((TextBoxRent.Text.Trim()).Length == 0 && TextBoxRent.Enabled == true)
            {
                MessageBox.Show("مبلغ اجاره خالی است");
                TextBoxRent.Select();
            }
            else if ((ComboBoxBusiness.Text.Trim()).Length == 0 && ComboBoxBusiness.Visible == true)
            {
                MessageBox.Show("نوع کاربری تجاری خالی است");
            }
            else if ((ComboBoxGround.Text.Trim()).Length == 0 && ComboBoxGround.Visible == true)
            {
                MessageBox.Show("نوع کاربری زمین خالی است");
            }
            else if ((ComboBoxHome.Text.Trim()).Length == 0 && ComboBoxHome.Visible == true)
            {
                MessageBox.Show("نوع کاربری مسکونی خالی است");
            }
            else
            {
                if (!flag)
                {
                    Deposit d = new Deposit();
                    Bll_Deposit bll = new Bll_Deposit();
                    d.KindDeposit = ComboBoxKDeposit.Text;
                    d.KindUser = ComboBoxKuser.Text;
                    if (ComboBoxBusiness.Visible == true)
                    {
                        d.UserName = ComboBoxBusiness.Text;
                        UN = ComboBoxBusiness.Text;
                    }
                    else if (ComboBoxGround.Visible == true)
                    {
                        d.UserName = ComboBoxGround.Text;
                        UN = ComboBoxGround.Text;
                    }
                    else if (ComboBoxHome.Visible==true)
                    {
                        d.UserName = ComboBoxHome.Text;
                        UN = ComboBoxHome.Text;
                    }
                    d.FullName = TextBoxFullName.Text;
                    d.Number = TextBoxNumber.Text;
                    d.Grade = TextBoxGrade.Text;
                    d.Foundation = Convert.ToInt32(TextBoxF.Text);
                    d.Meter = Convert.ToInt32(TextBoxMeter.Text);
                    d.Room = Convert.ToByte(TextBoxRoom.Text);
                    d.Address = TextBoxAddress.Text;
                    d.Explain = TextBoxExplain.Text;
                    if (Npic!=null)
                    {
                        d.PictureAddress1 = SavePic(Npic,picA);
                    }
                    if (Npic2!=null)
                    {
                        d.PictureAddress2 = SavePic(Npic2, picA2);
                    }
                    if (Npic3!=null)
                    {
                        d.PictureAddress3 = SavePic(Npic3, picA3);
                    }
                    d.XLocation = XLocation;
                    d.YLocation = YLocation;
                    PersianDateTime now = PersianDateTime.Now;
                    DateTime d1 = DateTime.Now.Date;
                    d.MDate = d1;
                    d.ShDate = now.ToString(PersianDateTimeFormat.Date);
                    if (TextBoxFullA.Enabled==true)
                    {
                        d.FullAmount = long.Parse(TextBoxFullA.Text.Replace(",", ""));
                    }
                    if (TextBoxMeterA.Enabled==true)
                    {
                        d.MeterAmount = long.Parse(TextBoxMeterA.Text.Replace(",", ""));
                    }
                    if (TextBoxRent.Enabled==true)
                    {
                        d.RentAmount = long.Parse(TextBoxRent.Text.Replace(",", ""));
                    }
                    if (TextBoxMortgage.Enabled==true)
                    {
                        d.MortgageAmount = long.Parse(TextBoxMortgage.Text.Replace(",", ""));
                    }
  
                    if (CheckBoxParking.Checked)
                    {
                        d.Parking = "دارد";
                    }
                    else
                    {
                        d.Parking = "ندارد";
                    }
                    if (CheckBoxChange.Checked)
                    {
                        d.Change = "هست";
                    }
                    else
                    {
                        d.Change = "نیست";
                    }
                    if (CheckBoxElavator.Checked)
                    {
                        d.Elavator = "دارد";
                    }
                    else
                    {
                        d.Elavator = "ندارد";
                    }
                    if (CheckBoxRemote.Checked)
                    {
                        d.RemoteDoor = "دارد";
                    }
                    else
                    {
                        d.RemoteDoor = "ندارد";
                    }
                    if (CheckBoxStore.Checked)
                    {
                        d.Store = "دارد";
                    }
                    else
                    {
                        d.Store = "ندارد";
                    }
                    bll.create(d);
                    if (CheckBoxSms.Checked)
                    {
                        Bll_Sms bll1 = new Bll_Sms();
                        UserSms h = new UserSms();
                        h = bll1.ReturnUser();
                        TS = "آقا/خانم" + " " + TextBoxFullName.Text + "\n" + "درخواست شما جهت " +
                                    ComboBoxKDeposit.Text + "-" + UN + "در  " + h.Name + "ثبت گردید." + "اطلاع رسانی های بعدی از طریق همین سامانه انجام می گردد."
                                    + "\n" + h.Name;
                        string username = h.UserName;
                        string password = h.Password;
                        string from = h.Number;
                        string to = TextBoxNumber.Text;
                        string text = "آقا/خانم" + " " + TextBoxFullName.Text + "\n" + "درخواست شما جهت " +
                        ComboBoxKDeposit.Text + "-" + UN +" "+ "در" + h.Name + "ثبت گردید." + "اطلاع رسانی های بعدی از طریق همین سامانه انجام می گردد."
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
                    //dataGridView1.DataSource = null;
                    //dataGridView1.DataSource = bll.ReadAll();
                    DGV();
                    ComboBoxBusiness.Visible = false;
                    ComboBoxGround.Visible = false;
                    ComboBoxHome.Visible = false;
                    TextBoxAddress.Clear();
                    TextBoxExplain.Clear();
                    TextBoxF.Text="0";
                    TextBoxFullA.Text = "0";
                    TextBoxFullName.Clear();
                    TextBoxGrade.Text = "0";
                    TextBoxMeter.Text = "0";
                    TextBoxMeterA.Text = "0";
                    TextBoxMortgage.Text = "0";
                    TextBoxNumber.Clear();
                    TextBoxRent.Text = "0";
                    TextBoxRoom.Text = "0";
                    CheckBoxChange.Checked = false;
                    CheckBoxElavator.Checked = false;
                    CheckBoxParking.Checked = false;
                    CheckBoxRemote.Checked = false;
                    CheckBoxStore.Checked = false;
                    enabletextbox();
                    labelUser.Visible = false;
                    MessageBox.Show("با موفقیت ثبت شد");
                    
                }
                else
                {
                    Deposit d = new Deposit();
                    Bll_Deposit bll = new Bll_Deposit();
                    d.KindDeposit = ComboBoxKDeposit.Text;
                    d.KindUser = ComboBoxKuser.Text;
                    if (ComboBoxBusiness.Visible == true)
                    {
                        d.UserName = ComboBoxBusiness.Text;
                    }
                    else if (ComboBoxGround.Visible == true)
                    {
                        d.UserName = ComboBoxGround.Text;
                    }
                    else if (ComboBoxHome.Visible == true)
                    {
                        d.UserName = ComboBoxHome.Text;
                    }
                    d.FullName = TextBoxFullName.Text;
                    d.Number = TextBoxNumber.Text;
                    d.Grade = TextBoxGrade.Text;
                    d.Foundation = Convert.ToInt32(TextBoxF.Text);
                    d.Meter = Convert.ToInt32(TextBoxMeter.Text);
                    d.Room = Convert.ToByte(TextBoxRoom.Text);
                    d.Address = TextBoxAddress.Text;
                    d.Explain = TextBoxExplain.Text;
                    d.FullAmount = long.Parse(TextBoxFullA.Text.Replace(",", ""));
                    d.MeterAmount = long.Parse(TextBoxMeterA.Text.Replace(",", ""));
                    d.MortgageAmount = long.Parse(TextBoxMortgage.Text.Replace(",", ""));
                    d.RentAmount = long.Parse(TextBoxRent.Text.Replace(",", ""));
                    if (Npic != null)
                    {
                        d.PictureAddress1 = SavePic(Npic, picA);
                    }
                    if (Npic2 != null)
                    {
                        d.PictureAddress2 = SavePic(Npic2, picA2);
                    }
                    if (Npic3 != null)
                    {
                        d.PictureAddress3 = SavePic(Npic3, picA3);
                    }
                    if (CheckBoxParking.Checked)
                    {
                        d.Parking = "دارد";
                    }
                    else
                    {
                        d.Parking = "ندارد";
                    }
                    if (CheckBoxChange.Checked)
                    {
                        d.Change = "هست";
                    }
                    else
                    {
                        d.Change = "نیست";
                    }
                    if (CheckBoxElavator.Checked)
                    {
                        d.Elavator = "دارد";
                    }
                    else
                    {
                        d.Elavator = "ندارد";
                    }
                    if (CheckBoxRemote.Checked)
                    {
                        d.RemoteDoor = "دارد";
                    }
                    else
                    {
                        d.RemoteDoor = "ندارد";
                    }
                    if (CheckBoxStore.Checked)
                    {
                        d.Store = "دارد";
                    }
                    else
                    {
                        d.Store = "ندارد";
                    }
                    bll.Update(id, d);
                    if (CheckBoxContact.Checked)
                    {
                        contact c = new contact();
                        Bll_contact b = new Bll_contact();
                        c.FullName = TextBoxFullName.Text;
                        c.Number = TextBoxNumber.Text;
                        b.create(c);
                    }
                    //dataGridView1.DataSource = null;
                    //dataGridView1.DataSource = bll.ReadAll();
                    CheckBoxContact.Enabled = true;
                    CheckBoxSms.Enabled = true;
                    DGV();
                    flag = false;
                    ButtonSave.Text = "ثبت";
                    ComboBoxBusiness.Visible = false;
                    ComboBoxGround.Visible = false;
                    ComboBoxHome.Visible = false;
                    TextBoxAddress.Clear();
                    TextBoxExplain.Clear();
                    TextBoxF.Text = "0";
                    TextBoxFullA.Text = "0";
                    TextBoxFullName.Clear();
                    TextBoxGrade.Text = "0";
                    TextBoxMeter.Text = "0";
                    TextBoxMeterA.Text = "0";
                    TextBoxMortgage.Text = "0";
                    TextBoxNumber.Clear();
                    TextBoxRent.Text = "0";
                    TextBoxRoom.Text = "0";
                    CheckBoxChange.Checked = false;
                    CheckBoxElavator.Checked = false;
                    CheckBoxParking.Checked = false;
                    CheckBoxRemote.Checked = false;
                    CheckBoxStore.Checked = false;
                    enabletextbox();
                    labelUser.Visible = false;
                    MessageBox.Show("با موفقیت ویرایش شد");
                }
            }
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_Deposit bll = new Bll_Deposit();
            Deposit n = new Deposit();
            CheckBoxSms.Enabled = false;
            CheckBoxContact.Enabled = false;
            flag = true;
            ButtonSave.Text = "به روزرسانی";
            n = bll.SearchById(id);
            ComboBoxKDeposit.Text = n.KindDeposit;
            ComboBoxKuser.Text = n.KindUser;
            TextBoxRoom.Text = Convert.ToString(n.Room);
            TextBoxF.Text = Convert.ToString(n.Foundation);
            TextBoxMeter.Text = Convert.ToString(n.Meter);
            TextBoxGrade.Text = n.Grade;
            TextBoxAddress.Text = n.Address;
            TextBoxExplain.Text = n.Explain;
            TextBoxFullA.Text = Convert.ToString(n.FullAmount);
            TextBoxFullName.Text = n.FullName;
            TextBoxNumber.Text = n.Number;
            TextBoxMeterA.Text = Convert.ToString(n.MeterAmount);
            TextBoxMortgage.Text = Convert.ToString(n.MortgageAmount);
            TextBoxRent.Text = Convert.ToString(n.RentAmount);
            if (n.Change.Trim()=="هست")
            {
                CheckBoxChange.Checked = true;
            }
            if (n.Parking.Trim() == "دارد")
            {
                CheckBoxParking.Checked = true;
            }
            if (n.Elavator.Trim() == "دارد")
            {
                CheckBoxElavator.Checked = true;
            }
            if (n.Store.Trim() == "دارد")
            {
                CheckBoxStore.Checked = true;
            }
            if (n.RemoteDoor.Trim() == "دارد")
            {
                CheckBoxRemote.Checked = true;
            }
            if (n.KindUser.Trim()=="مسکونی")
            {
                ComboBoxHome.Visible = true;
                ComboBoxHome.Text = n.UserName;
            }
            else if (n.KindUser.Trim()=="زمین")
            {
                ComboBoxGround.Visible = true;
                ComboBoxGround.Text = n.UserName;
            }
            else if (n.KindUser.Trim()=="تجاری")
            {
                ComboBoxBusiness.Visible = true;
                ComboBoxBusiness.Text = n.UserName;
            }
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

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            Bll_Deposit bll = new Bll_Deposit();
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = bll.ReadAll();
            DGV();
            Bll_Sms s = new Bll_Sms();
            
            if (s.NumberOfUser() == false)
            {
                CheckBoxSms.Enabled = false;
            }
        }
        public void enabletextbox()
        {
            TextBoxMortgage.Enabled = true;
            TextBoxFullA.Enabled = true;
            TextBoxMeterA.Enabled = true;
            TextBoxRent.Enabled = true;
        }
        private void ComboBoxKDeposit_Leave(object sender, EventArgs e)
        {
            enabletextbox();
            enableControl();
            if (ComboBoxKDeposit.Text.Trim()=="فروش")
            {
                TextBoxMortgage.Enabled = false;
                TextBoxRent.Enabled = false;
            }
            else if (ComboBoxKDeposit.Text.Trim()=="رهن و اجاره")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
            }
            else if (ComboBoxKDeposit.Text.Trim()=="رهن کامل")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
                TextBoxRent.Enabled = false;
            }
            else if (ComboBoxKDeposit.Text.Trim()=="اجاره")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
                TextBoxMortgage.Enabled = false;
            }

        }
        public void enableControl()
        {
            TextBoxGrade.Enabled = true;
            TextBoxRoom.Enabled = true;
            CheckBoxElavator.Enabled = true;
            CheckBoxParking.Enabled = true;
            CheckBoxRemote.Enabled = true;
            CheckBoxStore.Enabled = true;
            TextBoxF.Enabled = true;
        }
        private void ComboBoxKuser_Leave(object sender, EventArgs e)
        {
            ComboBoxBusiness.Visible = false;
            ComboBoxGround.Visible = false;
            ComboBoxHome.Visible = false;
            enableControl();
            if (ComboBoxKuser.Text.Trim()=="مسکونی")
            {
                ComboBoxHome.Visible = true;
                labelUser.Visible = true;
                labelUser.Text = "مسکونی";
            }
            else if (ComboBoxKuser.Text.Trim()=="زمین")
            {
                ComboBoxGround.Visible = true;
                labelUser.Visible = true;
                labelUser.Text = "زمین";
                TextBoxGrade.Enabled = false;
                TextBoxRoom.Enabled = false;
                CheckBoxElavator.Enabled = false;
                CheckBoxParking.Enabled = false;
                CheckBoxRemote.Enabled = false;
                CheckBoxStore.Enabled = false;
                TextBoxF.Enabled = false;
            }
            else if (ComboBoxKuser.Text.Trim()=="تجاری")
            {
                ComboBoxBusiness.Visible = true;
                labelUser.Visible = true;
                labelUser.Text = "تجاری";
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_Deposit bll = new Bll_Deposit();
            bll.Delete(id);
            MessageBox.Show("با موفقیت حذف شد");
            DGV();
        }

        private void TextBoxGrade_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBoxF_KeyPress(object sender, KeyPressEventArgs e)
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
            if (n.Change.Trim()=="هست")
            {
                f.gunaCheckBox1.Checked = true;
            }
            f.labelExplain.Text = n.Explain;
            f.Show();
        }

        private void ButtonShowEvery_Click(object sender, EventArgs e)
        {
            frmSave_DepositShowEvery f = new frmSave_DepositShowEvery();
            Bll_Deposit bll = new Bll_Deposit();
            f.DataGridView1.DataSource = null;
            f.DataGridView1.DataSource = bll.ReadAll();
            f.DataGridView1.ClearSelection();
            f.DataGridView1.Columns["id"].HeaderText = "کد کاربر";
            f.DataGridView1.Columns["FullName"].Visible=false;
            f.DataGridView1.Columns["Number"].Visible = false;
            f.DataGridView1.Columns["KindDeposit"].HeaderText = "نوع تقاضا";
            f.DataGridView1.Columns["KindUser"].Visible = false;
            f.DataGridView1.Columns["UserName"].HeaderText = "نام کاربری";
            f.DataGridView1.Columns["Foundation"].HeaderText = "زیربنا";
            f.DataGridView1.Columns["Room"].HeaderText = "خواب";
            f.DataGridView1.Columns["Meter"].HeaderText = "متراژ";
            f.DataGridView1.Columns["Address"].HeaderText = "آدرس";
            f.DataGridView1.Columns["Explain"].Visible = false;
            f.DataGridView1.Columns["Parking"].HeaderText = "پارکینگ";
            f.DataGridView1.Columns["Elavator"].HeaderText = "آسانسور";
            f.DataGridView1.Columns["Store"].HeaderText = "انباری";
            f.DataGridView1.Columns["RemoteDoor"].HeaderText = "درب ریموت";
            f.DataGridView1.Columns["FullAmount"].HeaderText = "مبلغ کل";
            f.DataGridView1.Columns["MeterAmount"].HeaderText = "مبلغ هر متر";
            f.DataGridView1.Columns["MortgageAmount"].HeaderText = "مبلغ رهن";
            f.DataGridView1.Columns["RentAmount"].HeaderText = "مبلغ اجاره";
            f.DataGridView1.Columns["Change"].HeaderText = "معاوضه";
            f.DataGridView1.Columns["Grade"].HeaderText = "طبقه";
            f.DataGridView1.Columns["ShDate"].Visible = false;
            f.DataGridView1.Columns["MDate"].Visible = false;
            f.DataGridView1.Columns["PictureAddress1"].Visible = false;
            f.DataGridView1.Columns["PictureAddress2"].Visible = false;
            f.DataGridView1.Columns["PictureAddress3"].Visible = false;
            f.DataGridView1.Columns["XLocation"].Visible = false;
            f.DataGridView1.Columns["YLocation"].Visible = false;
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

        private void ButtonSavePic_Click(object sender, EventArgs e)
        {
            frmSavePic f = new frmSavePic();
            f.ShowDialog();
        }

        private void ButtonMap_Click(object sender, EventArgs e)
        {
            frmSaveMap frm = new frmSaveMap();
            frm.Show();
        }

        private void ارسالپیامکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTextSms frm = new frmTextSms();
            Deposit d = new Deposit();
            Bll_Deposit bll = new Bll_Deposit();
            d = bll.SearchById(id);
            frmTextSms.Number = d.Number;
            frmTextSms.N = d.FullName;
            frm.Show();
        }

        private void جستجویمواردمشابهToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxKDeposit_SelectedIndexChanged(object sender, EventArgs e)
        {
            enabletextbox();
            enableControl();
            if (ComboBoxKDeposit.Text.Trim() == "فروش")
            {
                TextBoxMortgage.Enabled = false;
                TextBoxRent.Enabled = false;
            }
            else if (ComboBoxKDeposit.Text.Trim() == "رهن و اجاره")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
            }
            else if (ComboBoxKDeposit.Text.Trim() == "رهن کامل")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
                TextBoxRent.Enabled = false;
            }
            else if (ComboBoxKDeposit.Text.Trim() == "اجاره")
            {
                TextBoxFullA.Enabled = false;
                TextBoxMeterA.Enabled = false;
                TextBoxMortgage.Enabled = false;
            }
        }

        private void ComboBoxKuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxBusiness.Visible = false;
            ComboBoxGround.Visible = false;
            ComboBoxHome.Visible = false;
            enableControl();
            if (ComboBoxKuser.Text.Trim() == "مسکونی")
            {
                ComboBoxHome.Visible = true;
                labelUser.Visible = true;
                labelUser.Text = "مسکونی";
            }
            else if (ComboBoxKuser.Text.Trim() == "زمین")
            {
                ComboBoxGround.Visible = true;
                labelUser.Visible = true;
                labelUser.Text = "زمین";
                TextBoxGrade.Enabled = false;
                TextBoxRoom.Enabled = false;
                CheckBoxElavator.Enabled = false;
                CheckBoxParking.Enabled = false;
                CheckBoxRemote.Enabled = false;
                CheckBoxStore.Enabled = false;
                TextBoxF.Enabled = false;
            }
            else if (ComboBoxKuser.Text.Trim() == "تجاری")
            {
                ComboBoxBusiness.Visible = true;
                labelUser.Visible = true;
                labelUser.Text = "تجاری";
            }
        }
    }
}
