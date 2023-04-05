using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace RentaDeAutos.Class
{
    class ClockClass
    {
        private Graphics graphics;
        private Pen penRed;
        private Pen penBlue;
        private Pen penGreen;
        private int minute;
        private int hour;

        const float DIAMETER = 200;
        const int RADIUS = 100;
        const int LINE_LENGTH_HOUR = 40;
        const int LINE_LENGTH_MINUTES = 80;
        const int ANGLE_INITIAL = 270;
        const float AXIS_X_CENTRAL = 0;
        const float AXIS_Y_CENTRAL = 0;

        public ClockClass(Graphics graphics)
        {
            this.graphics = graphics;
            penRed = new Pen(Color.Red, 2);
            penBlue = new Pen(Color.Blue, 4);
            penGreen = new Pen(Color.Green, 4);
            minute = 0;
            hour = 0;
    }
        public void DrawCircle()
        {
            graphics.Clear(Color.White);

            //Punto inicial
            PointF pointF = new PointF(0,0);

            //Tamaño del circulo
            SizeF sizeF = new SizeF(DIAMETER, DIAMETER);

            //Rectangulo del circulo
            RectangleF rectangle = new RectangleF(pointF, sizeF);

            //Dibujar Circulo
            graphics.DrawEllipse(penRed, rectangle);
        }
        public void DrawLineHour(string angle)
        {
            //Angulo a radianes
            Double angleRAD = Double.Parse(angle);
            angleRAD = (Math.PI * (angleRAD + ANGLE_INITIAL)) / 180;

            //ejes del termino de la linea
            float posX = float.Parse((Math.Cos(angleRAD) * LINE_LENGTH_HOUR).ToString());
            float posY = float.Parse((Math.Sin(angleRAD) * LINE_LENGTH_HOUR).ToString());

            //Puntos de la recta
            PointF middlePoint = new PointF(RADIUS, RADIUS);
            PointF endPoint = new PointF(RADIUS + posX, RADIUS + posY);

            graphics.DrawLine(penBlue, middlePoint, endPoint);
        }

        public void DrawLineMinute(string angle)
        {
            //Angulo a radianes
            Double angleRAD = Double.Parse(angle);
            angleRAD = (Math.PI * (angleRAD + ANGLE_INITIAL)) / 180;


            float posX = float.Parse((Math.Cos(angleRAD) * LINE_LENGTH_MINUTES).ToString());
            float posY = float.Parse((Math.Sin(angleRAD) * LINE_LENGTH_MINUTES).ToString());

            PointF middlePoint = new PointF(RADIUS, RADIUS);
            PointF endPoint = new PointF(RADIUS + posX, RADIUS + posY);

            graphics.DrawLine(penGreen, middlePoint, endPoint);
        }

        public string GetCurrentHour()
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            hour = currentTime.Hours;
            return (hour * 30).ToString();
        }

        public string GetCurrentMinute()
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            minute = currentTime.Minutes;
            return (minute * 6).ToString();
        }

        public void DrawClock()
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            if (currentTime.Hours == hour && currentTime.Minutes == minute)
            {
                return;
            }

            DrawCircle();
            DrawLineHour(GetCurrentHour());
            DrawLineMinute(GetCurrentMinute());

        }
    }
}
