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
    public partial class FormularioForn : Form
    {
        ListaVuelos listaVuelos;
        int ind;
        bool datos=true;
        string[] arreglo = new string[3];
        public FormularioForn(ref ListaVuelos listaVuelos, bool datos, int ind, ref string[] arreglo)
        {
            this.listaVuelos = listaVuelos;
            this.arreglo = arreglo;
            this.datos = datos;
            this.ind = ind;
            InitializeComponent();
            label1.Text = listaVuelos[ind].getRuta();
            Registrar.Enabled = false;
        }

        private void Asiento_Click(object sender, EventArgs e)
        {
            arreglo[0] = nombreBox.Text;
            arreglo[1] = apellidoBox.Text;
            arreglo[2] = edadBox.Text;
            Asiento ventanaAsiento = new Asiento(ref listaVuelos, ind);
            ventanaAsiento.ShowDialog();
            asientoBox.Text = ventanaAsiento.getAsiento();
            Registrar.Enabled = true;
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            listaVuelos[ind].asientos[Int32.Parse(asientoBox.Text) - 1] = false;
            listaVuelos[ind].asientosDisponibles--;
            Pasajero p = new Pasajero(nombreBox.Text, apellidoBox.Text,edadBox.Text, asientoBox.Text,label1.Text);
            this.listaVuelos[ind].setPasajero(p);
            Salida ventanaAsiento = new Salida();
            ventanaAsiento.ShowDialog();
            this.Close();
        }

        private void nombreBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void apellidoBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void edadBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)
                || Char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void FormularioForn_Load(object sender, EventArgs e)
        {
            if (datos == false)
            {
                nombreBox.Enabled = false;
                apellidoBox.Enabled = false;
                edadBox.Enabled = false;

                nombreBox.Text = arreglo[0];
                apellidoBox.Text = arreglo[1];
                edadBox.Text = arreglo[2];
            }
            else {

                nombreBox.Enabled = true;
                apellidoBox.Enabled = true;
                edadBox.Enabled = true;
            }
        }
        }
    }
