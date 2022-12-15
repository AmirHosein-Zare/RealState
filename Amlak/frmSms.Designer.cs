
namespace Amlak
{
    partial class frmSms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonReceive = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ButtonSend = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelFormLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonReceive);
            this.panel1.Controls.Add(this.ButtonSend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 94);
            this.panel1.TabIndex = 0;
            // 
            // ButtonReceive
            // 
            this.ButtonReceive.AnimationHoverSpeed = 0.07F;
            this.ButtonReceive.AnimationSpeed = 0.03F;
            this.ButtonReceive.BackColor = System.Drawing.Color.Transparent;
            this.ButtonReceive.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButtonReceive.BorderColor = System.Drawing.Color.Black;
            this.ButtonReceive.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ButtonReceive.CheckedBorderColor = System.Drawing.Color.Black;
            this.ButtonReceive.CheckedForeColor = System.Drawing.Color.White;
            this.ButtonReceive.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ButtonReceive.CheckedImage")));
            this.ButtonReceive.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ButtonReceive.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonReceive.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonReceive.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ButtonReceive.ForeColor = System.Drawing.Color.White;
            this.ButtonReceive.Image = ((System.Drawing.Image)(resources.GetObject("ButtonReceive.Image")));
            this.ButtonReceive.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonReceive.ImageSize = new System.Drawing.Size(35, 35);
            this.ButtonReceive.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonReceive.Location = new System.Drawing.Point(277, 12);
            this.ButtonReceive.Name = "ButtonReceive";
            this.ButtonReceive.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonReceive.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonReceive.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonReceive.OnHoverImage = null;
            this.ButtonReceive.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonReceive.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonReceive.Radius = 25;
            this.ButtonReceive.Size = new System.Drawing.Size(285, 70);
            this.ButtonReceive.TabIndex = 1;
            this.ButtonReceive.Text = "دریافت";
            this.ButtonReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonReceive.Click += new System.EventHandler(this.ButtonReceive_Click);
            // 
            // ButtonSend
            // 
            this.ButtonSend.AnimationHoverSpeed = 0.07F;
            this.ButtonSend.AnimationSpeed = 0.03F;
            this.ButtonSend.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSend.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButtonSend.BorderColor = System.Drawing.Color.Black;
            this.ButtonSend.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ButtonSend.CheckedBorderColor = System.Drawing.Color.Black;
            this.ButtonSend.CheckedForeColor = System.Drawing.Color.White;
            this.ButtonSend.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ButtonSend.CheckedImage")));
            this.ButtonSend.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ButtonSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonSend.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonSend.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ButtonSend.ForeColor = System.Drawing.Color.White;
            this.ButtonSend.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSend.Image")));
            this.ButtonSend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonSend.ImageSize = new System.Drawing.Size(35, 35);
            this.ButtonSend.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonSend.Location = new System.Drawing.Point(628, 12);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonSend.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonSend.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonSend.OnHoverImage = null;
            this.ButtonSend.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonSend.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonSend.Radius = 25;
            this.ButtonSend.Size = new System.Drawing.Size(285, 70);
            this.ButtonSend.TabIndex = 0;
            this.ButtonSend.Text = "ارسال";
            this.ButtonSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Controls.Add(this.pictureBox1);
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormLoader.Location = new System.Drawing.Point(0, 94);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(1206, 673);
            this.panelFormLoader.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 767);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSms";
            this.Text = "frmSms";
            this.panel1.ResumeLayout(false);
            this.panelFormLoader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton ButtonReceive;
        private Guna.UI.WinForms.GunaAdvenceButton ButtonSend;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}