
namespace WindowsFormsApp1
{
    partial class AlarmForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmForm));
            KST = new System.Windows.Forms.Label();
            Timer1 = new System.Windows.Forms.Timer(components);
            KSTss = new System.Windows.Forms.Label();
            BDOtrayIcon = new System.Windows.Forms.NotifyIcon(components);
            TrayIconMenu = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            KSTWDay = new System.Windows.Forms.Label();
            imageList1 = new System.Windows.Forms.ImageList(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            TrayIconMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // KST
            // 
            KST.AutoSize = true;
            KST.BackColor = System.Drawing.Color.Transparent;
            KST.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            KST.ForeColor = System.Drawing.Color.White;
            KST.Location = new System.Drawing.Point(545, 294);
            KST.Name = "KST";
            KST.Size = new System.Drawing.Size(173, 67);
            KST.TabIndex = 0;
            KST.Text = "33:33";
            KST.Click += KST_Click;
            // 
            // Timer1
            // 
            Timer1.Interval = 1000;
            Timer1.Tick += Timer1_Tick;
            // 
            // KSTss
            // 
            KSTss.AutoSize = true;
            KSTss.BackColor = System.Drawing.Color.Transparent;
            KSTss.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            KSTss.ForeColor = System.Drawing.Color.White;
            KSTss.Location = new System.Drawing.Point(704, 294);
            KSTss.Name = "KSTss";
            KSTss.Size = new System.Drawing.Size(95, 67);
            KSTss.TabIndex = 0;
            KSTss.Text = "33";
            KSTss.Click += KST_Click;
            KSTss.MouseDown += KSTSS_MouseDown;
            KSTss.MouseMove += KSTSS_MouseMove;
            KSTss.MouseUp += KSTSS_MouseUp;
            // 
            // BDOtrayIcon
            // 
            BDOtrayIcon.ContextMenuStrip = TrayIconMenu;
            BDOtrayIcon.Icon = (System.Drawing.Icon)resources.GetObject("BDOtrayIcon.Icon");
            BDOtrayIcon.Text = "BDOtrayIcon";
            BDOtrayIcon.Visible = true;
            BDOtrayIcon.MouseDoubleClick += BDOtrayIcon_MouseDoubleClick;
            // 
            // TrayIconMenu
            // 
            TrayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            TrayIconMenu.Name = "trayIconMenu";
            TrayIconMenu.Size = new System.Drawing.Size(134, 70);
            TrayIconMenu.Text = "TrayIconMenu";
            TrayIconMenu.Opening += TrayIconMenu_Opening;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Checked = true;
            toolStripMenuItem1.CheckOnClick = true;
            toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            toolStripMenuItem1.Text = "Open/Hide";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.CheckOnClick = true;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            toolStripMenuItem2.Text = "Lock";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
            toolStripMenuItem3.Text = "Exit";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // KSTWDay
            // 
            KSTWDay.AutoSize = true;
            KSTWDay.BackColor = System.Drawing.Color.Transparent;
            KSTWDay.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            KSTWDay.ForeColor = System.Drawing.Color.White;
            KSTWDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            KSTWDay.Location = new System.Drawing.Point(426, 294);
            KSTWDay.Name = "KSTWDay";
            KSTWDay.Size = new System.Drawing.Size(128, 67);
            KSTWDay.TabIndex = 3;
            KSTWDay.Text = "DAy";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "가모스.bmp");
            imageList1.Images.SetKeyName(1, "검은그림자.bmp");
            imageList1.Images.SetKeyName(2, "금돼지왕.bmp");
            imageList1.Images.SetKeyName(3, "누베르.bmp");
            imageList1.Images.SetKeyName(4, "라우라우.bmp");
            imageList1.Images.SetKeyName(5, "베빨우.bmp");
            imageList1.Images.SetKeyName(6, "벨.bmp");
            imageList1.Images.SetKeyName(7, "불가살.bmp");
            imageList1.Images.SetKeyName(8, "산군.bmp");
            imageList1.Images.SetKeyName(9, "오핀.bmp");
            imageList1.Images.SetKeyName(10, "우투리.bmp");
            imageList1.Images.SetKeyName(11, "지늑카츠.bmp");
            imageList1.Images.SetKeyName(12, "카란다.bmp");
            imageList1.Images.SetKeyName(13, "쿠툼.bmp");
            imageList1.Images.SetKeyName(14, "크자카.bmp");
            imageList1.Images.SetKeyName(15, "muraka.png");
            imageList1.Images.SetKeyName(16, "quint.png");
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = BDODesktopAlarm.Properties.Resources.가모스;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(71, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(200, 200);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = BDODesktopAlarm.Properties.Resources.카란다;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new System.Drawing.Point(248, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(200, 200);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = BDODesktopAlarm.Properties.Resources.누베르;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new System.Drawing.Point(426, 91);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(200, 200);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = BDODesktopAlarm.Properties.Resources.지늑카츠;
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new System.Drawing.Point(599, 91);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(200, 200);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // AlarmForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DimGray;
            ClientSize = new System.Drawing.Size(800, 360);
            ControlBox = false;
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(KSTWDay);
            Controls.Add(KSTss);
            Controls.Add(KST);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ImeMode = System.Windows.Forms.ImeMode.Off;
            Location = new System.Drawing.Point(1260, 720);
            Name = "AlarmForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "XD";
            TopMost = true;
            TransparencyKey = System.Drawing.Color.DimGray;
            Load += BDODESKTOPALRAM_Load;
            TrayIconMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label KST;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label KSTss;
        private System.Windows.Forms.NotifyIcon BDOtrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label KSTWDay;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

