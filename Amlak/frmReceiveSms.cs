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
    public partial class frmReceiveSms : Form
    {
        public frmReceiveSms()
        {
            InitializeComponent();
        }
        public void DGV()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Columns["MsgID"].Visible=false;
            dataGridView1.Columns["UserID"].Visible = false;
            dataGridView1.Columns["LinkID"].Visible = false;
            dataGridView1.Columns["NumberID"].Visible = false;
            dataGridView1.Columns["Tariff"].Visible = false;
            dataGridView1.Columns["MsgType"].Visible = false;
            dataGridView1.Columns["Body"].HeaderText="متن پیام";
            dataGridView1.Columns["Body"].Width = 500;
            dataGridView1.Columns["Udh"].Visible = false;
            dataGridView1.Columns["SendDate"].HeaderText="تاریخ ارسال";
            dataGridView1.Columns["SendDate"].Width = 200;
            dataGridView1.Columns["Sender"].HeaderText="فرستنده";
            dataGridView1.Columns["Sender"].Width = 150;
            dataGridView1.Columns["Receiver"].Visible = false;
            dataGridView1.Columns["FirstLocation"].Visible = false;
            dataGridView1.Columns["CurrentLocation"].Visible = false;
            dataGridView1.Columns["Parts"].Visible = false;
            dataGridView1.Columns["IsFlash"].Visible = false;
            dataGridView1.Columns["IsRead"].Visible = false;
            dataGridView1.Columns["IsUnicode"].Visible = false;
            dataGridView1.Columns["Credit"].Visible = false;
            dataGridView1.Columns["Module"].Visible = false;
            dataGridView1.Columns["RecCount"].Visible = false;
            dataGridView1.Columns["RecFailed"].Visible = false;
            dataGridView1.Columns["RecSuccess"].Visible = false;
            dataGridView1.Columns["IsMoneyBack"].Visible = false;
            dataGridView1.Columns["UserMaster"].Visible = false;
            dataGridView1.Columns["MoneyBackCount"].Visible = false;
            dataGridView1.Columns["MoneyBackLevel"].Visible = false;
            dataGridView1.Columns["AutoSpeechText"].Visible = false;
            dataGridView1.Columns["ShareServiceBodyID"].Visible = false;
            dataGridView1.Columns["IrancellBackCount"].Visible = false;
            dataGridView1.Columns["UserStepedMaster"].Visible = false;
        }

        private void frmReceiveSms_Load(object sender, EventArgs e)
        {
            Bll_Sms bll = new Bll_Sms();
            UserSms s = new UserSms();
            s = bll.ReturnUser();
            string username = s.UserName;
            string password = s.Password;
            string from = "";
            ReceiveWebService.Receive receiveSoapClient = new ReceiveWebService.Receive();
            ReceiveWebService.MessagesBL[] sms = receiveSoapClient.GetMessages(username, password, 1, from, 0, 30);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sms.ToList();
            DGV();
        }
        string Number ;
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Number = (string)dataGridView1.Rows[e.RowIndex].Cells["Sender"].Value;
            }
            catch (Exception exp)
            {
                MessageBox.Show("خطا در بارگزاری اطلاعات", exp.Message);
            }
        }

        private void نمایشاینموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deposit
            Deposit[] FindMember;
            Bll_Deposit bll = new Bll_Deposit();
            FindMember=bll.SearchByNumber(Number);
            //applicant
            Need[] FindNeed ;
            Bll_Need bn = new Bll_Need();
            FindNeed = bn.SearchByNumber(Number);
            //end
            if (FindNeed.Count()>0)
            {
                frmSave_Applacant_Show f = new frmSave_Applacant_Show();
                Need n = new Need();
                var q = from i in FindNeed where i.Number.Contains(Number) select i;
                n = FindNeed[0];
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
            else if (FindMember.Count()>0)
            {
                var q = from i in FindMember where i.Number.Contains(Number) select i;
                frmSave_Deposit_Show f = new frmSave_Deposit_Show();
                Deposit n = new Deposit();
                n = FindMember[0];
                frmSave_Deposit_Show.id1 = n.id;
                frmShowPicture.id1 = n.id;
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
            else if (FindMember.Length==0 && FindNeed.Length==0)
            {
                MessageBox.Show("یافت نشد");
            }
        }

        private void حذفکاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit[] FindMember;
            Bll_Deposit bll = new Bll_Deposit();
            FindMember = bll.SearchByNumber(Number);
            //applicant
            Need[] FindNeed;
            Bll_Need bn = new Bll_Need();
            FindNeed = bn.SearchByNumber(Number);
            if (FindMember.Count()>0)
            {
                bll.Delete(FindMember[0].id);
            }
            else if (FindNeed.Count()>0)
            {
                bn.Delete(FindNeed[0].id);
            }
            else if (FindNeed.Count()==0 && FindMember.Count()==0)
            {
                MessageBox.Show("کاربر یافت نشد");
            }
        }
    }
}
