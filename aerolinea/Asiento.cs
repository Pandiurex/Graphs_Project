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
    public partial class Asiento : Form
    {
        List<Vuelocs> listaVuelos;
        string asientoSeleccionado;
        int ind;

        public Asiento(ref ListaVuelos listaVuelo, int ind)
        {
            asientoSeleccionado = "-1";
            InitializeComponent();
            this.listaVuelos = listaVuelo;
            this.ind = ind;

            inicializarBotones();
        }
   
        public string getAsiento()
        {
            return asientoSeleccionado;
        }

        private void inicializarBotones()
        {
            if (listaVuelos[ind].asientos[0] == false)
            {
                Asiento1.BackColor = Color.Red;
                Asiento1.Enabled = false;
            }
            else
            {
                Asiento1.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[1] == false)
            {
                Asiento2.BackColor = Color.Red;
                Asiento2.Enabled = false;
            }
            else
            {
                Asiento2.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[2] == false)
            {
                Asiento3.BackColor = Color.Red;
                Asiento3.Enabled = false;
            }
            else
            {
                Asiento3.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[3] == false)
            {
                Asiento4.BackColor = Color.Red;
                Asiento4.Enabled = false;
            }
            else
            {
                Asiento4.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[4] == false)
            {
                Asiento5.BackColor = Color.Red;
                Asiento5.Enabled = false;
            }
            else
            {
                Asiento5.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[5] == false)
            {
                Asiento6.BackColor = Color.Red;
                Asiento6.Enabled = false;
            }
            else
            {
                Asiento6.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[6] == false)
            {
                Asiento7.BackColor = Color.Red;
                Asiento7.Enabled = false;
            }
            else
            {
                Asiento7.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[7] == false)
            {
                Asiento8.BackColor = Color.Red;
                Asiento8.Enabled = false;
            }
            else
            {
                Asiento8.BackColor = Color.Green;
            }

            if (listaVuelos[ind].asientos[8] == false)
            {
                Asiento9.BackColor = Color.Red;
                Asiento9.Enabled = false;
            }
            else
            {
                Asiento9.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[9] == false)
            {
                Asiento10.BackColor = Color.Red;
                Asiento10.Enabled = false;
            }
            else
            {
                Asiento10.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[10] == false)
            {
                Asiento11.BackColor = Color.Red;
                Asiento11.Enabled = false;
            }
            else
            {
                Asiento11.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[11] == false)
            {
                Asiento12.BackColor = Color.Red;
                Asiento12.Enabled = false;
            }
            else
            {
                Asiento12.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[12] == false)
            {
                Asiento13.BackColor = Color.Red;
                Asiento13.Enabled = false;
            }
            else
            {
                Asiento13.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[13] == false)
            {
                Asiento14.BackColor = Color.Red;
                Asiento14.Enabled = false;
            }
            else
            {
                Asiento14.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[14] == false)
            {
                Asiento15.BackColor = Color.Red;
                Asiento15.Enabled = false;
            }
            else
            {
                Asiento15.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[15] == false)
            {
                Asiento16.BackColor = Color.Red;
                Asiento16.Enabled = false;
            }
            else
            {
                Asiento16.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[16] == false)
            {
                Asiento17.BackColor = Color.Red;
                Asiento17.Enabled = false;
            }
            else
            {
                Asiento17.BackColor = Color.Green;
            }
            if (listaVuelos[ind].asientos[17] == false)
            {
                Asiento18.BackColor = Color.Red;
                Asiento18.Enabled = false;
            }
            else
            {
                Asiento18.BackColor = Color.Green;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = "1";
            getAsiento();
            this.Close();
        }

        private void Asiento2_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "2";
            getAsiento();
            this.Close();
        }

        private void Asiento3_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "3";
            getAsiento();
            this.Close();
        }

        private void Asiento4_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "4";
            getAsiento();
            this.Close();
        }

        private void Asiento5_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "5";
            getAsiento();
            this.Close();
        }

        private void Asiento6_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "6";
            getAsiento();
            this.Close();
        }

        private void Asiento7_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "7";
            getAsiento();
            this.Close();
        }

        private void Asiento8_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "8";
            getAsiento();
            this.Close();
        }

        private void Asiento9_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "9";
            getAsiento();
            this.Close();
        }

        private void Asiento10_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "10";
            getAsiento();
            this.Close();
        }

        private void Asiento11_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "11";
            getAsiento();
            this.Close();
        }

        private void Asiento12_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "12";
            getAsiento();
            this.Close();
        }

        private void Asiento13_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "13";
            getAsiento();
            this.Close();
        }

        private void Asiento14_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "14";
            getAsiento();
            this.Close();
        }

        private void Asiento15_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "15";
            getAsiento();
            this.Close();
        }

        private void Asiento16_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "16";
            getAsiento();
            this.Close();
        }

        private void Asiento17_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "17";
            getAsiento();
            this.Close();
        }

        private void Asiento18_Click_1(object sender, EventArgs e)
        {
            asientoSeleccionado = "18";
            getAsiento();
            this.Close();
        }
    }
}
