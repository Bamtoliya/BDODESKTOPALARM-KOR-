
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmForm));
            this.KST = new System.Windows.Forms.Label();
            this.Local = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.KSTss = new System.Windows.Forms.Label();
            this.Localss = new System.Windows.Forms.Label();
            this.BDOtrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalWDay = new System.Windows.Forms.Label();
            this.KSTWDay = new System.Windows.Forms.Label();
            this.Alarm = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TrayIconMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // KST
            // 
            this.KST.AutoSize = true;
            this.KST.BackColor = System.Drawing.Color.Transparent;
            this.KST.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KST.ForeColor = System.Drawing.Color.White;
            this.KST.Location = new System.Drawing.Point(531, 228);
            this.KST.Name = "KST";
            this.KST.Size = new System.Drawing.Size(173, 67);
            this.KST.TabIndex = 0;
            this.KST.Text = "33:33";
            this.KST.Click += new System.EventHandler(this.KST_Click);
            // 
            // Local
            // 
            this.Local.AutoSize = true;
            this.Local.BackColor = System.Drawing.Color.Transparent;
            this.Local.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Local.ForeColor = System.Drawing.Color.White;
            this.Local.Location = new System.Drawing.Point(531, 293);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(173, 67);
            this.Local.TabIndex = 0;
            this.Local.Text = "35:77";
            this.Local.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Local.Click += new System.EventHandler(this.Local_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // KSTss
            // 
            this.KSTss.AutoSize = true;
            this.KSTss.BackColor = System.Drawing.Color.Transparent;
            this.KSTss.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KSTss.ForeColor = System.Drawing.Color.White;
            this.KSTss.Location = new System.Drawing.Point(704, 228);
            this.KSTss.Name = "KSTss";
            this.KSTss.Size = new System.Drawing.Size(95, 67);
            this.KSTss.TabIndex = 0;
            this.KSTss.Text = "33";
            this.KSTss.Click += new System.EventHandler(this.KST_Click);
            // 
            // Localss
            // 
            this.Localss.AutoSize = true;
            this.Localss.BackColor = System.Drawing.Color.Transparent;
            this.Localss.Font = new System.Drawing.Font("DS-Digital", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Localss.ForeColor = System.Drawing.Color.White;
            this.Localss.Location = new System.Drawing.Point(704, 293);
            this.Localss.Name = "Localss";
            this.Localss.Size = new System.Drawing.Size(96, 66);
            this.Localss.TabIndex = 0;
            this.Localss.Text = "66";
            this.Localss.Click += new System.EventHandler(this.Local_Click);
            // 
            // BDOtrayIcon
            // 
            this.BDOtrayIcon.ContextMenuStrip = this.TrayIconMenu;
            this.BDOtrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("BDOtrayIcon.Icon")));
            this.BDOtrayIcon.Text = "BDOtrayIcon";
            this.BDOtrayIcon.Visible = true;
            this.BDOtrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BDOtrayIcon_MouseDoubleClick);
            // 
            // TrayIconMenu
            // 
            this.TrayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.TrayIconMenu.Name = "trayIconMenu";
            this.TrayIconMenu.Size = new System.Drawing.Size(118, 70);
            this.TrayIconMenu.Text = "TrayIconMenu";
            this.TrayIconMenu.Opening += new System.ComponentModel.CancelEventHandler(this.TrayIconMenu_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem1.Text = "Open";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem2.Text = "Settings";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem3.Text = "Exit";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // LocalWDay
            // 
            this.LocalWDay.AutoSize = true;
            this.LocalWDay.BackColor = System.Drawing.Color.Transparent;
            this.LocalWDay.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LocalWDay.ForeColor = System.Drawing.Color.White;
            this.LocalWDay.Location = new System.Drawing.Point(409, 293);
            this.LocalWDay.Name = "LocalWDay";
            this.LocalWDay.Size = new System.Drawing.Size(128, 67);
            this.LocalWDay.TabIndex = 2;
            this.LocalWDay.Text = "DAY";
            // 
            // KSTWDay
            // 
            this.KSTWDay.AutoSize = true;
            this.KSTWDay.BackColor = System.Drawing.Color.Transparent;
            this.KSTWDay.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KSTWDay.ForeColor = System.Drawing.Color.White;
            this.KSTWDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KSTWDay.Location = new System.Drawing.Point(409, 228);
            this.KSTWDay.Name = "KSTWDay";
            this.KSTWDay.Size = new System.Drawing.Size(128, 67);
            this.KSTWDay.TabIndex = 3;
            this.KSTWDay.Text = "DAy";
            // 
            // Alarm
            // 
            this.Alarm.BackColor = System.Drawing.Color.Transparent;
            this.Alarm.Font = new System.Drawing.Font("맑은 고딕", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Alarm.Location = new System.Drawing.Point(12, 215);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(788, 145);
            this.Alarm.TabIndex = 0;
            this.Alarm.Text = "크자카/누베르";
            this.Alarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Alarm.Visible = false;
            this.Alarm.Click += new System.EventHandler(this.Alarm_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "garmoth.png");
            this.imageList1.Images.SetKeyName(1, "karanda.png");
            this.imageList1.Images.SetKeyName(2, "kutum.png");
            this.imageList1.Images.SetKeyName(3, "kzarka.png");
            this.imageList1.Images.SetKeyName(4, "muraka.png");
            this.imageList1.Images.SetKeyName(5, "nouver.png");
            this.imageList1.Images.SetKeyName(6, "offin.png");
            this.imageList1.Images.SetKeyName(7, "quint.png");
            this.imageList1.Images.SetKeyName(8, "vell.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(148, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(310, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(461, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Alarm);
            this.Controls.Add(this.KSTWDay);
            this.Controls.Add(this.LocalWDay);
            this.Controls.Add(this.Localss);
            this.Controls.Add(this.Local);
            this.Controls.Add(this.KSTss);
            this.Controls.Add(this.KST);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Location = new System.Drawing.Point(1260, 720);
            this.Name = "AlarmForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "XD";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.BDODESKTOPALRAM_Load);
            this.TrayIconMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label KST;
        private System.Windows.Forms.Label Local;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label KSTss;
        private System.Windows.Forms.Label Localss;
        private System.Windows.Forms.NotifyIcon BDOtrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label LocalWDay;
        private System.Windows.Forms.Label KSTWDay;
        private System.Windows.Forms.Label Alarm;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

