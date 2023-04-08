using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaDeAutos.SubForms
{
    public partial class CarGallery : Form
    {
        public CarGallery()
        {
            InitializeComponent();
        }

        int i = 0;
        public List<Panel> panelList = new List<Panel>();
        private void button3_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Width = 213;
            panel.Height = 85;
            panel.BackColor = Color.Red;

            Label label = new Label();
            label.Text = i.ToString();
            i++;

            panel.Controls.Add(label);

            panelList.Add(panel);
            flowLayoutPanel1.Controls.Add(panel);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Remove(panelList.Last());
            panelList.Remove(panelList.Last());
        }
    }
}
