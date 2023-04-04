using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentaDeAutos.Class;

namespace RentaDeAutos.SubForms
{
    public partial class Clock : Form
    {
        private ClockClass clockClass;
        public Clock()
        {
            InitializeComponent();
            timer1.Enabled = true;
            clockClass = new ClockClass(CreateGraphics());
            
        }
 
        private void timer1_Tick(object sender, EventArgs e)
        {
            clockClass.DrawClock();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
 
        }
    }
}
