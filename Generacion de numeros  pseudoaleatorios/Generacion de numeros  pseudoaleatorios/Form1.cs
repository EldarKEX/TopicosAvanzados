using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generacion_de_numeros__pseudoaleatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Rows.Clear();
                GeneracionDeNumeros generacionDeNumeros = new GeneracionDeNumeros();
                Dictionary<string, string> alreadyIs = new Dictionary<string, string>();

                string semilla = tbSemilla.Text;
                string eVal = tbE.Text;
                alreadyIs.Add(semilla, "0");

                if (!generacionDeNumeros.ValidarSemilla(semilla))
                {
                    MessageBox.Show("La semilla debe ser de 4 digitos numericos :(");
                    return;
                }
                if (!generacionDeNumeros.ValidarE(eVal))
                {
                    MessageBox.Show("La ´´e´´ debe ser un numero par y mayor a 8");
                    return;
                }
                if(tbIteracion.Text == "")
                {
                    MessageBox.Show("La iteracion debe contener un numero entero");
                    return;
                }


                int iteracion = int.Parse(tbIteracion.Text);
                int i = 1;

                while (iteracion >= i)
                {
                    string numero = generacionDeNumeros.CalcularCuadrado(semilla, eVal);
                    string nuevaSemilla = generacionDeNumeros.CalcularNuevaSemilla(numero, eVal);
                    string ri = generacionDeNumeros.CalcularRi(nuevaSemilla);

                    dataGridView.Rows.Add(i, numero, nuevaSemilla, ri);

                    if (alreadyIs.ContainsKey(nuevaSemilla))
                    {
                        MessageBox.Show(alreadyIs[nuevaSemilla]);
                        return;
                    }

                    alreadyIs.Add(nuevaSemilla, i.ToString());
                    semilla = nuevaSemilla;
                    i++;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
    }
}
