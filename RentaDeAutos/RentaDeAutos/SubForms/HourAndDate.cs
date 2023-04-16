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
        private bool isClosed;

        public bool IsClosed { get => isClosed; set => isClosed = value; }

        public DateTime GetDateTime()
        {
            return hourDateClass.DateTime;
        }
        public HourAndDate()
        {
            InitializeComponent();
            InitializeClock();
            hourDateClass = new HourAndDateClass();
            SelectedDay.Text = hourDateClass.GetDate();
            isClosed = false;
        }

        void InitializeClock()
        {
            clock = new Clock();
            clock.TopLevel = false;
            clock.AutoScroll = true;
            clock.Dock = DockStyle.Fill;
            panelClock.Controls.Add(clock);
            clock.Show();
        }

        public string GetDate()
        {
           return hourDateClass.GetDate();
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            hourDateClass.UpdateDateTime(e);
            SelectedDay.Text = hourDateClass.GetDate();
        }

        void UpdateText()
        {
            SelectedDay.Text = hourDateClass.GetDate();
            clock.clockClass.DrawClock(hourDateClass.Hour, hourDateClass.Minute);
        }
        private void hourPlus_Click(object sender, EventArgs e)
        {
            hourDateClass.updateHour(1);
            UpdateText();
        }

        private void quarterMinPLus_Click(object sender, EventArgs e)
        {
            hourDateClass.UpdateMinute(15);
            UpdateText();
        }

        private void oneMinutePlus_Click(object sender, EventArgs e)
        {
            hourDateClass.UpdateMinute(1);
            UpdateText();
        }

        private void oneMinuteMinus_Click(object sender, EventArgs e)
        {
            hourDateClass.UpdateMinute(-1);
            UpdateText();
        }

        private void quarterMinMinus_Click(object sender, EventArgs e)
        {
            hourDateClass.UpdateMinute(-15);
            UpdateText();
        }

        private void hourMinus_Click(object sender, EventArgs e)
        {
            hourDateClass.updateHour(-1);
            UpdateText();
        }

        private void HourAndDate_Shown(object sender, EventArgs e)
        {
            clock.InitClock();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            isClosed = true;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            isClosed = true;
            this.Close();
        }
    }
}
