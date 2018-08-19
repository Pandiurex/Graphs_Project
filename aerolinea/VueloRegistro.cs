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
    public partial class VueloRegistro : Form
    {
        ListaVuelos listaVuelos;
        public VueloRegistro(ref ListaVuelos listaVuelos)
        {
            this.listaVuelos = listaVuelos;
            InitializeComponent();
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||  textBox5.Text == "")
            {
                button1.Enabled = false;

            }
            else
            {

                button1.Enabled = true;
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "")
            {
                button1.Enabled = false;

            }
            else
            {
                button1.Enabled = true;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "")
            {
                button1.Enabled = false;

            }
            else
            {
                button1.Enabled = true;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||  textBox5.Text == "")
            {
                button1.Enabled = false;

            }
            else
            {
                button1.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string origen = textBox1.Text;
            string destino=textBox2.Text;
            string rute = "SK1" + textBox1.Text + textBox2.Text;
            int costo = Int32.Parse(textBox3.Text);
            int tiempo =Int32.Parse(textBox5.Text);
            int asientos = 18;
            bool[] numAsientos = new bool[18];
            bool rutaValida = true;
            for (int i = 0; i < listaVuelos.Count; i++)
            {
                if (textBox1.Text == textBox2.Text)
                {
                    MessageBox.Show("El origen y el destino son iguales", "vuelo no valido", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    rutaValida = false;
                    break;

                }
                
                if (rute == listaVuelos[i].getRuta())
                {

                    MessageBox.Show("La ruta seleccionada ya existe", " Elige una ruta nueva", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    rutaValida = false;
                    break;
                }
                else
                {
                    rutaValida = true;
                }
            }

            if (rutaValida == true)
            {
                for (int k = 0; k < 18; k++)
                    numAsientos[k] = true;
                DateTime fecha = Convert.ToDateTime(dateTimePicker1.Text + " " + dateTimePicker2.Text);
                Vuelocs vuelo = new Vuelocs(rute,origen, destino, asientos, costo, tiempo, fecha, numAsientos);
                listaVuelos.Add(vuelo);
                this.Close();
            }



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
