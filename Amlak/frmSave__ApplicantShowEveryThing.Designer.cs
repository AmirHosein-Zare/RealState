
namespace Amlak
{
    partial class frmSave__ApplicantShowEveryThing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSave__ApplicantShowEveryThing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView1 = new BehComponents.DataGridViewX(this.components);
            this.ContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نمایشاینموردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جستجویمواردمشابهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ارسالپیامکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.بازبینیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns_EnglishDate = ((System.Collections.Generic.List<string>)(resources.GetObject("DataGridView1.Columns_EnglishDate")));
            this.DataGridView1.Columns_PersianDate = ((System.Collections.Generic.List<string>)(resources.GetObject("DataGridView1.Columns_PersianDate")));
            this.DataGridView1.ContextMenuStrip = this.ContextMenuStrip1;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.GridColor = System.Drawing.Color.White;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1478, 797);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفToolStripMenuItem,
            this.نمایشاینموردToolStripMenuItem,
            this.جستجویمواردمشابهToolStripMenuItem,
            this.ارسالپیامکToolStripMenuItem,
            this.بازبینیToolStripMenuItem});
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
            this.ContextMenuStrip1.Size = new System.Drawing.Size(247, 212);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حذفToolStripMenuItem.Image")));
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // نمایشاینموردToolStripMenuItem
            // 
            this.نمایشاینموردToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("نمایشاینموردToolStripMenuItem.Image")));
            this.نمایشاینموردToolStripMenuItem.Name = "نمایشاینموردToolStripMenuItem";
            this.نمایشاینموردToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.نمایشاینموردToolStripMenuItem.Text = "نمایش این مورد";
            this.نمایشاینموردToolStripMenuItem.Click += new System.EventHandler(this.نمایشاینموردToolStripMenuItem_Click);
            // 
            // جستجویمواردمشابهToolStripMenuItem
            // 
            this.جستجویمواردمشابهToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("جستجویمواردمشابهToolStripMenuItem.Image")));
            this.جستجویمواردمشابهToolStripMenuItem.Name = "جستجویمواردمشابهToolStripMenuItem";
            this.جستجویمواردمشابهToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.جستجویمواردمشابهToolStripMenuItem.Text = "جستجوی موارد مشابه";
            this.جستجویمواردمشابهToolStripMenuItem.Click += new System.EventHandler(this.جستجویمواردمشابهToolStripMenuItem_Click);
            // 
            // ارسالپیامکToolStripMenuItem
            // 
            this.ارسالپیامکToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ارسالپیامکToolStripMenuItem.Image")));
            this.ارسالپیامکToolStripMenuItem.Name = "ارسالپیامکToolStripMenuItem";
            this.ارسالپیامکToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.ارسالپیامکToolStripMenuItem.Text = "ارسال پیامک";
            this.ارسالپیامکToolStripMenuItem.Click += new System.EventHandler(this.ارسالپیامکToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 797);
            this.panel1.TabIndex = 2;
            // 
            // بازبینیToolStripMenuItem
            // 
            this.بازبینیToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("بازبینیToolStripMenuItem.Image")));
            this.بازبینیToolStripMenuItem.Name = "بازبینیToolStripMenuItem";
            this.بازبینیToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.بازبینیToolStripMenuItem.Text = "بازبینی";
            this.بازبینیToolStripMenuItem.Click += new System.EventHandler(this.بازبینیToolStripMenuItem_Click);
            // 
            // frmSave__ApplicantShowEveryThing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 797);
            this.Controls.Add(this.panel1);
            this.Name = "frmSave__ApplicantShowEveryThing";
            this.Load += new System.EventHandler(this.frmSave__ApplicantShowEveryThing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public BehComponents.DataGridViewX DataGridView1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نمایشاینموردToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جستجویمواردمشابهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ارسالپیامکToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بازبینیToolStripMenuItem;
    }
}