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
    public partial class InsertarCiudad : Form
    {
        ListaVuelos listaVuelos;
        ListaCiudades listaCity;
        int valorX;
        int valorY;
        public InsertarCiudad(ref ListaCiudades listCiudad, ListaVuelos listaVuelo)
        {
            listaVuelos = listaVuelo;
            listaCity = listCiudad;
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen plumaAgregar = new Pen(Color.Pink, 5);
            Pen plumaFlecha = new Pen(Color.Red, 5);

            plumaFlecha.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            SolidBrush nombreVertice = new SolidBrush(Color.Pink);

            for (int i = 0; i < listaCity.Count; i++)
            {

                int coordenadaX = listaCity[i].x;
                int coordenadaY = listaCity[i].y;

                string nombreCity = listaCity[i].abreviacion;

                panel1.CreateGraphics().DrawRectangle(plumaAgregar, coordenadaX, coordenadaY, 25, 25);
                panel1.CreateGraphics().DrawLine(plumaFlecha, 0, 0, valorX, valorY);
                panel1.CreateGraphics().DrawString(nombreCity, DefaultFont, nombreVertice, coordenadaX + 5, coordenadaY + 5);

            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Pen plumaVisual = new Pen(Color.Red, 5);
            Pen plumaAgregar = new Pen(Color.Blue, 5);
            Pen plumaFlecha = new Pen(Color.Red, 5);
            Pen plumaFlechaAgregar = new Pen(Color.Blue, 5);

            plumaFlecha.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            plumaFlechaAgregar.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            SolidBrush nombreVertice = new SolidBrush(Color.Blue);

            valorX = e.X;
            valorY = e.Y;

            panel1.CreateGraphics().Clear(Color.White);

            for (int i = 0; i < listaCity.Count; i++)
            {

                int coordenadaX = listaCity[i].x;
                int coordenadaY = listaCity[i].y;

                string nombreCity = listaCity[i].abreviacion;

                panel1.CreateGraphics().DrawRectangle(plumaAgregar, coordenadaX, coordenadaY, 20, 20);
                panel1.CreateGraphics().DrawLine(plumaFlechaAgregar, 0, 0, coordenadaX, coordenadaY);
                panel1.CreateGraphics().DrawString(nombreCity, DefaultFont, nombreVertice, coordenadaX + 5, coordenadaY + 5);
            }
            panel1.CreateGraphics().DrawRectangle(plumaVisual, valorX, valorY, 25, 25);
            panel1.CreateGraphics().DrawLine(plumaFlecha, 0, 0, valorX, valorY);
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cityName = textBox1.Text;
            bool flag = true;
            if (cityName == "")
            {
                MessageBox.Show("No se puede Dejar en blanco");
            }
            else
            {
                if (listaCity.Count == 0)
                {
                    Ciudades ciudad = new Ciudades(valorX, valorY, cityName);
                    listaCity.Add(ciudad);
                    button1.Enabled = false;
                }

                else
                {
                    for (int i = 0; i < listaCity.Count; i++)
                    {
                        if (listaCity[i].abreviacion == cityName)
                        {
                            MessageBox.Show("Esta repetido, hay Pedo");
                            flag = false;
                            break;
                        }
                        if (flag && i == listaCity.Count - 1)
                        {

                            Ciudades city = new Ciudades(valorX, valorY, cityName);
                            listaCity.Add(city);
                            button1.Enabled = false;
                            break;
                        }
                    }
                }
            }
        }
    }
}
