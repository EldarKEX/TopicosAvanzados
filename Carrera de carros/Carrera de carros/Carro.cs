using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading;

namespace Carrera_de_carros
{
    class Carro
    {
        private string nombre;
        private bool painted;
        private bool finished;
        private int posX;
        private int posY;
        private int rank;
        private Color colorCar;
        private Random random;
        private Graphics graphics;
        private int iteracion;
        Pen carPen;
        Pen whitePen;
        Pen blackPen = new Pen(Color.Black);
        public Carro(Color color,int posY,int seed,Graphics graphics,string nombre)
        {
            colorCar = color;
            this.nombre = nombre;
            carPen = new Pen(color);
            whitePen = new Pen(Color.White);
            rank = 1;
            posX = 10;
            this.posY = posY;
            this.iteracion = 0;
            random = new Random(Guid.NewGuid().GetHashCode() + seed);
            this.graphics = graphics;
        }

        public Color ColorCar
        {
            get
            {
                return colorCar;
            }
        }

        public int Rank
        {
            set
            {
                rank = value;
            }
            get
            {
                return rank;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public int PosX
        {
            get
            {
                return posX;
            }
        }

        public bool Finished
        {
            get
            {
                return finished;
            }
            set
            {
                finished = value;
            }
        }
        public bool Painted
        {
            get
            {
                return painted;
            }
            set
            {
                painted = value;
            }
        }

        public int Iteracion
        {
            get
            {
                return iteracion;
            }
        }

        void DrawBody()
        {
             posX += random.Next(15);
             rank = posX;
             Rectangle rect = new Rectangle(posX, posY, 90, 40);
             graphics.DrawRectangle(carPen, rect);
             SolidBrush brush = new SolidBrush(colorCar);
             graphics.FillRectangle(brush, rect);      
        }

        void DrawWheels(int wheel)
        {       
             Rectangle rect = new Rectangle(posX + wheel, posY + 30, 20, 20);
             graphics.DrawEllipse(carPen, rect);
             SolidBrush brush = new SolidBrush(colorCar);
             graphics.FillEllipse(brush, rect);                          
        }
        public void DrawCar()
        {
            lock (graphics)
            {
                DrawBody();
                DrawWheels(8);
                DrawWheels(60);
                painted = true;
            }         
        }

        public void CleanWheels(int posSquare,int width,bool visible)
        {
            Rectangle rect = new Rectangle(posX+ posSquare, posY+41, width, 20);
            
            SolidBrush brush = new SolidBrush(Color.White);
            if (visible)
            {
                graphics.DrawRectangle(blackPen, rect);
            }
            else
            {
                graphics.DrawRectangle(whitePen, rect);
            }
                

            graphics.FillRectangle(brush, rect);
        }

      
        public void CleanBody()
        {
            Rectangle rect = new Rectangle(posX - 40, posY, 50, 80);
            SolidBrush brush = new SolidBrush(Color.White);
            graphics.DrawRectangle(whitePen, rect);
            graphics.FillRectangle(brush, rect);
        }
        public void CleanCar()
        {
            lock (graphics)
            {
                CleanBody();
                CleanWheels(0, 90, false);
            }               
        }
    }
}
