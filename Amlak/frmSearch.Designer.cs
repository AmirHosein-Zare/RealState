
namespace Amlak
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.Button2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Button1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelFormLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.AnimationHoverSpeed = 0.07F;
            this.Button2.AnimationSpeed = 0.03F;
            this.Button2.BackColor = System.Drawing.Color.Transparent;
            this.Button2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Button2.BorderColor = System.Drawing.Color.Black;
            this.Button2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Button2.CheckedBorderColor = System.Drawing.Color.Black;
            this.Button2.CheckedForeColor = System.Drawing.Color.White;
            this.Button2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("Button2.CheckedImage")));
            this.Button2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button2.FocusedColor = System.Drawing.Color.Empty;
            this.Button2.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.Button2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Button2.Location = new System.Drawing.Point(289, 9);
            this.Button2.Name = "Button2";
            this.Button2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Button2.OnHoverForeColor = System.Drawing.Color.White;
            this.Button2.OnHoverImage = null;
            this.Button2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Button2.OnPressedColor = System.Drawing.Color.Black;
            this.Button2.Radius = 30;
            this.Button2.Size = new System.Drawing.Size(304, 71);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "سپرده";
            this.Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.AnimationHoverSpeed = 0.07F;
            this.Button1.AnimationSpeed = 0.03F;
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Button1.BorderColor = System.Drawing.Color.Black;
            this.Button1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Button1.CheckedBorderColor = System.Drawing.Color.Black;
            this.Button1.CheckedForeColor = System.Drawing.Color.White;
            this.Button1.CheckedImage = null;
            this.Button1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button1.FocusedColor = System.Drawing.Color.Empty;
            this.Button1.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button1.ImageSize = new System.Drawing.Size(35, 35);
            this.Button1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Button1.Location = new System.Drawing.Point(634, 9);
            this.Button1.Name = "Button1";
            this.Button1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Button1.OnHoverForeColor = System.Drawing.Color.White;
            this.Button1.OnHoverImage = null;
            this.Button1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Button1.OnPressedColor = System.Drawing.Color.Black;
            this.Button1.Radius = 30;
            this.Button1.Size = new System.Drawing.Size(304, 71);
            this.Button1.TabIndex = 2;
            this.Button1.Tag = "متقاضی";
            this.Button1.Text = "متقاضی";
            this.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button2);
            this.panel1.Controls.Add(this.Button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 86);
            this.panel1.TabIndex = 5;
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Controls.Add(this.pictureBox1);
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormLoader.Location = new System.Drawing.Point(0, 86);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(1206, 681);
            this.panelFormLoader.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 767);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.panel1.ResumeLayout(false);
            this.panelFormLoader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton Button2;
        private Guna.UI.WinForms.GunaAdvenceButton Button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}