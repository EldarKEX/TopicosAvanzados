﻿using System;
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
                CarDataClass car = new CarDataClass(carRow.CarID, Source(carRow.ImageData), carRow.Model, carRow.Brand, carRow.Color, carRow.Cost.ToString());
                carList.Add(car);
            }
        }

    }
}
