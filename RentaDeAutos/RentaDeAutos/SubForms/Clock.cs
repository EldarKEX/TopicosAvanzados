using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentaDeAutos.Class;

namespace RentaDeAutos.SubForms
{
    public partial class Clock : Form
    {
        public ClockClass clockClass;
        public bool thereIsTimer;
        public Clock()
        {
            InitializeComponent();         
            clockClass = new ClockClass(CreateGraphics());
            thereIsTimer = false;
        }

        public Clock(Timer timer)
        {
            InitializeComponent();
            timer1 = timer;
            clockClass = new ClockClass(CreateGraphics());
            thereIsTimer = true;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            clockClass.DrawClock();
        }

        public void InitTimer()
        {
            timer1.Enabled = true;
        }

        public void InitClock()
        {
            clockClass.DrawClock(12,0);
        }
        private void Clock_Shown(object sender, EventArgs e)
        {
            if (thereIsTimer)
            {
                InitTimer();
                return;
            }
            
        }
    }
}
