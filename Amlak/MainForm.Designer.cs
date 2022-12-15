
namespace Amlak
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_setting = new System.Windows.Forms.Button();
            this.button_Contract = new System.Windows.Forms.Button();
            this.button_kom = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.button_panel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.picture_user = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelFormLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_Exit);
            this.panel1.Controls.Add(this.button_setting);
            this.panel1.Controls.Add(this.button_Contract);
            this.panel1.Controls.Add(this.button_kom);
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.button_create);
            this.panel1.Controls.Add(this.button_panel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1206, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 829);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "شناسنامه نرم افزار";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("button_Exit.Image")));
            this.button_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Exit.Location = new System.Drawing.Point(0, 780);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(274, 49);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "خروج";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_setting
            // 
            this.button_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setting.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_setting.ForeColor = System.Drawing.Color.White;
            this.button_setting.Image = ((System.Drawing.Image)(resources.GetObject("button_setting.Image")));
            this.button_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_setting.Location = new System.Drawing.Point(0, 494);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(274, 49);
            this.button_setting.TabIndex = 6;
            this.button_setting.Text = "تنظیمات";
            this.button_setting.UseVisualStyleBackColor = false;
            this.button_setting.Click += new System.EventHandler(this.button_setting_Click);
            // 
            // button_Contract
            // 
            this.button_Contract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Contract.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Contract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Contract.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_Contract.ForeColor = System.Drawing.Color.White;
            this.button_Contract.Image = ((System.Drawing.Image)(resources.GetObject("button_Contract.Image")));
            this.button_Contract.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Contract.Location = new System.Drawing.Point(0, 445);
            this.button_Contract.Name = "button_Contract";
            this.button_Contract.Size = new System.Drawing.Size(274, 49);
            this.button_Contract.TabIndex = 5;
            this.button_Contract.Text = "سامانه پیامک";
            this.button_Contract.UseVisualStyleBackColor = false;
            this.button_Contract.Click += new System.EventHandler(this.button_Contract_Click);
            // 
            // button_kom
            // 
            this.button_kom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_kom.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_kom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kom.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_kom.ForeColor = System.Drawing.Color.White;
            this.button_kom.Image = ((System.Drawing.Image)(resources.GetObject("button_kom.Image")));
            this.button_kom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kom.Location = new System.Drawing.Point(0, 396);
            this.button_kom.Name = "button_kom";
            this.button_kom.Size = new System.Drawing.Size(274, 49);
            this.button_kom.TabIndex = 4;
            this.button_kom.Text = "محاسبات";
            this.button_kom.UseVisualStyleBackColor = false;
            this.button_kom.Click += new System.EventHandler(this.button_kom_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Image = ((System.Drawing.Image)(resources.GetObject("button_search.Image")));
            this.button_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_search.Location = new System.Drawing.Point(0, 347);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(274, 49);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "جستجو";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_create.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_create.ForeColor = System.Drawing.Color.White;
            this.button_create.Image = ((System.Drawing.Image)(resources.GetObject("button_create.Image")));
            this.button_create.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_create.Location = new System.Drawing.Point(0, 298);
            this.button_create.Name = "button_create";
            this.button_create.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_create.Size = new System.Drawing.Size(274, 49);
            this.button_create.TabIndex = 2;
            this.button_create.Text = "ثبت اطلاعات";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_panel
            // 
            this.button_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_panel.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_panel.ForeColor = System.Drawing.Color.White;
            this.button_panel.Image = ((System.Drawing.Image)(resources.GetObject("button_panel.Image")));
            this.button_panel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_panel.Location = new System.Drawing.Point(0, 249);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(274, 49);
            this.button_panel.TabIndex = 1;
            this.button_panel.Text = "پنل کاربری";
            this.button_panel.UseVisualStyleBackColor = false;
            this.button_panel.Click += new System.EventHandler(this.button_panel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_name);
            this.panel2.Controls.Add(this.label_username);
            this.panel2.Controls.Add(this.picture_user);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 249);
            this.panel2.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(6, 218);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(85, 24);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "FullName";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(6, 194);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(94, 24);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "UserName";
            // 
            // picture_user
            // 
            this.picture_user.Image = ((System.Drawing.Image)(resources.GetObject("picture_user.Image")));
            this.picture_user.Location = new System.Drawing.Point(21, 0);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(236, 191);
            this.picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_user.TabIndex = 0;
            this.picture_user.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.labelDate);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label_title);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1206, 62);
            this.panel3.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(167, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(79, 38);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "label";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_title.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(1078, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(128, 44);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "پنل کاربری";
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.BackColor = System.Drawing.Color.White;
            this.panelFormLoader.Controls.Add(this.pictureBox1);
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormLoader.Location = new System.Drawing.Point(0, 62);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(1206, 767);
            this.panelFormLoader.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 31000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1480, 829);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelFormLoader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_setting;
        private System.Windows.Forms.Button button_Contract;
        private System.Windows.Forms.Button button_kom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox picture_user;
        public System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button button1;
    }
}

