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
    public partial class frmShowPicture : Form
    {
        public frmShowPicture()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static int id1;
        private void frmShowPicture_Load(object sender, EventArgs e)
        {
            Deposit n = new Deposit();
            Bll_Deposit bll = new Bll_Deposit();
            n = bll.SearchById(id1);
            if (n.PictureAddress1!=null)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(n.PictureAddress1);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            if (n.PictureAddress2!=null)
            {
                try
                {
                    pictureBox2.Image = Image.FromFile(n.PictureAddress2);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            if (n.PictureAddress3!=null)
            {
                try
                {
                    pictureBox3.Image = Image.FromFile(n.PictureAddress3);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
