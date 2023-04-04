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
            RectangleF rectangle = new RectangleF(20, 20, 250, 250);
            graphics.DrawEllipse(penRed, rectangle);
        }
        public void DrawLineHour(string Angle)
        {

            Double angleD = Double.Parse(Angle);
            angleD = (Math.PI * (angleD + 270)) / 180;

            float posX = float.Parse((Math.Cos(angleD) * 60).ToString());
            float posY = float.Parse((Math.Sin(angleD) * 60).ToString());

            PointF pointX = new PointF(145, 145);
            PointF pointY = new PointF(145 + posX, 145 + posY);

            graphics.DrawLine(penBlue, pointX, pointY);
        }

        public void DrawLineMinute(string Angle)
        {

            Double angleD = Double.Parse(Angle);
            angleD = (Math.PI * (angleD + 270)) / 180;

            float posX = float.Parse((Math.Cos(angleD) * 100).ToString());
            float posY = float.Parse((Math.Sin(angleD) * 100).ToString());

            PointF pointX = new PointF(145, 145);
            PointF pointY = new PointF(145 + posX, 145 + posY);

            graphics.DrawLine(penGreen, pointX, pointY);
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
