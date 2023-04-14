using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RentaDeAutos.Class;

namespace RentaDeAutos.SubForms
{
    public partial class HourAndDate : Form
    {
        private HourAndDateClass hourDateClass;
        private Clock clock;
        public HourAndDate()
        {
            InitializeComponent();
            hourDateClass = new HourAndDateClass();
            SelectedDay.Text = hourDateClass.GetDate();
            clock = new Clock();
            clock.TopLevel = false;
            clock.AutoScroll = true;
            clock.Dock = DockStyle.Fill;
            panelClock.Controls.Add(clock);           
            clock.Show();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            hourDateClass.UpdateDateTime(e);
            SelectedDay.Text = hourDateClass.GetDate();
        }

        private void hourPlus_Click(object sender, EventArgs e)
        {
            hourDateClass.updateHour(1);
            SelectedDay.Text = hourDateClass.GetDate();
            clock.clockClass.DrawClock(hourDateClass.Hour, hourDateClass.Minute);
        }

        private void quarterMinPLus_Click(object sender, EventArgs e)
        {
            hourDateClass.UpdateMinute(15);
            SelectedDay.Text = hourDateClass.GetDate();
            clock.clockClass.DrawClock(hourDateClass.Hour, hourDateClass.Minute);
        }

        private void oneMinutePlus_Click(object sender, EventArgs e)
        {
            hourDateClass.UpdateMinute(1);
            SelectedDay.Text = hourDateClass.GetDate();
            clock.clockClass.DrawClock(hourDateClass.Hour, hourDateClass.Minute);
        }

        private void oneMinuteMinus_Click(object sender, EventArgs e)
        {
            hourDateClass.UpdateMinute(-1);
            SelectedDay.Text = hourDateClass.GetDate();
            clock.clockClass.DrawClock(hourDateClass.Hour, hourDateClass.Minute);
        }

        private void quarterMinMinus_Click(object sender, EventArgs e)
        {
            hourDateClass.UpdateMinute(-15);
            SelectedDay.Text = hourDateClass.GetDate();
            clock.clockClass.DrawClock(hourDateClass.Hour, hourDateClass.Minute);
        }

        private void hourMinus_Click(object sender, EventArgs e)
        {
            hourDateClass.updateHour(-1);
            SelectedDay.Text = hourDateClass.GetDate();
            clock.clockClass.DrawClock(hourDateClass.Hour, hourDateClass.Minute);
        }

        private void HourAndDate_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void HourAndDate_Shown(object sender, EventArgs e)
        {
            clock.InitClock();
        }

        private void HourAndDate_Load(object sender, EventArgs e)
        {
            
        }
    }
}
