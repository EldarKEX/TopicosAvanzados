using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace RentaDeAutos.SubForms
{
    public partial class CarGallery : Form
    {
        public CarGallery()
        {
            InitializeComponent();
            
        }

        //int i = 0;
        //public List<Panel> panelList = new List<Panel>();
        public Image source(byte[] photoByte)
        {
            MemoryStream ms = new MemoryStream(photoByte);
            Image s = Image.FromStream(ms);
            return s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Panel panel = new Panel();
            //panel.Width = 213;
            //panel.Height = 85;
            //panel.BackColor = Color.Red;

            //Label label = new Label();
            //label.Text = i.ToString();
            //i++;

            //panel.Controls.Add(label);

            //panelList.Add(panel);
            //flowLayoutPanel1.Controls.Add(panel);

            RENTCARDataSet.CarDataTable table = carTableAdapter.GetData();
            pictureBox1.Image = source(table.Rows[0].Field<byte[]>("ImageData"));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Remove(panelList.Last());
            //panelList.Remove(panelList.Last());
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void carBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void CarGallery_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rENTCARDataSet.Car' Puede moverla o quitarla según sea necesario.
            this.carTableAdapter.Fill(this.rENTCARDataSet.Car);

        }
    }
}
