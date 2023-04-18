using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace RentaDeAutos.Class
{
    public class ClockClass
    {
        private Graphics graphics;
        private Pen penRed;
        private Pen penBlue;
        private Pen penGreen;
        private int minute;
        private int hour;

        const float DIAMETER = 100;
        const int RADIUS = 50;
        const int LINE_LENGTH_HOUR = 40;
        const int LINE_LENGTH_MINUTES = 60;
        const int ANGLE_INITIAL = 270;
  

        public ClockClass(Graphics graphics)
        {
            this.graphics = graphics;
            penRed = new Pen(Color.Red, 2);
            penBlue = new Pen(Color.Blue, 4);
            penGreen = new Pen(Color.Green, 4);
            minute = 0;
            hour = 0;
        }

        public void DrawImage()
        {
            graphics.Clear(Color.White);
        }

        public void DrawCircle()
        {
            graphics.Clear(Color.White);

            //Punto inicial
            PointF initialPoint = new PointF(0,0);

            //Tamaño del circulo
            SizeF circleSize = new SizeF(DIAMETER, DIAMETER);

            //Rectangulo del circulo
            RectangleF rectangle = new RectangleF(initialPoint, circleSize);

            //Dibujar Circulo
            graphics.DrawEllipse(penRed, rectangle);
        }
        public void DrawLine(string angle, Pen pen, int LINE_LENGHT)
        {
            //Angulo a radianes
            Double angleRAD = Double.Parse(angle);
            angleRAD = (Math.PI * (angleRAD + ANGLE_INITIAL)) / 180;

            //ejes del termino de la linea
            float endPointX = float.Parse((Math.Cos(angleRAD) * LINE_LENGHT).ToString());
            float endPointY = float.Parse((Math.Sin(angleRAD) * LINE_LENGHT).ToString());

            //Puntos de la recta
            PointF centralPoint = new PointF(RADIUS, RADIUS);
            PointF endPoint = new PointF(RADIUS + endPointX, RADIUS + endPointY);

            graphics.DrawLine(pen, centralPoint, endPoint);
        }



        public string GetCurrentHour(int hourC)
        {
            return (hourC * 30).ToString();
        }

        public string GetCurrentMinute(int minuteC)
        {
            return (minuteC * 6).ToString();
        }

        public void DrawClock()
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            hour = DateTime.Now.TimeOfDay.Hours;
            minute = DateTime.Now.TimeOfDay.Minutes;

            DrawImage();
            DrawLine(GetCurrentHour(hour),penGreen, LINE_LENGTH_HOUR);
            DrawLine(GetCurrentMinute(minute),penBlue, LINE_LENGTH_MINUTES);
        }

        public void DrawClock(int hour, int minute)
        {
            DrawImage(); 
            DrawLine(GetCurrentHour(hour), penGreen, LINE_LENGTH_HOUR);
            DrawLine(GetCurrentMinute(minute), penBlue, LINE_LENGTH_MINUTES);
        }
    }
}
