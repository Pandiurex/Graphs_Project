using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace aerolinea
{
    public partial class VentanaPrincipal : Form
    {
        ListaVuelos listaVuelos;
        ListaCiudades listCity;
        string[] arreglo = new string[3];
        public VentanaPrincipal(ref ListaVuelos listaVuelos,  ListaCiudades listaCiudades, ref string [] arreglo)
        {
            this.listaVuelos = listaVuelos;
            this.arreglo = arreglo;
            listCity = listaCiudades;
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            VueloForm ventanaVuelo = new VueloForm(ref listaVuelos, ref arreglo);
            ventanaVuelo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PasajeroForm ventanaPasajero = new PasajeroForm(ref listaVuelos);
            ventanaPasajero.ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(File.Exists("Vuelos.txt")){
            File.Delete("Vuelos.txt");
            
            }
            if(File.Exists("Pasajero.txt")){
            File.Delete("Pasajero.txt");
            }
            StreamWriter writer = new StreamWriter("Vuelos.txt");
            StreamWriter writerr = new StreamWriter("Pasajero.txt");
            for (int i = 0; i < listaVuelos.Count; i++) {
                string asientos = "";
                for (int j = 0; j < 18; j++) 
                {
                    if (listaVuelos[i].asientos[j] == false) {
                        asientos = asientos + j.ToString() + "|";
                    }
                }
                string vuelo = listaVuelos[i].ruta + "|" + listaVuelos[i].o + "|" + listaVuelos[i].d + "|" + listaVuelos[i].asientosDisponibles + "|" + listaVuelos[i].costo + "|" + listaVuelos[i].tiempo + "|" 
                              + listaVuelos[i].fecha + "|" + asientos + ".";
                
                writer.WriteLine(vuelo);
                writer.Flush();
            }
            writer.Close();
            for (int i = 0; i < listaVuelos.Count; i++) {
                for (int j = 0; j < listaVuelos[i].listaP.Count; j++) {
                    string pas = listaVuelos[i].listaP[j].nombre + "|" + listaVuelos[i].listaP[j].apellido + "|" + listaVuelos[i].listaP[j].getAsiento() + "|" + listaVuelos[i].listaP[j].getEdad() + "|" + listaVuelos[i].listaP[j].getVuelo();
                    writerr.WriteLine(pas);
                    writerr.Flush();

                }
               
            
            }
            writerr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaVuelos.Count == 0)
            {
                MessageBox.Show("No Hay Vuelos Registrados.");
            }
            else
            {
                EliminarVuelo eliminarVentana = new EliminarVuelo(ref listaVuelos);
                eliminarVentana.ShowDialog();

            }
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            GrafoForm ventanaCiudad = new GrafoForm(ref listaVuelos, ref arreglo);
            ventanaCiudad.ShowDialog();
        }
        }

    }
