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
        public Image image;
        public int i = 0;
        public Clock(bool thereIsTimer)
        {
            InitializeComponent();         
            clockClass = new ClockClass(pictureBox2.CreateGraphics());
            this.thereIsTimer = thereIsTimer;
            image = pictureBox1.Image;

        }

        

        //public Clock(Timer timer)
        //{
        //    InitializeComponent();
        //    timer1 = timer;
        //    clockClass = new ClockClass(CreateGraphics());
        //    thereIsTimer = true;
        //}

        //public void timer1_Tick(object sender, EventArgs e)
        //{
        //    clockClass.DrawClock();
        //}

        //public void InitTimer()
        //{
        //    timer1.Enabled = true;
        //}

        public void InitClock()
        {

            clockClass.DrawClock(12, 0);
        }

        public void DrawClock()
        {           
            clockClass.DrawClock();
        }

        public void UpdateClock(int hour, int minute)
        {
            try
            {
                clockClass.DrawClock(hour, minute);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
             
        }

        private void Clock_Shown(object sender, EventArgs e)
        {
            if (thereIsTimer)
            {
                timer1.Start();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if(i >= 3)
            {
                InitClock();
                timer1.Stop();
            }
        }
    }
}
