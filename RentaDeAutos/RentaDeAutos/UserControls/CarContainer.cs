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

namespace RentaDeAutos.UserControls
{
    public partial class CarContainer : UserControl
    {
        private CarDataClass carData;
        private bool SelectedBool;
        private CarGalleryClass carGallery;
        public CarContainer()
        {
            InitializeComponent();
            SelectedBool = false;
        }

        public CarContainer(CarDataClass carData, CarGalleryClass carGallery)
        {
            InitializeComponent();          
            this.carData = carData;
            this.carGallery = carGallery;
            SelectedBool = false;
            LoadData();
        }

        public void ReferenceContainer(ref CarContainer Selected)
        {
            
        }
        public void LoadData()
        {
            pbCar.Image =  carData.PictureCar;
            lModel.Text = "Modelo: " + carData.Model;
            lBrand.Text = "Marca: " + carData.Brand;
            lCost.Text = "Costo: " + carData.Cost;
            lColor.Text = "Color: " + carData.Color;
        }
        public CarDataClass CarData { get => carData; set => carData = value; }
        
        public void MouseEnterBack()
        {
            this.BackColor = Color.LightBlue;
        }

        public void MouseLeaveBack()
        {
            if (SelectedBool)
            {
                this.BackColor = Color.DeepSkyBlue;
                return;
            }
            this.BackColor = Color.AliceBlue;
        }

        public void ClickBack()
        {
            this.BackColor = Color.DeepSkyBlue;

            if (carGallery.CarContainer != null) {
                carGallery.CarContainer.SelectedBool = false;
                carGallery.CarContainer.MouseLeaveBack();
            }
            carGallery.CarContainer = this;
            SelectedBool = true;
        }

        private void lColor_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterBack();
        }

        private void lColor_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveBack();
        }    

        private void CarContainer_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterBack();
        }

        private void CarContainer_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveBack();
        }

        private void lColor_Click(object sender, EventArgs e)
        {
            ClickBack(); 
        }

        private void CarContainer_Click(object sender, EventArgs e)
        {
            ClickBack();
        }

    }
}
