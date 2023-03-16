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
        private Random random;
        private Graphics graphics;
        private int iteracion;
        Pen carPen;
        public Carro(Color color,int posY)
        {
            carPen = new Pen(color);
            textColor = color.ToString();
            posX = 10;
            this.posY = posY;
            this.iteracion = 0;
            random = new Random();
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

        public void DrawCar()
        {
            posX += random.Next(30, 40);
            Rectangle rect = new Rectangle(posX, posY, 80, 40);            
            graphics.DrawRectangle(carPen, rect);
            iteracion++;
            painted = true;
        }

        public void CleanCar()
        {
            graphics.Clear(Color.White);
        }
    }
}
