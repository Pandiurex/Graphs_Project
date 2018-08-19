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
    public partial class EliminarVuelo : Form
    {
        ListaVuelos listaVuelos;
        int indice;
        public EliminarVuelo(ref ListaVuelos listaVuelos)
        {
            InitializeComponent();
            this.listaVuelos = listaVuelos;
            eliminarVuelos.Enabled=false;
            actualizarListBox();
            
        }
        void actualizarListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < listaVuelos.Count; i++)
                listBox1.Items.Add(listaVuelos[i]);
        }

        private void eliminarVuelos_Click(object sender, EventArgs e)
        {
            

            listaVuelos.RemoveAt(listBox1.SelectedIndex);
            
            listBox1.Items.Clear();
            actualizarListBox();
            eliminarVuelos.Enabled = false;

            if (listaVuelos.Count == 0)
            {
                this.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = listBox1.SelectedIndex;
            eliminarVuelos.Enabled = true;
        }

        private void EliminarVuelo_Load(object sender, EventArgs e)
        {

        }
    }
}
