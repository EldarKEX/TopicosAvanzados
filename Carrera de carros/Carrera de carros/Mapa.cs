using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
namespace Carrera_de_carros
{
    class Mapa
    {
        private Pen whitePen;
        private Graphics graphics;
        private SolidBrush brush;

        public Mapa(Graphics graphics)
        {
            whitePen = new Pen(Color.White);
            this.graphics = graphics;
            brush = new SolidBrush(Color.White);
        }

        public void CleanMap()
        {

            lock (graphics)
            {
                Thread.Sleep(300);
                graphics.Clear(Color.White);
            }           
        }

        public bool isFinished(bool one,bool two,bool three)
        {
            if(one && two && three)
            {
                return true;
            }
            return false;
        }
    }
}
