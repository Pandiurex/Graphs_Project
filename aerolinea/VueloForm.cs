using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aerolinea
{
    public partial class VueloForm : Form
    {

        ListaVuelos listaVuelos;
        string[] arreglo = new string[3];
        public VueloForm(ref ListaVuelos listavuelos, ref string [] arreglo)
        {

            this.listaVuelos = listavuelos;
            this.arreglo = arreglo;
            InitializeComponent();
            ventas.Enabled = false;
            vueloTextBox.Text = "SK1";
            actualizarListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ventas.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = listBox1.SelectedIndex;
            string cad = listBox1.SelectedItem.ToString();
            FormularioForn ventanaFormulario = new FormularioForn(ref listaVuelos,true, ind, ref arreglo);
            ventanaFormulario.ShowDialog();
            this.Close();
        }

        void actualizarListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < listaVuelos.Count; i++)
                listBox1.Items.Add(listaVuelos[i]);
        }

        private void ordenarAsiento_Click(object sender, EventArgs e)
        {
            listaVuelos.QuickSortAsientos(ref listaVuelos, 0, listaVuelos.Count - 1);
            listBox1.Items.Clear();
            actualizarListBox();
        }
        

        private void ordenarFecha_Click(object sender, EventArgs e) 
        {
            listaVuelos.QuickSortFecha(ref listaVuelos, 0, listaVuelos.Count - 1);
            listBox1.Items.Clear();
            actualizarListBox();
        }


        private void registroVuelo_Click(object sender, EventArgs e)
        {
            VueloRegistro vueloRegistro = new VueloRegistro(ref listaVuelos);
            vueloRegistro.ShowDialog();
            this.Close();
        }

        private void busquedaVuelo_TextChanged_1(object sender, EventArgs e)
        {
            string cadena = busquedaVuelo.Text;
            for (int i = 0; i < listaVuelos.Count; i++) {
                if (listaVuelos[i].ruta.Contains(cadena)) {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(listaVuelos[i]);
                }
            }
            if (busquedaVuelo.Text == "") {
                actualizarListBox();
                ventas.Enabled = false;
            }
        }

        private void actualizarFecha_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaVuelos.Count; i++) {
                if (listaVuelos[i].fecha < DateTime.Now) {
                    listaVuelos.RemoveAt(i);
                    i = -1;
                }
                    listBox1.Items.Clear();
                    actualizarListBox();
                }
            }

        private void busquedaVuelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)
                || Char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        }        
        
    }

