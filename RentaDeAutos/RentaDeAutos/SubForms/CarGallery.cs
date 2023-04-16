using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RentaDeAutos.Class;
using RentaDeAutos.UserControls;


namespace RentaDeAutos.SubForms
{
    public partial class CarGallery : Form
    {
        private CarGalleryClass carGalleryClass;
        private bool thereIsData;
        private bool isClosed;

        public CarGallery()
        {
            InitializeComponent();
            carGalleryClass = new CarGalleryClass(carTableAdapter.GetData());
            thereIsData = false;
            isClosed = false;
        }

        public CarDataClass DataCar{
            get{
                if (carGalleryClass.CarContainer == null)
                {
                    return new CarDataClass();
                }
                return carGalleryClass.CarContainer.CarData;
            }
        }

        public bool IsClosed { get => isClosed; set => isClosed = value; }
        public bool ThereIsData { get => thereIsData; set => thereIsData = value; }

        public void LoadControlUser()
        {
            foreach (CarDataClass car in carGalleryClass.CarList)
            {
                CarContainer carContainer = new CarContainer(car,carGalleryClass);
                
                flowLayoutPanel1.Controls.Add(carContainer);
            }
        }

    

        private void CarGallery_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rENTCARDataSet.Car' Puede moverla o quitarla según sea necesario.
            this.carTableAdapter.Fill(this.rENTCARDataSet.Car);
           
        }

        private void CarGallery_Shown(object sender, EventArgs e)
        {
            LoadControlUser();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            thereIsData = true;
            isClosed = true;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            isClosed = true;
            Close();
        }
    }
}
