
namespace Amlak
{
    partial class frmReceiveSms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiveSms));
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.نمایشاینموردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفکاربرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gunaGroupBox1.Controls.Add(this.dataGridView1);
            this.gunaGroupBox1.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 12;
            this.gunaGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1182, 649);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "لیست پیامک های دریافتی";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(750, 0);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.ContextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 616);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.نمایشاینموردToolStripMenuItem,
            this.حذفکاربرToolStripMenuItem});
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
            this.ContextMenuStrip1.Size = new System.Drawing.Size(215, 104);
            // 
            // نمایشاینموردToolStripMenuItem
            // 
            this.نمایشاینموردToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("نمایشاینموردToolStripMenuItem.Image")));
            this.نمایشاینموردToolStripMenuItem.Name = "نمایشاینموردToolStripMenuItem";
            this.نمایشاینموردToolStripMenuItem.Size = new System.Drawing.Size(214, 36);
            this.نمایشاینموردToolStripMenuItem.Text = "نمایش این مورد";
            this.نمایشاینموردToolStripMenuItem.Click += new System.EventHandler(this.نمایشاینموردToolStripMenuItem_Click);
            // 
            // حذفکاربرToolStripMenuItem
            // 
            this.حذفکاربرToolStripMenuItem.Name = "حذفکاربرToolStripMenuItem";
            this.حذفکاربرToolStripMenuItem.Size = new System.Drawing.Size(214, 36);
            this.حذفکاربرToolStripMenuItem.Text = "حذف کاربر";
            this.حذفکاربرToolStripMenuItem.Click += new System.EventHandler(this.حذفکاربرToolStripMenuItem_Click);
            // 
            // frmReceiveSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 673);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReceiveSms";
            this.Text = "frmReceiveSms";
            this.Load += new System.EventHandler(this.frmReceiveSms_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem نمایشاینموردToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفکاربرToolStripMenuItem;
    }
}