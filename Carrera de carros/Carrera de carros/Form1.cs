using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Carrera_de_carros
{
    public partial class Form1 : Form
    {
        private Thread thread1;
        private Thread thread2;
        private Carro carroRojo;
        private Carro carroAzul;
        private Carro carroVerde;
        public Form1()
        {
            InitializeComponent();           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        void ClearingCar(Carro carro)
        {
            while (true)
            {
                if (carroRojo.Painted && carroAzul.Painted)
                {
                    carro.CleanCar();
                }
            }
        }

        void CorrectIteracion(Carro carro)
        {
            while (true)
            {

            }
        }
        public void DrawCarRed()
        {
            while (true)
            {
                carroRojo.Painted = false;
                carroRojo.DrawCar();
                Thread.Sleep(100);
                ClearingCar(carroRojo);
                    
                if(carroRojo.PosX >= 900)
                {
                    carroRojo.DrawCar();
                    return;
                }             
            }
            
        }

        public void DrawCarBlue()
        {          
            while (true)
            {
                carroAzul.DrawCar();
                Thread.Sleep(100);
                ClearingCar(carroAzul);
                if (carroAzul.PosX >= 900)
                {
                    carroAzul.DrawCar();
                    return;
                }
                
            }

            
        }



        private void btnInicio_Click(object sender, EventArgs e)
        {
            carroRojo = new Carro(Color.Red, 20);
            carroAzul = new Carro(Color.Blue, 20);
            carroVerde = new Carro(Color.Green, 20);

            thread1 = new Thread(DrawCarRed);
            thread2 = new Thread(DrawCarBlue);

            thread1.Start();
            thread2.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
        }

        
    }
}
