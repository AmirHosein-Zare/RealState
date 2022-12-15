
namespace Amlak
{
    partial class frmSaveMap
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
            this.contextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.علامتگذاریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gMap1 = new GMap.NET.WindowsForms.GMapControl();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.علامتگذاریToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.contextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.contextMenuStrip1.RenderStyle.ColorTable = null;
            this.contextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.contextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.contextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.contextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.contextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.contextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 88);
            // 
            // علامتگذاریToolStripMenuItem
            // 
            this.علامتگذاریToolStripMenuItem.Name = "علامتگذاریToolStripMenuItem";
            this.علامتگذاریToolStripMenuItem.Size = new System.Drawing.Size(210, 42);
            this.علامتگذاریToolStripMenuItem.Text = "علامت گذاری";
            this.علامتگذاریToolStripMenuItem.Click += new System.EventHandler(this.علامتگذاریToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(210, 42);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gMap1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 655);
            this.panel1.TabIndex = 1;
            // 
            // gMap1
            // 
            this.gMap1.Bearing = 0F;
            this.gMap1.CanDragMap = true;
            this.gMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap1.GrayScaleMode = false;
            this.gMap1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap1.LevelsKeepInMemory = 5;
            this.gMap1.Location = new System.Drawing.Point(0, 0);
            this.gMap1.MarkersEnabled = true;
            this.gMap1.MaxZoom = 24;
            this.gMap1.MinZoom = 2;
            this.gMap1.MouseWheelZoomEnabled = true;
            this.gMap1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap1.Name = "gMap1";
            this.gMap1.NegativeMode = false;
            this.gMap1.PolygonsEnabled = true;
            this.gMap1.RetryLoadTile = 0;
            this.gMap1.RoutesEnabled = true;
            this.gMap1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap1.ShowTileGridLines = false;
            this.gMap1.Size = new System.Drawing.Size(1157, 655);
            this.gMap1.TabIndex = 0;
            this.gMap1.Zoom = 0D;
            this.gMap1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            this.gMap1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseClick);
            // 
            // frmSaveMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 655);
            this.Controls.Add(this.panel1);
            this.Name = "frmSaveMap";
            this.Text = "frmSaveMap";
            this.Load += new System.EventHandler(this.frmSaveMap_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem علامتگذاریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private GMap.NET.WindowsForms.GMapControl gMap1;
    }
}