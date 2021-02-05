
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
            this.TrayIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // KST
            // 
            this.KST.AutoSize = true;
            this.KST.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KST.ForeColor = System.Drawing.Color.White;
            this.KST.Location = new System.Drawing.Point(530, 30);
            this.KST.Name = "KST";
            this.KST.Size = new System.Drawing.Size(173, 67);
            this.KST.TabIndex = 0;
            this.KST.Text = "33:33";
            this.KST.Click += new System.EventHandler(this.KST_Click);
            // 
            // Local
            // 
            this.Local.AutoSize = true;
            this.Local.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Local.ForeColor = System.Drawing.Color.White;
            this.Local.Location = new System.Drawing.Point(530, 96);
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
            this.KSTss.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KSTss.ForeColor = System.Drawing.Color.White;
            this.KSTss.Location = new System.Drawing.Point(704, 30);
            this.KSTss.Name = "KSTss";
            this.KSTss.Size = new System.Drawing.Size(95, 67);
            this.KSTss.TabIndex = 0;
            this.KSTss.Text = "33";
            this.KSTss.Click += new System.EventHandler(this.KST_Click);
            // 
            // Localss
            // 
            this.Localss.AutoSize = true;
            this.Localss.Font = new System.Drawing.Font("DS-Digital", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Localss.ForeColor = System.Drawing.Color.White;
            this.Localss.Location = new System.Drawing.Point(704, 96);
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
            this.LocalWDay.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LocalWDay.ForeColor = System.Drawing.Color.White;
            this.LocalWDay.Location = new System.Drawing.Point(399, 97);
            this.LocalWDay.Name = "LocalWDay";
            this.LocalWDay.Size = new System.Drawing.Size(128, 67);
            this.LocalWDay.TabIndex = 2;
            this.LocalWDay.Text = "DAY";
            // 
            // KSTWDay
            // 
            this.KSTWDay.AutoSize = true;
            this.KSTWDay.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KSTWDay.ForeColor = System.Drawing.Color.White;
            this.KSTWDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KSTWDay.Location = new System.Drawing.Point(399, 30);
            this.KSTWDay.Name = "KSTWDay";
            this.KSTWDay.Size = new System.Drawing.Size(128, 67);
            this.KSTWDay.TabIndex = 3;
            this.KSTWDay.Text = "DAy";
            // 
            // Alarm
            // 
            this.Alarm.Dock = System.Windows.Forms.DockStyle.Right;
            this.Alarm.Font = new System.Drawing.Font("맑은 고딕", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Alarm.Location = new System.Drawing.Point(100, 0);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(700, 200);
            this.Alarm.TabIndex = 0;
            this.Alarm.Text = "크자카/누베르";
            this.Alarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Alarm.Visible = false;
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 200);
            this.ControlBox = false;
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
            this.Location = new System.Drawing.Point(1260, 880);
            this.Name = "AlarmForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "XD";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.BDODESKTOPALRAM_Load);
            this.TrayIconMenu.ResumeLayout(false);
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
    }
}

