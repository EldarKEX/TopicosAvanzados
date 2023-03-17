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
                Thread.Sleep(1000);
                carroRojo.CleanCar();
                    
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
                Thread.Sleep(1000);
                carroAzul.CleanCar();
                if (carroAzul.PosX >= 800)
                {
                    carroAzul.DrawCar();
                    return;
                }
                
            }

            
        }



        private void btnInicio_Click(object sender, EventArgs e)
        {
            try
            {
                carroRojo = new Carro(Color.Red, 50, 123);
                carroAzul = new Carro(Color.Blue, 150, 345);
                carroVerde = new Carro(Color.Green, 20, 654);

                thread1 = new Thread(DrawCarRed);
                thread2 = new Thread(DrawCarBlue);

                thread1.Start();
                thread2.Start();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
        }

        
    }
}
