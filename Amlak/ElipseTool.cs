using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace Amlak
{
    public class ElipseTool:Component
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        private Control _cntrl;
        private int _CornerRadius = 30;

        public Control TargetControl
        {
            get { return _cntrl; }
            set
            {
                _cntrl = value;
                _cntrl.SizeChanged += (sender, EventArgs) => _cntrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, _cntrl.Width, _cntrl.Height, _CornerRadius, _CornerRadius));
                

            }
        }
        public int CornerRadius
        {
            get { return _CornerRadius; }
            set
            {
                _CornerRadius = value;
                if (_cntrl != null)
                {
                    _cntrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, _cntrl.Width, _cntrl.Height, _CornerRadius, _CornerRadius));
                }
            }
        }
    }
}
