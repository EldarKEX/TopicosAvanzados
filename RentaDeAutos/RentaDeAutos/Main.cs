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
using SqlRentCar;


namespace RentaDeAutos
{
    public partial class Main : Form
    {
        private Clock clock;
        private CarGallery carGallery;
        private HourAndDate hourDateStart;
        private HourAndDate hourDateFinal;
        private MainClass mainClass;
        private bool thereIsUpdate;

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

            thereIsUpdate = false;
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

                if (total <= 0)
                {
                    labelError.Text = "La fecha de devolucion debe ser mayor a la fecha de salida";
                    return;
                }

                labelError.Text = "";

                if (carGallery.DataCar.Cost != "")
                {

                    total = total * Double.Parse(carGallery.DataCar.Cost);
                    tbAmount.Text = String.Format("{0:F2}", total);
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
            } catch (Exception ex)
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




        //==================================================================================================
        public bool ValidateFields()
        {
            mainClass.Error = "";
            if (!mainClass.ValidateAll(tbCustomer.Text, tbLastName.Text, tbAmount.Text, tbAddress.Text, btnCar.Text, tbCel.Text))
            {
                return false;
            }
            return true;
        }

        //Guardar Registros
        void SavePurchase()
        {

            if (tbFolio.Text != "")
            {
                new SqlConexionClass().InsertData(
                    int.Parse(tbFolio.Text),
                    hourDateStart.GetDateTime(),
                    hourDateFinal.GetDateTime(),
                    Double.Parse(tbAmount.Text),
                    tbCustomer.Text,
                    tbCel.Text,
                    tbAddress.Text,
                    tbLastName.Text,
                    int.Parse(btnCar.Tag.ToString())
                );
                return;
            }

            new SqlConexionClass().InsertData(
                hourDateStart.GetDateTime(),
                hourDateFinal.GetDateTime(),
                Double.Parse(tbAmount.Text),
                tbCustomer.Text,
                tbCel.Text,
                tbAddress.Text,
                tbLastName.Text,
                int.Parse(btnCar.Tag.ToString())
            );
        }

        //Actualizar registros
        void UpdatePurchase()
        {

            new SqlConexionClass().UpdateRecord(
                int.Parse(tbFolio.Text),
                hourDateStart.GetDateTime(),
                hourDateFinal.GetDateTime(),
                double.Parse(tbAmount.Text),
                tbCustomer.Text,
                tbCel.Text,
                tbAddress.Text,
                tbLastName.Text,
                int.Parse(btnCar.Tag.ToString())
            );

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (!ValidateFields())
                {
                    return;
                }

                if (thereIsUpdate)
                {
                    UpdatePurchase();
                    DialogResult dialogResult = MessageBox.Show("¿Desea guardar los cambios?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }

                    MessageBox.Show("Datos Actualizados Correctamente");

                    return;
                }

                SavePurchase();


                MessageBox.Show("Datos Agregados Correctamente");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        //Si se teclea un folio
        private void tbFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

        }

        //Borra todos los datos
        void EraseData()
        {
            tbDateStart.Text = "";
            tbDateFinal.Text = "";
            tbAmount.Text = "";
            tbCustomer.Text = "";
            tbCel.Text = "";
            tbAddress.Text = "";
            tbLastName.Text = "";
            btnCar.Text = "Elegir Auto";
            btnCar.Tag = -1;
        }


        //Llenar los datos
        void FillData(DataRow dataRow)
        {
            tbDateStart.Text = dataRow[1].ToString();
            tbDateFinal.Text = dataRow[2].ToString();
            tbAmount.Text = dataRow[3].ToString();
            tbCustomer.Text = dataRow[4].ToString();
            tbCel.Text = dataRow[5].ToString();
            tbAddress.Text = dataRow[6].ToString();
            tbLastName.Text = dataRow[8].ToString();

            int index = (int)dataRow[7];
            DataRow dataCar = new CarGallery().GetCarById(index);


            btnCar.Text = dataCar[1].ToString() + " - " + dataCar[5].ToString();
            btnCar.Tag = index;
        }


        //Si se cambia el texto del folio
        private void tbFolio_TextChanged(object sender, EventArgs e)
        {
            if (tbFolio.Text == "")
            {
                thereIsUpdate = false;
                btnSave.Text = "Guardar Compra";
                EraseData();
                return;
            }
            DataRow dataRow = new SqlConexionClass().GetRecordPurchase(int.Parse(tbFolio.Text));


            if (dataRow == null)
            {
                if (thereIsUpdate)
                {
                    EraseData();
                }
                thereIsUpdate = false;
                btnSave.Text = "Guardar Compra";
                return;
            }




            btnSave.Text = "Actualizar datos Compra";
            thereIsUpdate = true;
            FillData(dataRow);



        }

        //Genera un folio en automativco
        void AutoFolio()
        {
            DataRow data = new SqlConexionClass().GetNextId();
            int id = int.Parse(data[0].ToString());
            id++;
            tbFolio.Text = id.ToString();
        }
        private void btnAasignar_Click(object sender, EventArgs e)
        {
            if (thereIsUpdate)
            {
                EraseData();
                thereIsUpdate = false;
            }
            AutoFolio();
            
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {
                Form main = new SubForms.History();
                main.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
