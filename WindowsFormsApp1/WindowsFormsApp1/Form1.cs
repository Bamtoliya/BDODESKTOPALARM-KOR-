using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AlarmForm : Form
    {
        private bool dragging = false;
        private bool locked = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public AlarmForm()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        } //Make form hidden in Alt-tab menu

        private void KST_Click(object sender, EventArgs e)
        {

        }
        private void Local_Click(object sender, EventArgs e)
        {

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

            DateTime KSTime = DateTime.UtcNow.AddHours(9);

            KST.Text = KSTime.ToString("HH:mm");
            KSTss.Text = KSTime.ToString("ss");
            KSTWDay.Text = KSTime.ToString("ddd", CultureInfo.CreateSpecificCulture("en-US"));

            if (KSTime.Hour.Equals(00) && KSTime.Minute.Equals(15))
            {
                if(KSTime.DayOfWeek.Equals(DayOfWeek.Wednesday))
                {
                    pictureBox4.Image = imageList1.Images[6];
                    pictureBox4.Visible = true;
                }
            }//00:15 보스알람
            else if (KSTime.Hour.Equals(02) && KSTime.Minute.Equals(00))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    pictureBox2.Image = imageList1.Images[2];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[12];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[13];
                    pictureBox4.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Monday))
                {
                    pictureBox3.Image = imageList1.Images[14];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[7];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Tuesday))
                {
                    pictureBox3.Image = imageList1.Images[14];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[8];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Wednesday))
                {
                    pictureBox2.Image = imageList1.Images[9];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[3];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[2];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Thursday))
                {
                    pictureBox3.Image = imageList1.Images[10];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[13];
                    pictureBox4.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Friday))
                {
                    pictureBox3.Image = imageList1.Images[8];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[12];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Saturday))
                {
                    pictureBox2.Image = imageList1.Images[7];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[12];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[3];
                    pictureBox4.Visible = true;
                }

            }//02:00 보스알람
            else if (KSTime.Hour.Equals(11) && KSTime.Minute.Equals(00))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Sunday) || KSTime.DayOfWeek.Equals(DayOfWeek.Thursday))
                {
                    pictureBox2.Image = imageList1.Images[8];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[14];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[3];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Monday))
                {
                    pictureBox2.Image = imageList1.Images[14];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[3];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[10];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Tuesday))
                {
                    pictureBox2.Image = imageList1.Images[14];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[13];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[2];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Friday))
                {
                    pictureBox2.Image = imageList1.Images[7];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[14];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[13];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Saturday))
                {
                    pictureBox2.Image = imageList1.Images[2];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[3];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[13];
                    pictureBox4.Visible = true;
                }
            }//11:00 보스알람
            else if (KSTime.Hour.Equals(14) && KSTime.Minute.Equals(00))
            {
                pictureBox2.Image = imageList1.Images[0];
                pictureBox2.Visible = true;
            }//14:00 보스알람
            else if (KSTime.Hour.Equals(16) && KSTime.Minute.Equals(00))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    pictureBox2.Image = imageList1.Images[2];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[12];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[13];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Monday))
                {
                    pictureBox2.Image = imageList1.Images[14];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[13];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[2];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Tuesday) || KSTime.DayOfWeek.Equals(DayOfWeek.Wednesday))
                {
                    pictureBox2.Image = imageList1.Images[14];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[3];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[7];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Thursday))
                {
                    pictureBox2.Image = imageList1.Images[10];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[12];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[13];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Friday))
                {
                    pictureBox2.Image = imageList1.Images[10];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[12];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[3];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Saturday))
                {
                    pictureBox2.Image = imageList1.Images[8];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[12];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[14];
                    pictureBox4.Visible = true;
                }

            }//16:00 보스알람
            else if (KSTime.Hour.Equals(17) && KSTime.Minute.Equals(00))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Saturday))
                {
                    pictureBox4.Image = imageList1.Images[1];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    pictureBox4.Image = imageList1.Images[6];
                    pictureBox4.Visible = true;
                }

            }//17:00 보스알람
            else if (KSTime.Hour.Equals(19) && KSTime.Minute.Equals(00))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Wednesday) || KSTime.DayOfWeek.Equals(DayOfWeek.Saturday))
                {
                    pictureBox3.Image = imageList1.Images[16];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[15];
                    pictureBox4.Visible = true;
                }
            }//19:00 보스알람
            else if (KSTime.Hour.Equals(20) && KSTime.Minute.Equals(00))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    pictureBox1.Image = imageList1.Images[7];
                    pictureBox1.Visible = true;
                    pictureBox2.Image = imageList1.Images[10];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[3];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[13];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Monday))
                {
                    pictureBox1.Image = imageList1.Images[12];
                    pictureBox1.Visible = true;
                    pictureBox2.Image = imageList1.Images[3];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[8];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[7];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Tuesday))
                {
                    pictureBox1.Image = imageList1.Images[12];
                    pictureBox1.Visible = true;
                    pictureBox2.Image = imageList1.Images[13];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[2];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[10];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Wednesday))
                {
                    pictureBox1.Image = imageList1.Images[7];
                    pictureBox1.Visible = true;
                    pictureBox2.Image = imageList1.Images[10];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[3];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[13];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Thursday))
                {
                    pictureBox1.Image = imageList1.Images[2];
                    pictureBox1.Visible = true;
                    pictureBox2.Image = imageList1.Images[8];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[3];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[13];
                    pictureBox4.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Friday))
                {
                    pictureBox1.Image = imageList1.Images[2];
                    pictureBox1.Visible = true;
                    pictureBox2.Image = imageList1.Images[7];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[14];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[13];
                    pictureBox4.Visible = true;
                }
            }//20:00 보스알람
            else if (KSTime.Hour.Equals(23) && KSTime.Minute.Equals(15))
            {
                if (!KSTime.DayOfWeek.Equals(DayOfWeek.Saturday))
                {
                    pictureBox4.Image = imageList1.Images[0];
                    pictureBox4.Visible = true;
                }
            }//23:15 보스알람
            else if (KSTime.Hour.Equals(23) && KSTime.Minute.Equals(45))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    pictureBox2.Image = imageList1.Images[2];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[8];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[12];
                    pictureBox4.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Monday))
                {
                    pictureBox2.Image = imageList1.Images[9];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[10];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[2];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Tuesday))
                {
                    pictureBox3.Image = imageList1.Images[8];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[7];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Wednesday))
                {
                    pictureBox3.Image = imageList1.Images[2];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[7];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Thursday))
                {
                    pictureBox3.Image = imageList1.Images[7];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[10];
                    pictureBox4.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Friday))
                {
                    pictureBox2.Image = imageList1.Images[10];
                    pictureBox2.Visible = true;
                    pictureBox3.Image = imageList1.Images[8];
                    pictureBox3.Visible = true;
                    pictureBox4.Image = imageList1.Images[9];
                    pictureBox4.Visible = true;
                }
            }//23:45 보스알람
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
        }//timer send infomation to display  

        private void BDODESKTOPALRAM_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }//timer start with form load

        private void KSTSS_MouseDown(object sender, MouseEventArgs e)
        {
            if (!locked)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }
        private void KSTSS_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void KSTSS_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void BDOtrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void TrayIconMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void TrayIconMenu_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            locked = !locked;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
