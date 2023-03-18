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
        private Thread thread3;
        private int i = 3;
        private Carro carroRojo;
        private Carro carroAzul;
        private Carro carroVerde;
        private List<Carro> listCar;
        private Mapa mapa;
        private Graphics graphics;
        private bool status;
        public Form1()
        {
            InitializeComponent();
            status = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void DrawCarRed()
        {           
            while (true)
            {
                carroRojo.Painted = false;
                carroRojo.DrawCar();
                Thread.Sleep(150);
                carroRojo.CleanCar();
                    
                if(carroRojo.PosX >= 800)
                {
                    carroRojo.DrawCar();
                    carroRojo.Rank *= i;
                    carroRojo.Finished = true;
                    i--;
                    return;
                }             
            }
            
        }

        public void DrawCarBlue()
        {          
            while (true)
            {
                carroAzul.DrawCar();
                Thread.Sleep(150);
                carroAzul.CleanCar();
                if (carroAzul.PosX >= 800)
                {
                    carroAzul.DrawCar();
                    carroAzul.Rank *= i;
                    carroAzul.Finished = true;
                    i--;
                    return;
                }
                
            }        
        }

        public void DrawCarGreen()
        {
            while (true)
            {
                carroVerde.DrawCar();
                Thread.Sleep(150);
                carroVerde.CleanCar();
                if (carroVerde.PosX >= 800)
                {
                    carroVerde.DrawCar();
                    carroVerde.Rank *= i;
                    carroVerde.Finished = true;
                    i--;
                    return;
                }

            }
        }



        void InitializeClasses()
        {         
            graphics = this.CreateGraphics();
            carroRojo = new Carro(Color.Red, 70, 123, graphics,"Rojo");
            carroAzul = new Carro(Color.Blue, 170, 345, graphics,"Azul");
            carroVerde = new Carro(Color.Green, 270, 654, graphics,"Verde");
            listCar = new List<Carro>();
            listCar.Add(carroRojo);
            listCar.Add(carroAzul);
            listCar.Add(carroVerde);
            mapa = new Mapa(graphics);
            thread1 = new Thread(DrawCarRed);
            thread2 = new Thread(DrawCarBlue);
            thread3 = new Thread(DrawCarGreen);
            
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            try
            {
                i = 3;
                btnInicio.Enabled = false;
                InitializeClasses();
                timer1.Start();
                mapa.CleanMap();
                thread1.Start();
                thread2.Start();
                thread3.Start();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                thread1.Abort();
                thread2.Abort();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mapa.isFinished(carroRojo.Finished,carroAzul.Finished,carroVerde.Finished))
            {
                btnInicio.Enabled = true;
            }

            listCar.Sort(delegate (Carro carro1,Carro carro2)
            {
                return carro1.Rank.CompareTo(carro2.Rank);
            });


            label1.Text = "1.-" + listCar[2].Nombre ;
            label2.Text = "2.-" + listCar[1].Nombre ;
            label3.Text = "3.-" + listCar[0].Nombre ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
