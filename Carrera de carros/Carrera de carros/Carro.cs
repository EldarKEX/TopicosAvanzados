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
        private bool painted;
        private bool finished;
        private string textColor;
        private int posX;
        private int posY;
        private Color colorCar;
        private Random random;
        private Graphics graphics;
        private int iteracion;
        Pen carPen;
        Pen whitePen;
        public Carro(Color color,int posY,int seed)
        {
            colorCar = color;
            carPen = new Pen(color);
            whitePen = new Pen(Color.White);
            textColor = color.ToString();
            posX = 10;
            this.posY = posY;
            this.iteracion = 0;
            random = new Random(seed);
            graphics = Form1.ActiveForm.CreateGraphics();
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
            posX += random.Next(30);
            Rectangle rect = new Rectangle(posX, posY, 90, 40);
            graphics.DrawRectangle(carPen, rect);
            SolidBrush brush = new SolidBrush(colorCar);
            graphics.FillRectangle(brush, rect);
        }

        void DrawWheels(int wheel)
        {
            Rectangle rect = new Rectangle(posX+wheel, posY + 30, 20, 20);
            graphics.DrawEllipse(carPen, rect);
            SolidBrush brush = new SolidBrush(colorCar);
            graphics.FillEllipse(brush, rect);
        }
        public void DrawCar()
        {
            DrawBody();
            DrawWheels(8);
            DrawWheels(60);
            painted = true;
        }

        public void CleanWheels()
        {
            Rectangle rect = new Rectangle(posX, posY+41, 40, 20);
            Pen blackPen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.White);
            graphics.DrawRectangle(blackPen,rect);
           // graphics.FillRectangle(brush, rect);
        }

        public void CleanBody()
        {
            Rectangle rect = new Rectangle(posX - 40, posY, 60, 80);
            SolidBrush brush = new SolidBrush(Color.White);
            graphics.DrawRectangle(whitePen, rect);
            graphics.FillRectangle(brush, rect);
        }
        public void CleanCar()
        {
            CleanBody();
            CleanWheels();
        }
    }
}
