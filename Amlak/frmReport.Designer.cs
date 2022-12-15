
namespace Amlak
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.RadioButtonDeposit = new Guna.UI.WinForms.GunaRadioButton();
            this.RadioButtonApplicant = new Guna.UI.WinForms.GunaRadioButton();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.stiReport2 = new Stimulsoft.Report.StiReport();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaGroupBox1.BorderSize = 3;
            this.gunaGroupBox1.Controls.Add(this.gunaAdvenceButton1);
            this.gunaGroupBox1.Controls.Add(this.RadioButtonDeposit);
            this.gunaGroupBox1.Controls.Add(this.RadioButtonApplicant);
            this.gunaGroupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 132);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 15;
            this.gunaGroupBox1.Size = new System.Drawing.Size(582, 335);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "گزارش گیری";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 0);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(117, 207);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 25;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(336, 84);
            this.gunaAdvenceButton1.TabIndex = 2;
            this.gunaAdvenceButton1.Text = "چاپ";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // RadioButtonDeposit
            // 
            this.RadioButtonDeposit.BaseColor = System.Drawing.SystemColors.Control;
            this.RadioButtonDeposit.CheckedOffColor = System.Drawing.Color.Gray;
            this.RadioButtonDeposit.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RadioButtonDeposit.FillColor = System.Drawing.Color.White;
            this.RadioButtonDeposit.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioButtonDeposit.ForeColor = System.Drawing.Color.Black;
            this.RadioButtonDeposit.Location = new System.Drawing.Point(139, 73);
            this.RadioButtonDeposit.Name = "RadioButtonDeposit";
            this.RadioButtonDeposit.Size = new System.Drawing.Size(96, 48);
            this.RadioButtonDeposit.TabIndex = 1;
            this.RadioButtonDeposit.Text = "سپرده";
            // 
            // RadioButtonApplicant
            // 
            this.RadioButtonApplicant.BaseColor = System.Drawing.SystemColors.Control;
            this.RadioButtonApplicant.CheckedOffColor = System.Drawing.Color.Gray;
            this.RadioButtonApplicant.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RadioButtonApplicant.FillColor = System.Drawing.Color.White;
            this.RadioButtonApplicant.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioButtonApplicant.ForeColor = System.Drawing.Color.Black;
            this.RadioButtonApplicant.Location = new System.Drawing.Point(344, 73);
            this.RadioButtonApplicant.Name = "RadioButtonApplicant";
            this.RadioButtonApplicant.Size = new System.Drawing.Size(109, 48);
            this.RadioButtonApplicant.TabIndex = 0;
            this.RadioButtonApplicant.Text = "متقاضی";
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.Key = "acce9e95b4b1492c9f1ac463e13d5caa";
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "7b1e656473c5450b9257f1df66a4c24e";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.StoreImagesInResources = true;
            this.stiReport1.UseProgressInThread = false;
            // 
            // stiReport2
            // 
            this.stiReport2.CookieContainer = null;
            this.stiReport2.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport2.Key = "acbd0a8b7b4d46fdbe31d065273701a7";
            this.stiReport2.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport2.ReportAlias = "Report";
            this.stiReport2.ReportGuid = "b7ff40f61729414881f0317858b6b65b";
            this.stiReport2.ReportName = "Report";
            this.stiReport2.ReportSource = resources.GetString("stiReport2.ReportSource");
            this.stiReport2.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport2.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport2.StoreImagesInResources = true;
            this.stiReport2.UseProgressInThread = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(616, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 695);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaRadioButton RadioButtonDeposit;
        private Guna.UI.WinForms.GunaRadioButton RadioButtonApplicant;
        private Stimulsoft.Report.StiReport stiReport1;
        private Stimulsoft.Report.StiReport stiReport2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}