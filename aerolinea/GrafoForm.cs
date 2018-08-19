using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace aerolinea
{
    public partial class GrafoForm : Form
    {
        ListaVuelos listaVuelos;
        Grafo grafito;
        string[] arreglo = new string[3];
        int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
        public GrafoForm(ref ListaVuelos listaVuelos, ref string [] arreglo)
        {
           
            this.listaVuelos = listaVuelos;
            this.arreglo = arreglo;
            grafito = new Grafo(listaVuelos);
            InitializeComponent();
            ActualizarListView();
            button1.Enabled = false;
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int contador = grafito.Count;
            int x1=0, x2=0, y1=0, y2=0;
            string b;
            Pen pluma1 = new Pen(Color.Black);
            Pen pluma2=new Pen(Color.Red,2);
            SolidBrush nodo = new SolidBrush(Color.Purple);
            Pen pluma3 = new Pen(Color.Cyan,3);
            AdjustableArrowCap flecha = new AdjustableArrowCap(3, 5);
            pluma3.CustomEndCap = flecha;

            double a = 2 * Math.PI / contador;
            double r;
            int x, y;
            r = (panel1.Height - 20) / 2;
            for (int i = 0; i < grafito.Count; i++)
            {
                b = grafito[i].origen;
                x = Convert.ToInt32(Math.Cos(i*a) * r + 20 + r);
                y = Convert.ToInt32(Math.Sin(i*a) * r + 20 + r);
                panel1.CreateGraphics().DrawEllipse(pluma2, x - 15, y - 15, 20, 20);
                panel1.CreateGraphics().DrawString(b, DefaultFont, nodo, x-10, y-10);
                grafito[i].x = x;
                grafito[i].y = y;

                for (int j = 0; j < grafito[i].listaAristas.Count; j++) 
                {
                    if ( grafito[i].listaAristas[j].destino==b) {
                        grafito[i].listaAristas[j].x = grafito[i].x;
                        grafito[i].listaAristas[j].y = grafito[i].y;
                    }
                }
            }
            
            for (int i = 0; i < listaVuelos.Count; i++)
            {
                for (int j=0;j<grafito.Count;j++)
                {
                    if (listaVuelos[i].o == grafito[j].origen)
                    {
                        x1 = grafito[j].x;
                        y1 = grafito[j].y;

                    }
                    for (int k=0; k < grafito[j].listaAristas.Count; k++) 
                    {
                        if (listaVuelos[i].d == grafito[j].listaAristas[k].destino)
                        {
                            x2 = grafito[j].listaAristas[k].x;
                            y2 = grafito[j].listaAristas[k].y;
                        }
                    }
                }
                panel1.CreateGraphics().DrawLine(pluma3, x1, y1, x2, y2);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        private void ActualizarListView()
        {
            listView1.Items.Clear();
            

            for (int i = 0; i < grafito.Count; i++) 
            {
                string[] s = new string[2];
                s[0] = i.ToString();
                s[1] = grafito[i].origen;
                ListViewItem itm = new ListViewItem(s);

                listView1.Items.Add(itm);

            }
           
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int itemSeleccionado = Int32.Parse(listView1.FocusedItem.Text);
            for (int j = 0; j < listaVuelos.Count; j++)
            {
                if (listaVuelos[j].o == grafito[itemSeleccionado].origen || listaVuelos[j].d == grafito[itemSeleccionado].origen)
                {
                    listaVuelos.Remove(listaVuelos[j]);
                    j = -1;

                }
            }
            grafito.Remove(grafito[itemSeleccionado]);
            ActualizarListView();
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaVuelos listaVuelosCandidatos= new ListaVuelos();
            ListaVuelos listaVuelosFinal=new ListaVuelos();

            List<string> listaNodos=new List<string>();

            Pen penKruskal= new Pen(Color.GreenYellow,4);
            penKruskal.EndCap=System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            SolidBrush nodo = new SolidBrush(Color.Purple);

            for(int i=0;i<listaVuelos.Count;i++){
                listaVuelosCandidatos.Add(listaVuelos[i]);
                
            }
            
            for(int i=0;i<grafito.Count;i++){
                listaNodos.Add(grafito[i].origen);
            }

            QuickSortPrecio(ref listaVuelosCandidatos, 0, listaVuelosCandidatos.Count - 1);

            for (int i = 0; i < listaVuelosCandidatos.Count; i++)
            {
                for (int j = 0; j < listaNodos.Count; j++)
                {
                    if (listaNodos[j].Contains(listaVuelosCandidatos[i].o) && !listaNodos[j].Contains(listaVuelosCandidatos[i].d))
                    {
                        for (int h = 0; h < listaNodos.Count; h++)
                        {
                            if (listaNodos[h].Contains(listaVuelosCandidatos[i].d) && !listaNodos[h].Contains(listaVuelosCandidatos[i].o) && listaNodos[h].Length == 1)
                            {
                                listaVuelosFinal.Add(listaVuelosCandidatos[i]);
                                listaNodos[j] = listaNodos[j] + listaVuelosCandidatos[i].d;
                                listaNodos.Remove(listaNodos[h]);

                                break;
                            }
                            else if (listaNodos[h].Contains(listaVuelosCandidatos[i].d) && !listaNodos[h].Contains(listaVuelosCandidatos[i].o) && listaNodos[h].Length > 1)
                            {
                                listaVuelosFinal.Add(listaVuelosCandidatos[i]);
                                listaNodos[j] = listaNodos[j] + listaNodos[h];
                                listaNodos.Remove(listaNodos[h]);

                                break;
                            }
                        }
                    }
                }
            }
            this.panel1.Refresh();



            for (int i = 0; i < listaVuelosFinal.Count; i++)
            {
                for (int j = 0; j < grafito.Count; j++)
                {
                    if (listaVuelosFinal[i].o == grafito[j].origen)
                    {
                        x1 = grafito[j].x;
                        y1 = grafito[j].y;
                    }
                    for (int h = 0; h < grafito[j].listaAristas.Count; h++)
                    {
                        if (listaVuelosFinal[i].d == grafito[j].listaAristas[h].destino)
                        {
                            x2 = grafito[j].listaAristas[h].x;
                            y2 = grafito[j].listaAristas[h].y;
                        }
                    }
                }
               panel1.CreateGraphics().DrawLine(penKruskal, x1, y1, x2, y2);
               panel1.CreateGraphics().DrawString(listaVuelosFinal[i].costo.ToString(), DefaultFont, nodo, (x1 + x2) / 2, (y1 + y2) / 2);
            }
            int Kruskal = 0;
            for (int i = 0; i < listaVuelosFinal.Count; i++)
            {
                Kruskal += listaVuelosFinal[i].costo;
            }
            kruskallbox.Text =  " $ " +Kruskal.ToString() ;

            ListaArsitas.Items.Clear();
            string[] s = new string[2];
            for (int i = 0; i < listaVuelosFinal.Count; i++)
            {
                s[0] = listaVuelosFinal[i].o;
                s[1] = listaVuelosFinal[i].d;

                ListViewItem listviewKP = new ListViewItem(s);
                ListaArsitas.Items.Add(listviewKP);
            }

            primmbox.Clear();

        }
        private void primm_Click(object sender, EventArgs e)
        {
            this.Refresh();
            ListaVuelos listaCand = new ListaVuelos();
            ListaVuelos listaFinal = new ListaVuelos();
            string B;
            string ARM;
            B = "";
            ARM = "";

            for (int i = 0; i < listaVuelos.Count; i++)
            {
                listaCand.Add(listaVuelos[i]);
            }
            for (int i = 0; i < grafito.Count; i++)
            {
                ARM = ARM + grafito[i].origen;
            }
            int contadorCand = listaCand.Count;
            QuickSortTiempo(ref listaCand, 0, listaCand.Count - 1);
            Pen arista = new Pen(Color.BlueViolet, 4);
            arista.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            SolidBrush colorLetras = new SolidBrush(Color.Red);

            while (B.Length != grafito.Count)
            {
                rehacer(ref listaCand, listaFinal);
                seleccion(ref listaCand, ref listaFinal, B);
                if (B == "")
                {
                    listaFinal.Add(listaCand[0]);
                    B = listaCand[0].o + listaCand[0].d;
                    listaCand.RemoveAt(0);
                }
              
                else
                {
                    
                    listaFinal.Add(listaCand[0]);
                    if (B.Contains(listaCand[0].o))
                    {
                        B = B + listaCand[0].d;
                    }
                    else
                    {
                        B = B + listaCand[0].o;
                    }
                    listaCand.RemoveAt(0);
                }
            }

            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            for (int i = 0; i < listaFinal.Count; i++)
            {
                for (int j = 0; j < grafito.Count; j++)
                {
                    if (listaFinal[i].o == grafito[j].origen)
                    {
                        x1 = grafito[j].x;
                        y1 = grafito[j].y;
                    }
                    for (int h = 0; h < grafito[j].listaAristas.Count; h++)
                    {
                        if (listaFinal[i].d == grafito[j].listaAristas[h].destino)
                        {
                            x2 = grafito[j].listaAristas[h].x;
                            y2 = grafito[j].listaAristas[h].y;
                        }
                    }
                }
                panel1.CreateGraphics().DrawLine(arista, x1, y1, x2, y2);
                panel1.CreateGraphics().DrawString(listaFinal[i].tiempo.ToString(), DefaultFont, colorLetras, (x1 + x2) / 2, (y1 + y2) / 2);

            }

            this.panel1.Refresh();
            for (int i = 0; i < listaFinal.Count; i++)
            {
                for (int j = 0; j < grafito.Count; j++)
                {
                    if (listaFinal[i].o == grafito[j].origen)
                    {
                        x1 = grafito[j].x;
                        y1 = grafito[j].y;
                    }
                    for (int h = 0; h < grafito[j].listaAristas.Count; h++)
                    {
                        if (listaFinal[i].d == grafito[j].listaAristas[h].destino)
                        {
                            x2 = grafito[j].listaAristas[h].x;
                            y2 = grafito[j].listaAristas[h].y;
                        }
                    }
                }
                panel1.CreateGraphics().DrawLine(arista, x1, y1, x2, y2);
                panel1.CreateGraphics().DrawString(listaFinal[i].tiempo.ToString(), DefaultFont, colorLetras, (x1 + x2) / 2, (y1 + y2) / 2);
            }
            int pesoTotalPrim = 0;

            for (int i = 0; i < listaFinal.Count; i++)
            {
                pesoTotalPrim += listaFinal[i].tiempo;
            }

            primmbox.Text = pesoTotalPrim.ToString()+  " hrs" ;
            kruskallbox.Clear();
            ListaArsitas.Items.Clear();
            string[] s = new string[2];
            for (int i = 0; i < listaFinal.Count; i++)
            {
                s[0] = listaFinal[i].o;
                s[1] = listaFinal[i].d;

                ListViewItem listviewKP = new ListViewItem(s);
                ListaArsitas.Items.Add(listviewKP);
            }
        }


        public void QuickSortPrecio(ref ListaVuelos listaVuelos, int posicionInicialLista, int posicionFinalLista)
        {
            int i = posicionInicialLista;
            int j = posicionFinalLista;
            int central;
            int pivote;

            central = (posicionInicialLista + posicionFinalLista) / 2;
            pivote = listaVuelos[central].costo;

            while (i <= j)
            {
                while (listaVuelos[i].costo < pivote) { i++; }
                while (listaVuelos[j].costo > pivote) { j--; }

                if (i <= j)
                {
                    Vuelocs temp = listaVuelos[i];
                    listaVuelos[i] = listaVuelos[j];
                    listaVuelos[j] = temp;
                    i++;
                    j--;
                }
            }

            if (posicionInicialLista < j)
            {
                QuickSortPrecio(ref listaVuelos, posicionInicialLista, j);
            }
            if (i < posicionFinalLista)
            {
                QuickSortPrecio(ref listaVuelos, i, posicionFinalLista);
            }
        }
        public void QuickSortTiempo(ref ListaVuelos listaVuelos, int posicionInicialLista, int posicionFinalLista)
        {
            int i = posicionInicialLista;
            int j = posicionFinalLista;
            int central;
            int pivote;

            central = (posicionInicialLista + posicionFinalLista) / 2;
            pivote = listaVuelos[central].tiempo;

            while (i <= j)
            {
                while (listaVuelos[i].tiempo < pivote) { i++; }
                while (listaVuelos[j].tiempo > pivote) { j--; }

                if (i <= j)
                {
                    Vuelocs temp = listaVuelos[i];
                    listaVuelos[i] = listaVuelos[j];
                    listaVuelos[j] = temp;
                    i++;
                    j--;
                }
            }

            if (posicionInicialLista < j)
            {
                QuickSortTiempo(ref listaVuelos, posicionInicialLista, j);
            }
            if (i < posicionFinalLista)
            {
                QuickSortTiempo(ref listaVuelos, i, posicionFinalLista);
            }
        }

        public ListaVuelos rehacer(ref ListaVuelos lista, ListaVuelos listaFinal)
        {

            if (listaFinal.Count == 0)
            {
                for (int i = 0; i < listaVuelos.Count; i++)
                {
                    string ruta = listaVuelos[i].o + listaVuelos[i].d;
                    if (ruta.Contains(grafito[0].origen))
                    {
                        lista.Add(listaVuelos[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < listaFinal.Count; i++)
                {
                    for (int j = 0; j < listaVuelos.Count; j++)
                    {
                        string ruta = listaVuelos[j].o + listaVuelos[j].d;

                        if (ruta.Contains(listaFinal[i].o) || ruta.Contains(listaFinal[i].d))
                        {
                            lista.Add(listaVuelos[j]);
                        }
                    }
                }
            }

            for (int i = 0; i < listaFinal.Count; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    if (listaFinal[i].ruta == lista[j].ruta)
                    {
                        lista.Remove(lista[j]);
                    }
                }
            }

            return lista;
        }

        public ListaVuelos seleccion(ref ListaVuelos lista, ref ListaVuelos listaFinal, string ARM)
        {
            for (int i = 0; i < listaFinal.Count; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    if (listaFinal[i].ruta == lista[j].ruta)
                    {
                        lista.Remove(lista[j]);
                    }
                }
            }

            for (int i = 0; i < lista.Count; i++)
            {
                if (ARM.Contains(lista[i].o) && ARM.Contains(lista[i].d))
                {
                    lista.Remove(lista[i]);
                }
            }

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = lista.Count - 1; j > i; j--)
                {
                    if (lista[i].tiempo > lista[j].tiempo)
                    {
                        lista[i] = lista[j];
                        lista.Remove(lista[j]);
                    }
                    else if (lista[i].tiempo == lista[j].tiempo)
                    {
                        lista.Remove(lista[j]);
                    }
                    else
                    {
                        lista.Remove(lista[j]);
                    }
                }
            }
            return lista;
        }

        private void Diksjtra_Click(object sender, EventArgs e)
        {
            DikstraForm dikstra = new DikstraForm(ref listaVuelos, grafito, ref arreglo);
            dikstra.ShowDialog();
        }

        
        
    }
}
