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
    public partial class frmSendSms : Form
    {
        public frmSendSms()
        {
            InitializeComponent();
        }
        public void DGV()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["Text"].HeaderText = "متن";
            dataGridView1.Columns["Text"].Width = 500;
        }
        public void DGV3()
        {
            //Bll_Need bll = new Bll_Need();
            //dataGridView3.DataSource = null;
            //dataGridView3.DataSource = bll.dg();
            dataGridView3.ClearSelection();
            dataGridView3.Columns["id"].HeaderText = "کد کاربر";
            dataGridView3.Columns["FullName"].HeaderText = "نام و نام خانوادگی";
            dataGridView3.Columns["Number"].HeaderText = "شماره تماس";
            dataGridView3.Columns["ShDate"].HeaderText = "تاریخ مراجعه";
            dataGridView3.Columns["MDate"].Visible = false;
            dataGridView3.Columns["KindNeed"].HeaderText = "نوع تقاضا";
            dataGridView3.Columns["KindUser"].Visible = false;
            dataGridView3.Columns["UserName"].HeaderText = "نام کاربری";
            dataGridView3.Columns["Foundation"].Visible = false;
            dataGridView3.Columns["Room"].Visible = false;
            dataGridView3.Columns["Meter"].Visible = false;
            dataGridView3.Columns["Address"].Visible = false;
            dataGridView3.Columns["Explain"].Visible = false;
            dataGridView3.Columns["Parking"].Visible = false;
            dataGridView3.Columns["Elavator"].Visible = false;
            dataGridView3.Columns["Store"].Visible = false;
            dataGridView3.Columns["RemoteDoor"].Visible = false;
            dataGridView3.Columns["FullAmount"].Visible = false;
            dataGridView3.Columns["MeterAmount"].Visible = false;
            dataGridView3.Columns["MortgageAmount"].Visible = false;
            dataGridView3.Columns["RentAmount"].Visible = false;

        }
        public void DGV2()
        {
            Bll_Deposit bll = new Bll_Deposit();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll.dg();
            dataGridView5.ClearSelection();
            dataGridView5.Columns["id"].HeaderText = "کد کاربر";
            dataGridView5.Columns["FullName"].HeaderText = "نام و نام خانوادگی";
            dataGridView5.Columns["Number"].HeaderText = "شماره تماس";
            dataGridView5.Columns["KindDeposit"].HeaderText = "نوع تقاضا";
            dataGridView5.Columns["KindUser"].Visible = false;
            dataGridView5.Columns["UserName"].HeaderText = "نام کاربری";
            dataGridView5.Columns["Grade"].Visible = false;
            dataGridView5.Columns["Foundation"].Visible = false;
            dataGridView5.Columns["Room"].Visible = false;
            dataGridView5.Columns["Meter"].Visible = false;
            dataGridView5.Columns["Address"].Visible = false;
            dataGridView5.Columns["Explain"].Visible = false;
            dataGridView5.Columns["Change"].Visible = false;
            dataGridView5.Columns["Parking"].Visible = false;
            dataGridView5.Columns["Elavator"].Visible = false;
            dataGridView5.Columns["Store"].Visible = false;
            dataGridView5.Columns["RemoteDoor"].Visible = false;
            dataGridView5.Columns["FullAmount"].Visible = false;
            dataGridView5.Columns["MeterAmount"].Visible = false;
            dataGridView5.Columns["MortgageAmount"].Visible = false;
            dataGridView5.Columns["RentAmount"].Visible = false;
            dataGridView5.Columns["ShDate"].HeaderText = "تاریخ مراجعه";
            dataGridView5.Columns["MDate"].Visible = false;
            dataGridView5.Columns["PictureAddress1"].Visible = false;
            dataGridView5.Columns["PictureAddress2"].Visible = false;
            dataGridView5.Columns["PictureAddress3"].Visible = false;
            dataGridView5.Columns["XLocation"].Visible = false;
            dataGridView5.Columns["YLocation"].Visible = false;
        }
        private void frmSendSms_Load(object sender, EventArgs e)
        {
            Bll_Deposit d = new Bll_Deposit();
            Bll_Need n = new Bll_Need();
            dataGridView5.DataSource = null;
            dataGridView5.DataSource = d.NeedSms();
            DGV2();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = n.NeedSms();
            DGV3();
            Bll_SmsText bll = new Bll_SmsText();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll.ReadAll();
            DGV();
        }
        public int id;
        int id2;
        int id3;
        bool flag = false;
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (TextBoxNumber.Text.Trim().Length!=11)
            {
                MessageBox.Show("شماره وارد شده صحیح نمی باشد");
                TextBoxNumber.Select();
            }
            else if (TextBoxText.Text.Trim().Length==0)
            {
                MessageBox.Show("متن پیام خالی است");
                TextBoxText.Select();
            }
            else if (TextBoxName.Text.Trim().Length==0)
            {
                MessageBox.Show("نام خالی است");
                TextBoxName.Select();
            }
            else
            {
                if (!flag)
                {
                    Bll_Sms bll = new Bll_Sms();
                    UserSms h = new UserSms();
                    h = bll.ReturnUser();
                    string username = h.UserName;
                    string password = h.Password;
                    string from = h.Number;
                    string to = TextBoxNumber.Text;
                    string text = "آقا/خانم" + " " + TextBoxName.Text + " " + "عزیز" + "\n" + TextBoxText.Text + "\n" + h.Name;
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
                    TextBoxName.Clear();
                    TextBoxNumber.Clear();
                    MessageBox.Show("پیام ارسال شد");
                }
                else
                {
                    Bll_SmsText bs = new Bll_SmsText();
                    SmsText s = new SmsText();
                    s.Text = TextBoxText.Text;
                    bs.Update(id, s);
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

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bll_SmsText bll = new Bll_SmsText();
            SmsText s = new SmsText();
            s = bll.SearchById(id);
            TextBoxText.Text = s.Text;
            flag = true;
            ButtonSend.Text = "ویرایش";
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

        private void ارسالپیامکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTextSms frm = new frmTextSms();
            Deposit d = new Deposit();
            Bll_Deposit bll = new Bll_Deposit();
            d = bll.SearchById(id2);
            frmTextSms.Number = d.Number;
            frmTextSms.N = d.FullName;
            frm.TextBoxText.Text = "با توجه به درخواست شما جهت" + " " + d.KindDeposit + "-" + d.UserName + " " + "و سپری شدن مدت زمان بیش از 10 روز از واگذاری به این بنگاه،در صورت انصراف از" + " " + d.KindDeposit + "،" + "" +"عدد 1 را به همین شماره پیامک کنید . تشکر";
            frm.ShowDialog();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id2 = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
            try
            {
                id2 = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
            }
            catch (Exception exp)
            {
                MessageBox.Show("خطا در بارگزاری اطلاعات", exp.Message);
            }
        }

        private void ارسالپیامکToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTextSms frm = new frmTextSms();
            Need d = new Need();
            Bll_Need bll = new Bll_Need();
            d = bll.SearchById(id3);
            frmTextSms.Number = d.Number;
            frmTextSms.N = d.FullName;
            frm.TextBoxText.Text = "با توجه به درخواست شما جهت" + " " + d.KindNeed + "-" + d.UserName + " " + "و سپری شدن مدت زمان بیش از 10 روز از واگذاری به این بنگاه،در صورت انصراف از" + " " + d.KindNeed + "،" + "" + "عدد 1 را به همین شماره پیامک کنید . تشکر";
            frm.ShowDialog();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                id3 = (int)dataGridView3.Rows[e.RowIndex].Cells["id"].Value;
            }
            catch (Exception exp)
            {
                MessageBox.Show("خطا در بارگزاری اطلاعات", exp.Message);
            }
        }

        private void حذفToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bll_Deposit bll = new Bll_Deposit();
            bll.Delete(id2);
            MessageBox.Show("با موفقیت حذف شد");
            Bll_Deposit d = new Bll_Deposit();
            dataGridView5.DataSource = null;
            dataGridView5.DataSource = d.NeedSms();
            DGV2();
        }

        private void نمایشاینموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSave_Deposit_Show f = new frmSave_Deposit_Show();
            Deposit n = new Deposit();
            Bll_Deposit bll = new Bll_Deposit();
            n = bll.SearchById(id2);
            frmSave_Deposit_Show.id1 = id2;
            frmShowPicture.id1 = id2;
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
            f.ShowDialog();
        }

        private void حذفToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Bll_Need bll = new Bll_Need();
            bll.Delete(id3);
            MessageBox.Show("با موفقیت حذف شد");
            Bll_Need n = new Bll_Need();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = n.NeedSms();
            DGV3();
        }

        private void نمایشاینموردToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSave_Applacant_Show f = new frmSave_Applacant_Show();
            Need n = new Need();
            Bll_Need bll = new Bll_Need();
            n = bll.SearchById(id3);
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
            f.ShowDialog();
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id2 = (int)dataGridView5.Rows[e.RowIndex].Cells["id"].Value;
            }
            catch (Exception exp)
            {
                MessageBox.Show("خطا در بارگزاری اطلاعات", exp.Message);
            }
        }
    }
}
