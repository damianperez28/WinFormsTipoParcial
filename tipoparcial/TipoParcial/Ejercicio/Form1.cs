using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnProm.Enabled = false;
            btnBuscar.Enabled = false;
        }
        #region Variables de instancia
        int[] dni = new int[30];
        string[] nombres = new string[30];
        int[] edades = new int[30];
        int cantidad = 0;
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 modalAgregar = new Form2();
            modalAgregar.ShowDialog();

            if (modalAgregar.DialogResult == DialogResult.OK && cantidad < 30)
            {
                dni[cantidad] = Convert.ToInt32(modalAgregar.tbDNI.Text);
                edades[cantidad] = Convert.ToInt32(modalAgregar.tbEdad.Text);
                nombres[cantidad] = modalAgregar.tbNombre.Text;
                cantidad++;
            }
            if(cantidad > 0)
            {
                btnProm.Enabled = true;
                btnBuscar.Enabled = true;
            }
                


        }

        private void btnVerListar_Click(object sender, EventArgs e)
        {
            Ordenar();
            lbListaSocios.Items.Clear();
            MostrarSocios();
        } 
        public void Ordenar()
        {
            int aux1, aux2;
            string aux3;
            for(int i = 0; i < cantidad - 1; i++)
            {
                for(int j = i+1; j < cantidad; j++)
                {
                    if (dni[i] > dni[j])
                    {
                        aux1 = dni[i];
                        dni[i] = dni[j];
                        dni[j] = aux1;

                        aux2 = edades[i];
                        edades[i] = edades[j];
                        edades[j] = aux2;

                        aux3 = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = aux3;


                    }
                }
            }

        }
        public int Buscar(int buscado)
        {
            int pos = -1, i=0;
            while (pos == -1 && i < cantidad)
            {
                if( buscado == dni[i])
                {
                    pos = i;
                }
                i++;

            }
            return pos;
        }
        public void MostrarSocios()
        {
            for (int i = 0; i < cantidad; i++)
            {
                lbListaSocios.Items.Add("DNI: " + dni[i] + " Nombre: " + nombres[i] + " Edad: " + edades[i]);
            }
        }
        public double CalcularPromedio()
        {
            int acum = 0;
            double promedio = 0;

            for (int i = 0; i < cantidad; i++)
            {
                acum = acum + edades[i];
            }

            promedio = acum / cantidad;
            return promedio;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int buscado = Convert.ToInt32(textBox1.Text);
            if(Buscar(buscado) != -1)
            {
                MessageBox.Show("Tu DNI esta en la posicion : " + Buscar(buscado));
            }
            else MessageBox.Show("DNI inexistente ");
            
        }
        private void btnProm_Click(object sender, EventArgs e)
        {
            lbResumen.Items.Add("Promedio: " + CalcularPromedio());
            lbResumen.Items.Add("Edades superiores al promedio: ");
            for (int i = 0; i < cantidad; i++)
            {
                if (edades[i] > CalcularPromedio())
                {
                    lbResumen.Items.Add("DNI: " + dni[i] + " Nombre: " + nombres[i] + " Edad: " + edades[i]);
                }
            }
        }
    }
}
