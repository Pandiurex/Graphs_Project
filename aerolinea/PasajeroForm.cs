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
    public partial class PasajeroForm : Form
    {
        ListaVuelos listavuelo;
        public PasajeroForm(ref ListaVuelos listaVuelo)
        {

            this.listavuelo = listaVuelo;
            InitializeComponent();
            actualizaDGVpasajeros();
            eliminarButton.Enabled = false;
        }

        private void actualizaDGVpasajeros()
        {
            for (int i = 0; i < listavuelo.Count; i++)
            {
                for (int j = 0; j < listavuelo[i].getOcupados(); j++)
                {
                    string[] s = new string[6];
                    s[0] = i.ToString();
                    s[1] = j.ToString();
                    s[2] = listavuelo[i].getPasajero(j).getVuelo();
                    s[3] = listavuelo[i].getPasajero(j).getNombre();
                    s[4] = listavuelo[i].getPasajero(j).getEdad();
                    s[5] = listavuelo[i].getPasajero(j).getAsiento();
                    ListViewItem itm = new ListViewItem(s);
                    listViewPasajero.Items.Add(itm);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(listViewPasajero.FocusedItem.Text);
            Console.WriteLine(listViewPasajero.FocusedItem.SubItems[1].Text);


            int indiceVuelo = Int32.Parse(listViewPasajero.FocusedItem.Text);
            int indicePasajero = Int32.Parse(listViewPasajero.FocusedItem.SubItems[1].Text);


            listavuelo[indiceVuelo].asientos[Int32.Parse(listavuelo[indiceVuelo].getPasajero(indicePasajero).getAsiento()) - 1] = true;
            listavuelo[indiceVuelo].asientosDisponibles++;

            listavuelo[indiceVuelo].listaP.Remove(listavuelo[indiceVuelo].listaP[indicePasajero]);
            listViewPasajero.Items.Clear();
            actualizaDGVpasajeros();

            this.Close();

        }

        private void listViewPasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            eliminarButton.Enabled = true;

        }

        private void busquedaBox_TextChanged(object sender, EventArgs e)
        {
            string cadena = busquedaBox.Text;
            listViewPasajero.Items.Clear();
            for (int i = 0; i < listavuelo.Count; i++)
            {
                for (int j = 0; j < listavuelo[i].getOcupados(); j++)
                {
                    if (listavuelo[i].getPasajero(j).nombre.Contains(cadena))
                    {

                        string[] s = new string[6];
                        s[0] = i.ToString();
                        s[1] = j.ToString();
                        s[2] = listavuelo[i].getPasajero(j).getVuelo();
                        s[3] = listavuelo[i].getPasajero(j).getNombre();
                        s[4] = listavuelo[i].getPasajero(j).getEdad();
                        s[5] = listavuelo[i].getPasajero(j).getAsiento();
                        ListViewItem itm = new ListViewItem(s);
                        listViewPasajero.Items.Add(itm);
                    }
                }
                if (busquedaBox.Text == "")
                {
                    eliminarButton.Enabled = false;
                }
            }
        }
    }
}