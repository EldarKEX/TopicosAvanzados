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
using RentaDeAutos.SubForms;

namespace RentaDeAutos
{
    public partial class Main : Form
    {
        private Clock clock;
        private Thread clockThread;
        private Thread carGalleryThread;
        private CarGallery car;

        ManualResetEvent _event = new ManualResetEvent(true);
        public Main()
        {
            InitializeComponent();
            InitailizeClock();
            carGalleryThread = new Thread(ShowCar);
            carGalleryThread.Start();
        }

        void InitailizeClock()
        {
            clock = new Clock();            
            clock.TopLevel = false;
            clock.AutoScroll = true;
            clock.Dock = DockStyle.Fill;
            panelClock.Controls.Add(clock);
            clock.Show();

            clockThread = new Thread(DrawClock);
            clockThread.Start();
        }
        void DrawClock()
        {
            while (true)
            {
                clock.DrawClock();
                Thread.Sleep(1000);
            }
        }

        void ShowCar()
        {
            int previousId = -1;
            _event.Reset();

            while (true)
            {
                _event.WaitOne();

                if (car.IsClosed)
                {
                    if (!car.ThereIsData)
                    {
                        btnCar.Text = "Elegir Auto";
                        btnCar.Tag = -1;
                    }
                    _event.Reset();
                }

                if (car.DataCar.Id == -1 || car.DataCar.Id == previousId)
                {                   
                    continue;
                }

                btnCar.Text = car.DataCar.Brand + " - " + car.DataCar.Model;
                btnCar.Tag = car.DataCar.Id;

                previousId = car.DataCar.Id;
                Thread.Sleep(500);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            clockThread.Abort();
            carGalleryThread.Abort();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            //clock.DrawClock();
        }

        private void BtnCar_Click(object sender, EventArgs e)
        {
            car = new CarGallery();
            car.Show();

            _event.Set();

            

        }
    }
}
