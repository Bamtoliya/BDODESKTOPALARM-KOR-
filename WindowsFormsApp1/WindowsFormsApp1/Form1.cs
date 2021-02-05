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
            DateTime LocalTime = DateTime.UtcNow.AddHours(-5);
            KST.Text = KSTime.ToString("HH:mm");
            KSTss.Text = KSTime.ToString("ss");
            KSTWDay.Text = KSTime.ToString("ddd", CultureInfo.CreateSpecificCulture("en-US"));
            Local.Text = LocalTime.ToString("HH:mm");
            Localss.Text = LocalTime.ToString("ss");
            LocalWDay.Text = LocalTime.ToString("ddd", CultureInfo.CreateSpecificCulture("en-US"));

            if (KSTime.Hour.Equals(0) && KSTime.Minute.Equals(15))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Wednesday))
                {
                    Alarm.Text = "가모스";
                    Alarm.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Thursday))
                {
                    Alarm.Text = "벨";
                    Alarm.Visible = true;
                }
            }//00:15 보스알람
            else if (KSTime.Hour.Equals(2) && KSTime.Minute.Equals(00))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    Alarm.Text = "카란다/쿠툼";
                    Alarm.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Monday))
                {
                    Alarm.Text = "크자카";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Tuesday))
                {
                    Alarm.Text = "크자카";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Wednesday))
                {
                    Alarm.Text = "누베르/오핀";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Thursday))
                {
                    Alarm.Text = "쿠툼";
                    Alarm.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Friday))
                {
                    Alarm.Text = "카란다";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Saturday))
                {
                    Alarm.Text = "카란다/누베르";
                    Alarm.Visible = true;
                }

            }//02:00 보스알람
            else if (KSTime.Hour.Equals(11) && KSTime.Minute.Equals(00))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    Alarm.Text = "크자카/누베르";
                    Alarm.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Monday))
                {
                    Alarm.Text = "크자카/누베르";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Tuesday))
                {
                    Alarm.Text = "크자카/쿠툼";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Thursday))
                {
                    Alarm.Text = "크자카/누베르";
                    Alarm.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Friday))
                {
                    Alarm.Text = "크자카/쿠툼";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Saturday))
                {
                    Alarm.Text = "누베르/쿠툼";
                    Alarm.Visible = true;
                }
            }//11:00 보스알람
            else if (KSTime.Hour.Equals(16) && KSTime.Minute.Equals(00))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    Alarm.Text = "크자카/누베르";
                    Alarm.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Monday))
                {
                    Alarm.Text = "크자카/쿠툼";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Tuesday))
                {
                    Alarm.Text = "크자카/누베르";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Wednesday))
                {
                    Alarm.Text = "크자카/누베르";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Thursday))
                {
                    Alarm.Text = "카란다/쿠툼";
                    Alarm.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Friday))
                {
                    Alarm.Text = "카란다/누베르";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Saturday))
                {
                    Alarm.Text = "카란다/크자카";
                    Alarm.Visible = true;
                }

            }//16:00 보스알람
            else if (KSTime.Hour.Equals(17) && KSTime.Minute.Equals(00))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    Alarm.Text = "벨";
                    Alarm.Visible = true;

                }

            }//17:00 보스알람
            else if (KSTime.Hour.Equals(19) && KSTime.Minute.Equals(00))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    Alarm.Text = "귄트/무라카";
                    Alarm.Visible = true;

                }
            }//19:00 보스알람
            else if (KSTime.Hour.Equals(20) && KSTime.Minute.Equals(00))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    Alarm.Text = "누베르/쿠툼";
                    Alarm.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Monday))
                {
                    Alarm.Text = "카란다/누베르";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Tuesday))
                {
                    Alarm.Text = "카란다/쿠툼";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Wednesday))
                {
                    Alarm.Text = "카란다/크자카";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Thursday))
                {
                    Alarm.Text = "누베르/쿠툼";
                    Alarm.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Friday))
                {
                    Alarm.Text = "크자카/쿠툼";
                    Alarm.Visible = true;
                }
            }//20:00 보스알람
            else if (KSTime.Hour.Equals(23) && KSTime.Minute.Equals(15))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Wednesday))
                {
                    Alarm.Text = "귄트/무라카";
                    Alarm.Visible = true;
                }
            }//23:15 보스알람
            else if (KSTime.Hour.Equals(23) && KSTime.Minute.Equals(45))
            {
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    Alarm.Text = "카란다";
                    Alarm.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Monday))
                {
                    Alarm.Text = "오핀";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Tuesday))
                {
                    Alarm.Text = "가모스";
                    Alarm.Visible = true;
                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Thursday))
                {
                    Alarm.Text = "가모스";
                    Alarm.Visible = true;

                }
                if (KSTime.DayOfWeek.Equals(DayOfWeek.Friday))
                {
                    Alarm.Text = "오핀";
                    Alarm.Visible = true;
                }
            }//23:45 보스알람
            else
            {
                Alarm.Visible = false;
            }
        }//timer send infomation to display  

        private void BDODESKTOPALRAM_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }//timer start with form load
 
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
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//terminate the program

    }
}
