
namespace Amlak
{
    partial class frmTextSms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTextSms));
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.CheckBoxSave = new Guna.UI.WinForms.GunaCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonSend = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxText = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انتخابمتنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaGroupBox1.BorderSize = 3;
            this.gunaGroupBox1.Controls.Add(this.CheckBoxSave);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.ButtonSend);
            this.gunaGroupBox1.Controls.Add(this.TextBoxText);
            this.gunaGroupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 15;
            this.gunaGroupBox1.Size = new System.Drawing.Size(457, 328);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.Text = "ارسال پیامک";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(240, 0);
            // 
            // CheckBoxSave
            // 
            this.CheckBoxSave.BaseColor = System.Drawing.Color.White;
            this.CheckBoxSave.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckBoxSave.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CheckBoxSave.FillColor = System.Drawing.Color.White;
            this.CheckBoxSave.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CheckBoxSave.ForeColor = System.Drawing.Color.Black;
            this.CheckBoxSave.Location = new System.Drawing.Point(347, 200);
            this.CheckBoxSave.Name = "CheckBoxSave";
            this.CheckBoxSave.Size = new System.Drawing.Size(97, 31);
            this.CheckBoxSave.TabIndex = 6;
            this.CheckBoxSave.Text = "ذخیره متن";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(341, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = ":متن پیام";
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
            this.ButtonSend.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ButtonSend.ForeColor = System.Drawing.Color.White;
            this.ButtonSend.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSend.Image")));
            this.ButtonSend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonSend.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonSend.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonSend.Location = new System.Drawing.Point(29, 237);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonSend.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonSend.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonSend.OnHoverImage = null;
            this.ButtonSend.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonSend.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonSend.Radius = 25;
            this.ButtonSend.Size = new System.Drawing.Size(389, 71);
            this.ButtonSend.TabIndex = 3;
            this.ButtonSend.Text = "ارسال";
            this.ButtonSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // TextBoxText
            // 
            this.TextBoxText.Location = new System.Drawing.Point(48, 42);
            this.TextBoxText.Name = "TextBoxText";
            this.TextBoxText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxText.Size = new System.Drawing.Size(286, 189);
            this.TextBoxText.TabIndex = 2;
            this.TextBoxText.Text = "";
            this.TextBoxText.TextChanged += new System.EventHandler(this.TextBoxText_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.ContextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(457, 272);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.انتخابمتنToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStrip1.Size = new System.Drawing.Size(174, 112);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ویرایشToolStripMenuItem.Image")));
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(173, 36);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            this.ویرایشToolStripMenuItem.Click += new System.EventHandler(this.ویرایشToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حذفToolStripMenuItem.Image")));
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(173, 36);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // انتخابمتنToolStripMenuItem
            // 
            this.انتخابمتنToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("انتخابمتنToolStripMenuItem.Image")));
            this.انتخابمتنToolStripMenuItem.Name = "انتخابمتنToolStripMenuItem";
            this.انتخابمتنToolStripMenuItem.Size = new System.Drawing.Size(173, 36);
            this.انتخابمتنToolStripMenuItem.Text = "انتخاب متن";
            this.انتخابمتنToolStripMenuItem.Click += new System.EventHandler(this.انتخابمتنToolStripMenuItem_Click);
            // 
            // frmTextSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 630);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gunaGroupBox1);
            this.Name = "frmTextSms";
            this.Text = "frmTextSms";
            this.Load += new System.EventHandler(this.frmTextSms_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton ButtonSend;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaCheckBox CheckBoxSave;
        private Guna.UI.WinForms.GunaContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انتخابمتنToolStripMenuItem;
        public System.Windows.Forms.RichTextBox TextBoxText;
    }
}