
namespace Amlak
{
    partial class frmSave_DepositShowEvery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSave_DepositShowEvery));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.نمایشاینموردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ارسالپیامکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جستجویمواردمشابهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازبینیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.gunaContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 797);
            this.panel1.TabIndex = 3;
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.ContextMenuStrip = this.gunaContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1478, 797);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gunaContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.نمایشاینموردToolStripMenuItem,
            this.ارسالپیامکToolStripMenuItem,
            this.جستجویمواردمشابهToolStripMenuItem,
            this.بازبینیToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(247, 212);
            // 
            // نمایشاینموردToolStripMenuItem
            // 
            this.نمایشاینموردToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("نمایشاینموردToolStripMenuItem.Image")));
            this.نمایشاینموردToolStripMenuItem.Name = "نمایشاینموردToolStripMenuItem";
            this.نمایشاینموردToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.نمایشاینموردToolStripMenuItem.Text = "نمایش این مورد";
            this.نمایشاینموردToolStripMenuItem.Click += new System.EventHandler(this.نمایشاینموردToolStripMenuItem_Click);
            // 
            // ارسالپیامکToolStripMenuItem
            // 
            this.ارسالپیامکToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ارسالپیامکToolStripMenuItem.Image")));
            this.ارسالپیامکToolStripMenuItem.Name = "ارسالپیامکToolStripMenuItem";
            this.ارسالپیامکToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.ارسالپیامکToolStripMenuItem.Text = "ارسال پیامک";
            this.ارسالپیامکToolStripMenuItem.Click += new System.EventHandler(this.ارسالپیامکToolStripMenuItem_Click);
            // 
            // جستجویمواردمشابهToolStripMenuItem
            // 
            this.جستجویمواردمشابهToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("جستجویمواردمشابهToolStripMenuItem.Image")));
            this.جستجویمواردمشابهToolStripMenuItem.Name = "جستجویمواردمشابهToolStripMenuItem";
            this.جستجویمواردمشابهToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.جستجویمواردمشابهToolStripMenuItem.Text = "جستجوی موارد مشابه";
            this.جستجویمواردمشابهToolStripMenuItem.Click += new System.EventHandler(this.جستجویمواردمشابهToolStripMenuItem_Click);
            // 
            // بازبینیToolStripMenuItem
            // 
            this.بازبینیToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("بازبینیToolStripMenuItem.Image")));
            this.بازبینیToolStripMenuItem.Name = "بازبینیToolStripMenuItem";
            this.بازبینیToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.بازبینیToolStripMenuItem.Text = "بازبینی";
            this.بازبینیToolStripMenuItem.Click += new System.EventHandler(this.بازبینیToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حذفToolStripMenuItem.Image")));
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // frmSave_DepositShowEvery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 797);
            this.Controls.Add(this.panel1);
            this.Name = "frmSave_DepositShowEvery";
            this.Text = "frmSave_DepositShowEvery";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.gunaContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView DataGridView1;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem نمایشاینموردToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ارسالپیامکToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جستجویمواردمشابهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بازبینیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
    }
}