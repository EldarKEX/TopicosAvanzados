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
        private CarGallery carGallery;
        private HourAndDate hourDateStart;
        private HourAndDate hourDateFinal;
        private MainClass mainClass;

        private Thread clockThread;
        private Thread carGalleryThread;
        private Thread dateStartThread;
        private Thread dateFinalThread;
        

        ManualResetEvent _event = new ManualResetEvent(true);
        ManualResetEvent _event1 = new ManualResetEvent(true);
        ManualResetEvent _event2 = new ManualResetEvent(true);
        public Main()
        {
            InitializeComponent();
            InitializeClock();
            InitializeCarGallery();
            InitializeHourDate();

            mainClass = new MainClass();
        }

        void InitializeClock()
        {
            clock = new Clock(false);            
            clock.TopLevel = false;
            clock.AutoScroll = true;
            clock.Dock = DockStyle.Fill;
            panelClock.Controls.Add(clock);
            clock.Show();

            clockThread = new Thread(ShowClock);
            clockThread.Start();
        }

        void InitializeCarGallery()
        {
            carGallery = new CarGallery();
            carGalleryThread = new Thread(ShowCar);
            carGalleryThread.Start();
        }

        void InitializeHourDate()
        {
            hourDateStart = new HourAndDate();
            dateStartThread = new Thread(ShowDateStart);
            dateStartThread.Start();

            hourDateFinal = new HourAndDate();
            dateFinalThread = new Thread(ShowDateFinal);
            dateFinalThread.Start();
        }
        void ShowClock()
        {
            while (true)
            {
                clock.DrawClock();
                Thread.Sleep(1000);
            }
        }


        void CalcTotalAmount()
        {
            if (tbDateStart.Text != "" && tbDateFinal.Text != "")
            {
                Double total = (hourDateFinal.GetDateTime() - hourDateStart.GetDateTime()).TotalDays;
                
                if(total <= 0)
                {
                    labelError.Text = "La fecha de devolucion debe ser mayor a la fecha de salida";
                    return;
                }

                labelError.Text = "";

                if (carGallery.DataCar.Cost != "")
                {
                    
                    total = total * Double.Parse(carGallery.DataCar.Cost);
                    tbAmount.Text = String.Format("{0:F2}",total);
                }
            }
        }

        void ShowCar()
        {
            int previousId = -1;
            _event.Reset();

            while (true)
            {
                _event.WaitOne();

                if (carGallery.IsClosed)
                {
                    if (!carGallery.ThereIsData)
                    {
                        btnCar.Text = "Elegir Auto";
                        btnCar.Tag = -1;
                    }
               
                    _event.Reset();
                    continue;
                }

                if (carGallery.DataCar.Id == -1 || carGallery.DataCar.Id == previousId)
                {                   
                    continue;
                }

                btnCar.Text = carGallery.DataCar.Brand + " - " + carGallery.DataCar.Model;
                btnCar.Tag = carGallery.DataCar.Id;
                CalcTotalAmount();

                previousId = carGallery.DataCar.Id;

                Thread.Sleep(500);
            }
        }

        public void fillTbStart(string text)
        {
            tbDateStart.Text = text;
        }

        void ShowDateStart()
        {
            _event1.Reset();

            while (true)
            {
                _event1.WaitOne();

                if (hourDateStart.IsClosed)
                {                   
                    _event1.Reset();
                    continue;
                }

                

                fillTbStart(hourDateStart.GetDate());
                CalcTotalAmount();

                Thread.Sleep(500);
            }
        }

        void ShowDateFinal()
        {
            _event2.Reset();
   
            while (true)
            {
                _event2.WaitOne();

                if (hourDateFinal.IsClosed)
                {
                    _event2.Reset();
                    continue;
                }


                tbDateFinal.Text = hourDateFinal.GetDate();
                CalcTotalAmount();

                Thread.Sleep(500);
            }
        }


        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            clockThread.Abort();
            carGalleryThread.Abort();
            dateStartThread.Abort();
            dateFinalThread.Abort();
        }


        private void BtnCar_Click(object sender, EventArgs e)
        {
            try
            {
                carGallery = new CarGallery();
                carGallery.Show();
                _event.Set();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void DateStart_Click(object sender, EventArgs e)
        {
            try
            {
                hourDateStart = new HourAndDate();
                hourDateStart.Show();
                _event1.Set();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
    
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnDateEnd_Click(object sender, EventArgs e)
        {
            try
            {
                hourDateFinal = new HourAndDate();
                hourDateFinal.Show();
                _event2.Set();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                mainClass.Error = "";
                if (!mainClass.ValidateAll(tbCustomer.Text,tbLastName.Text,tbAmount.Text,tbAddress.Text,btnCar.Text,tbCel.Text))
                {
                    return;
                }
                
                this.purchaseTableAdapter.InsertQuery(
                    hourDateStart.GetDateTime(),
                    hourDateFinal.GetDateTime(),
                    Double.Parse(tbAmount.Text),
                    tbCustomer.Text,
                    tbCel.Text,
                    tbAddress.Text,
                    int.Parse(btnCar.Tag.ToString()),
                    tbLastName.Text
                );

                MessageBox.Show("Datos Agregados Correctamente");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

       
    }
}
