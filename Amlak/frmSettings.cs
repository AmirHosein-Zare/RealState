using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BusinessEntity;
using BusinessLogicLayer;
using Microsoft.SqlServer.Management.Common;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;

namespace Amlak
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }
        OpenFileDialog f = new OpenFileDialog();
        public string SavePic(string code)
        {
            string AppPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Pictures\";
            if (Directory.Exists(AppPath)==false)
            {
                Directory.CreateDirectory(AppPath);
            }
            string iName = code + ".jpg";
            try
            {
                string filepath = f.FileName;
                File.Copy(filepath, AppPath+iName);
            }
            catch (Exception exp)
            {
                MessageBox.Show("خطا در بارگزاری اطلاعات" , exp.Message);
            }
            return AppPath + iName;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            user u = new user();
            TextBoxUserName.Text = u.ReturnUsername();
            TextBoxName.Text = u.ReturnName();
            TextBoxPass.Text = u.ReturnPass();
            TextBoxPass.PasswordChar = '*';
            TextBoxPass2.PasswordChar = '*';
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (TextBoxPass.PasswordChar=='*')
            {
                TextBoxPass.PasswordChar = '\0';
            }
            else if (TextBoxPass.PasswordChar=='\0')
            {
                TextBoxPass.PasswordChar = '*';
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (TextBoxPass2.PasswordChar == '*')
            {
                TextBoxPass2.PasswordChar = '\0';
            }
            else if (TextBoxPass2.PasswordChar == '\0')
            {
                TextBoxPass2.PasswordChar = '*';
            }
        }
        public void color()
        {
            Color c = System.Drawing.ColorTranslator.FromHtml("#000040");
            ButtonName.BaseColor = c;
            ButtonPassword.BaseColor = c;
            ButtonProfile.BaseColor = c;
            ButtonUserName.BaseColor = c;
        }
        public void enableControl()
        {
            TextBoxName.Enabled = false;
            TextBoxPass.Enabled = false;
            TextBoxPass2.Enabled = false;
            TextBoxUserName.Enabled = false;
            label6.Enabled = false;
            label5.Enabled = false;
            pictureBoxSearchPic.Enabled = false;
            TextBoxPicName.Enabled = false;

        }
        private void ButtonUserName_Click(object sender, EventArgs e)
        {
            enableControl();
            color();
            ButtonUserName.BaseColor = Color.Silver;
            gunaGroupBox2.Visible = true;
            TextBoxUserName.Enabled = true;
        }

        private void ButtonName_Click(object sender, EventArgs e)
        {
            enableControl();
            color();
            ButtonName.BaseColor = Color.Silver;
            gunaGroupBox2.Visible = true;
            TextBoxName.Enabled = true;
        }
        Image pic;
        private void ButtonProfile_Click(object sender, EventArgs e)
        {
            enableControl();
            color();
            ButtonProfile.BaseColor = Color.Silver;
            gunaGroupBox2.Visible = true;
            pictureBoxSearchPic.Enabled = true;
            TextBoxPicName.Enabled = true;
            //save pic0

            
        }

        private void ButtonPassword_Click(object sender, EventArgs e)
        {
            enableControl();
            color();
            ButtonPassword.BaseColor = Color.Silver;
            gunaGroupBox2.Visible = true;
            label5.Enabled = true;
            label6.Enabled = true;
            TextBoxPass.Enabled = true;
            TextBoxPass2.Enabled = true;
        }
        BLL_login bll = new BLL_login();
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Enabled==true)
            {
                if (TextBoxName.Text.Trim().Length==0)
                {
                    MessageBox.Show("نام خالی است");
                }
                else
                {
                    User_Login u = new User_Login();
                    u.Name = TextBoxName.Text;
                    bll.updateName(u);
                    MessageBox.Show("ویرایش نام با موفقیت انجام شد");
                }
            }
            else if (TextBoxPass.Enabled==true)
            {
                if (TextBoxPass.Text.Trim()!=TextBoxPass2.Text.Trim())
                {
                    MessageBox.Show("عدم تطلابق رمز عبور");
                }
                else if (TextBoxPass.Text.Trim().Length==0 || TextBoxPass2.Text.Trim().Length==0)
                {
                    MessageBox.Show("رمز خالی است");
                }
                else
                {
                    User_Login u = new User_Login();
                    u.Password = TextBoxPass.Text;
                    bll.updatepass(u);
                    MessageBox.Show("رمز عبور با موفقیت تغییر یافت");
                }
            }
            else if (TextBoxUserName.Enabled==true)
            {
                if (TextBoxUserName.Text.Trim().Length==0)
                {
                    MessageBox.Show("نام کاربری خالی است");
                }
                else
                {
                    User_Login u = new User_Login();
                    u.Username = TextBoxUserName.Text;
                    bll.updateUserName(u);
                    MessageBox.Show("ویرایش نام کاربری با موفقیت انجام شد");
                }
            }
            else if (pictureBoxSearchPic.Enabled==true)
            {
                if (TextBoxPicName.Text.Trim().Length==0)
                {
                    MessageBox.Show("نام تصویر خالی است");
                }
                else
                {
                    user h = new user();
                    User_Login u = new User_Login();
                    u.Name = h.ReturnName();
                    u.Username = h.ReturnUsername();
                    u.Password = h.ReturnPass();
                    u.PictureAddress = SavePic(TextBoxPicName.Text);
                    bll.UpdatePic(u);
                    pictureBox1.Image = null;
                    MessageBox.Show("تصویر با موفقیت ذخیره شد");
                }
            }
        }

        private void pictureBoxSearchPic_Click(object sender, EventArgs e)
        {
            f.Filter = "JPG(*.JPG)|*.JPG";
            if (f.ShowDialog() == DialogResult.OK)
            {
                pic = Image.FromFile(f.FileName);
                pictureBox1.Image = pic;
                MainForm n = new MainForm();
                n.picture_user.Image = pic;
            }
        }

        #region ConnectionString
        private string BackUpConString = @"data source=(local) ; initial catalog = Amlak ; integrated security=True ; multipleactiveresultsets=True";
        private string ReStoreConString = @"data source=(local) ; initial catalog = master ; integrated security=True ; ";
        #endregion
        #region BackUp
        private void ButtonBackUp_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(BackUpConString))
            {
                ServerConnection srvConn = new ServerConnection(con);
                Server srvr = new Server(srvConn);

                if (srvr != null)
                {
                    try
                    {
                        Backup bkpDatabase = new Backup();
                        bkpDatabase.Action = BackupActionType.Database;
                        bkpDatabase.Database = "Amlak"; // باید هم نام با دیتابیس برنامه تنظیم شود
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "BackUp File|*.araDB";
                        sfd.FileName = "BackUp_" + (DateTime.Now.ToShortDateString().Replace('/', '.'));
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            BackupDeviceItem bkpDevice = new BackupDeviceItem(sfd.FileName, DeviceType.File);
                            bkpDatabase.Devices.Add(bkpDevice);
                            bkpDatabase.SqlBackup(srvr);
                            MessageBox.Show("!فایل پشتیبان با موفقیت ذخیره شد", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception s) { MessageBox.Show("!لطفا فایل بشتیبان را در درایوی غیر از درایو ویندوز ذخیره کنید", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
        #endregion
        #region ReStore
        private void ButtonReLoad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("!!!ممکن است تمام اطلاعات حال حاظر بانک اطلاعاتی شما تغییر کند \n !اگر مشکلی با این مورد ندارید بله را انتخاب کنید", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection.ClearAllPools();
                using (SqlConnection con = new SqlConnection(ReStoreConString))
                {
                    ServerConnection srvConn = new ServerConnection(con);
                    Server srvr = new Server(srvConn);

                    srvr.KillAllProcesses("Amlak");
                    if (srvr != null)
                    {
                        try
                        {
                            Restore rstDatabase = new Restore();
                            rstDatabase.Action = RestoreActionType.Database;
                            rstDatabase.Database = "Amlak"; // باید هم نام با دیتابیس برنامه تنظیم شود
                            OpenFileDialog opfd = new OpenFileDialog();
                            opfd.Filter = "BackUp File|*.araDB";

                            if (opfd.ShowDialog() == DialogResult.OK)
                            {
                                BackupDeviceItem bkpDevice = new BackupDeviceItem(opfd.FileName, DeviceType.File);
                                rstDatabase.Devices.Add(bkpDevice);

                                rstDatabase.ReplaceDatabase = true;
                                rstDatabase.SqlRestore(srvr);
                                MessageBox.Show("!اطلاعات با موفقیت بازیابی شد", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show(f.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion
    }
}
