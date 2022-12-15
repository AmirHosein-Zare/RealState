using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amlak.RjControl
{
    public partial class RjTextBox : UserControl
    {
        //Fields
        private Color bordercolor = Color.MediumSlateBlue;
        private int bordersize = 2;
        private bool underlinedStyle = false;
        //Constructor
        public RjTextBox()
        {
            InitializeComponent();
        }
        //properties
        public Color BorderColor
        {
            get
            {
                return bordercolor;
            }
            set
            {
                bordercolor = value;
                this.Invalidate();
            }
        }
        public int BorderSize
        {
            get
            {
                return bordersize;
            }
            set
            {
                bordersize = value;
                this.Invalidate();
            }
        }
        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Validate();
            }
        }
        //overriden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw Border
            using (Pen penborder = new Pen(bordercolor, bordersize))
            {
                penborder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (underlinedStyle)
                {
                    graph.DrawLine(penborder,0,this.Height-1,this.Width,this.Height-1);
                }
                else
                {
                    graph.DrawRectangle(penborder,0,0,this.Width-0.5F,this.Height-0.5F);
                }
            }
            
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                updatecontrolheight();
            }
           
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            updatecontrolheight();
        }

        private void updatecontrolheight()
        {
            if (textBox1.Multiline==false)
            {
                int txtheight = TextRenderer.MeasureText("Text",this.Font).Height+1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtheight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        public bool password
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }
        }
        public bool multiline
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }
        }
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        public override Font Font {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                {
                    updatecontrolheight();
                }
            }
        }
        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
    }
}
