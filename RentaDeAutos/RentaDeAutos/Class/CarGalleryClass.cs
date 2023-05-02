using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Text;
using System.Data;
using System.Windows.Forms;
using RentaDeAutos.Class;
using RentaDeAutos.UserControls;
using System.Threading.Tasks;

namespace RentaDeAutos.Class
{
    public class CarGalleryClass
    {
        private DataTable table;
        private List<CarDataClass> carList;
        private CarContainer carContainer;
       
        public CarGalleryClass(DataTable table) { 
            this.table = table;
            carList = new List<CarDataClass>();
            carContainer = null; 
            LoadInfoDatabase();
        }

        public List<CarDataClass> CarList { get => carList; set => carList = value; }
        public CarContainer CarContainer { get => carContainer; set => carContainer = value; }
        public DataTable Table { get => table; set => table = value; }

        public Image Source(byte[] photoByte)
        {
            MemoryStream ms = new MemoryStream(photoByte);
            Image s = Image.FromStream(ms);
            return s;
        }

        public void LoadInfoDatabase()
        {
            foreach (DataRow carRow in table.Rows)
            {
                int id = (int)carRow[0];
                byte[] ImageData = (byte[])carRow[4];
                string Model = (string)carRow[5];
                string Brand = (string)carRow[1];
                string Color = (string)carRow[2];
                string Cost = carRow[3].ToString();


                CarDataClass car = new CarDataClass(id, Source(ImageData), Model, Brand, Color, Cost);
                carList.Add(car);
            }
        }

    }
}
