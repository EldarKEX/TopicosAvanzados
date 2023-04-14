using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace RentaDeAutos.Class
{
    public class CarDataClass
    {
        private int id;
        private Image pictureCar;
        private string model;
        private string brand;
        private string color;
        private string cost;

        public CarDataClass()
        {
            id = -1;
            model = "";
            brand = "";
            color = "";
            cost = "";
        }
        public CarDataClass(int id, Image pictureCar, string model, string brand, string color, string cost)
        {
            this.id = id;
            this.pictureCar = pictureCar;
            this.model = model;
            this.brand = brand;
            this.color = color;
            this.cost = cost;
        }

        public int Id { get => id; set => id = value; }
        public Image PictureCar { get => pictureCar; set => pictureCar = value; }
        public string Model { get => model; set => model = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Color { get => color; set => color = value; }
        public string Cost { get => cost; set => cost = value; }
    }
}
