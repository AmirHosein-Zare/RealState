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
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Amlak
{
    public partial class frmSave_Deposit_Show : Form
    {
        public frmSave_Deposit_Show()
        {
            InitializeComponent();
        }

        private void labelKUser_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonPic_Click(object sender, EventArgs e)
        {
            frmShowPicture f = new frmShowPicture();
            f.ShowDialog();
        }
        public static int id1;
        private void ButtonMap_Click(object sender, EventArgs e)
        {
            frmShowLocation frm1 = new frmShowLocation();
            Deposit d = new Deposit();
            Bll_Deposit bll = new Bll_Deposit();
            d = bll.SearchById(id1);
            frmShowLocation.X = d.XLocation;
            frmShowLocation.Y = d.YLocation;
            frm1.ShowDialog();
        }
    }
}
