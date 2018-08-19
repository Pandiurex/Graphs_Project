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
    public partial class DikstraForm : Form
    {
        ListaVuelos listaV;
        Grafo grafito;
        ListaVuelos ListaK = new ListaVuelos();
        string rutaFull = "";
        string[] arreglos = new string[3];

        int[] Dijkstra = new int[15];
        int[] arreglo = new int[1];

        public DikstraForm(ref ListaVuelos listaVuelos, Grafo grafos, ref string[] arreglo)
        {
            arreglos = arreglo;
            listaV = listaVuelos;
            grafito = grafos;
            InitializeComponent();
        }

        private void origenTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void destinoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonCost_Click(object sender, EventArgs e)
        {
            Pen arista = new Pen(Color.Green, 4);
            string rutaFull = "";
            SolidBrush colorLetras = new SolidBrush(Color.Black);
            string nodo = "";

            for (int i = 0; i < grafito.Count; i++)
            {
                nodo = nodo + grafito[i].origen;
            }
            if (origenBox.Text == destinoBox.Text)
            {
                MessageBox.Show("El origen y destino no puede ser el mismo");
            }

            else if (!nodo.Contains(origenBox.Text))
            {
                MessageBox.Show("La ciudad de origen no existe");
            }
            else if (!nodo.Contains(destinoBox.Text))
            {
                MessageBox.Show("La ciudad destino no existe");
            }
            else
            {
                showRoute.Items.Clear();
                int nodoInicial = 0;
                for (int i = 0; i < grafito.Count; i++)
                {
                    if (destinoBox.Text == grafito[i].origen)
                    {
                        nodoInicial = i;
                    }
                }

                int lesserPoint = 0;
                string route = "";
                int[] Dijs = new int[grafito.Count * 3];

                for (int i = 0; i < (Dijs.Count() / 3) * 2; i++)
                {
                    if (i == nodoInicial)
                    {
                    }
                    else
                    {
                        if (i == nodoInicial + grafito.Count)
                        {
                            Dijs[i] = 0;
                            Dijs[i + grafito.Count] = nodoInicial;
                        }
                        else
                        {
                            Dijs[i] = 10000;
                        }
                    }
                }

                while (route.Length < grafito.Count)
                {
                    int[] bestList = new int[grafito.Count * 2];

                    for (int i = 0; i < grafito.Count; i++)
                    {
                        bestList[i] = 10000;
                    }
                    lesserPoint = nodesTime(Dijs, nodoInicial, ref route);
                    nodoInicial = lesserPoint;
                }
                Dijkstra = Dijs;
                int origin = 0;
                for (int i = 0; i < grafito.Count; i++)
                {
                    if (destinoBox.Text == grafito[i].origen)
                    {
                        origin = i;
                    }
                }
                for (int i = 0; i < grafito.Count; i++)
                {
                    string origins = "";
                    int h = i;
                    while (h != origin)
                    {
                        origins = origins + grafito[h].origen;
                        h = Dijs[h + grafito.Count * 2];
                    }
                    origins = origins + grafito[h].origen;
                    showRoute.Items.Add("Origen  " + grafito[origin].origen + " " + " Destino " + grafito[i].origen
                        + " -> " + origins + " costo del recorrido = " + Dijs[i].ToString());
                    if (i == 0)
                    {
                        rutaFull = origins;
                        arreglo = new int[rutaFull.Length - 1];
                    }


                }
                for (int i = 0; i < rutaFull.Length - 1; i++)
                {
                    for (int j = 0; j < listaV.Count; j++)
                    {
                        if (listaV[j].o == rutaFull[i].ToString() && listaV[j].d == rutaFull[i+1].ToString())
                        {
                            arreglo[i] = j;
                        }

                    }
                }

                grafoRecorridoT();


            }
        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            string nodo = "";
            for (int i = 0; i < grafito.Count; i++)
            {
                nodo = nodo + grafito[i].origen;
            }
            if (origenBox.Text == destinoBox.Text)
            {
                MessageBox.Show("El origen y destino no puede ser el mismo");
            }

            else if (!nodo.Contains(origenBox.Text))
            {
                MessageBox.Show("La ciudad de origen no existe");
            }
            else if (!nodo.Contains(destinoBox.Text))
            {
                MessageBox.Show("La ciudad destino no existe");
            }
            else
            {
                showRoute.Items.Clear();
                int nodoInicial = 0;
                for (int i = 0; i < grafito.Count; i++)
                {
                    if (destinoBox.Text == grafito[i].origen)
                    {
                        nodoInicial = i;
                    }
                }

                int lesserPoint = 0;
                string route = "";
                int[] Dijs = new int[grafito.Count * 3];

                for (int i = 0; i < (Dijs.Count() / 3) * 2; i++)
                {
                    if (i == nodoInicial)
                    {
                    }
                    else
                    {
                        if (i == nodoInicial + grafito.Count)
                        {
                            Dijs[i] = 0;
                            Dijs[i + grafito.Count] = nodoInicial;
                        }
                        else
                        {
                            Dijs[i] = 10000;
                        }
                    }
                }

                while (route.Length < grafito.Count)
                {
                    int[] bestList = new int[grafito.Count * 2];

                    for (int i = 0; i < grafito.Count; i++)
                    {
                        bestList[i] = 10000;
                    }
                    lesserPoint = nodesTime(Dijs, nodoInicial, ref route);
                    nodoInicial = lesserPoint;
                }
                Dijkstra = Dijs;
                int origin = 0;
                for (int i = 0; i < grafito.Count; i++)
                {
                    if (destinoBox.Text == grafito[i].origen)
                    {
                        origin = i;
                    }
                }
                for (int i = 0; i < grafito.Count; i++)
                {
                    string origins = "";
                    int h = i;
                    while (h != origin)
                    {
                        origins = origins + grafito[h].origen;
                        h = Dijs[h + grafito.Count * 2];
                    }
                    origins = origins + grafito[h].origen;
                    showRoute.Items.Add("Origen " + grafito[origin].origen + " " + " Destino " + grafito[i].origen
                        + "  " + origins + " duracion del recorrido = " + Dijs[i].ToString());
                    if (i == 0) {
                        rutaFull = origins;
                        arreglo= new int [rutaFull.Length-1];
                    }
                }
                for(int i=0;i<rutaFull.Length-1;i++){
                    for(int j=0;j<listaV.Count;j++){
                        if (listaV[j].o == rutaFull[i].ToString() && listaV[j].d == rutaFull[i+1].ToString()) {
                            arreglo[i] = j;
                        }
                    
                    }
                }


                int destiny = 0;
                for (int i = 0; i < grafito.Count; i++)
                {
                    if (origenBox.Text == grafito[i].origen)
                    {
                        destiny = i;
                    }
                }
                grafoRecorridoT();
            }
        }

        public int nodesTime(int[] list, int nodoActual, ref string recorrido)
        {
            int[] ind = new int[grafito.Count];
            for (int i = 0; i < grafito.Count; i++)
            {
                ind[i] = 10000;
            }
            int menor = 0;
            bool cambio = false;

            for (int i = 0; i < ListaK.Count; i++)
            {
                if (grafito[nodoActual].origen == ListaK[i].o)
                {
                    for (int j = 0; j < grafito.Count; j++)
                    {
                        if (ListaK[i].d == grafito[j].origen)
                        {
                            if (list[j] < list[nodoActual] + ListaK[i].tiempo) { }
                            else
                            {
                                cambio = true;
                                ind[j] = list[nodoActual] + ListaK[i].tiempo;
                                list[j] = list[nodoActual] + ListaK[i].tiempo;
                                list[j + grafito.Count * 2] = nodoActual;
                                list[j + grafito.Count] = j;
                            }
                        }
                    }
                }
                else if (grafito[nodoActual].origen == ListaK[i].d)
                {
                    for (int j = 0; j < grafito.Count; j++)
                    {
                        if (ListaK[i].o == grafito[j].origen)
                        {
                            if (list[j] < list[nodoActual] + ListaK[i].tiempo)
                            { }
                            else
                            {
                                cambio = true;
                                ind[j] = list[nodoActual] + ListaK[i].tiempo;
                                list[j] = list[nodoActual] + ListaK[i].tiempo;
                                list[j + grafito.Count * 2] = nodoActual;
                                list[j + grafito.Count] = j;

                            }
                        }
                    }
                }

            }
            recorrido = recorrido + grafito[nodoActual].origen;
            if (!cambio)
            {
                for (int i = 0; i < grafito.Count; i++)
                {
                    if (list[i] != 10000)
                    {
                        if (!recorrido.Contains(grafito[i].origen))
                        {
                            nodoActual = i;
                        }
                    }
                }
                return nodoActual;
            }
            else
            {
                menor = aristaMenor(ind);
                return menor;
            }
        }

        public int nodesPrice(int[] list, int nodoActual, ref string recorrido)
        {
            int[] ind = new int[grafito.Count];
            for (int i = 0; i < grafito.Count; i++)
            {
                ind[i] = 10000;
            }
            int menor = 0;
            bool cambio = false;

            for (int i = 0; i < ListaK.Count; i++)
            {
                if (grafito[nodoActual].origen == ListaK[i].o)
                {
                    for (int j = 0; j < grafito.Count; j++)
                    {
                        if (ListaK[i].d == grafito[j].origen)
                        {
                            if (list[j] < list[nodoActual] + ListaK[i].costo) { }
                            else
                            {
                                cambio = true;
                                ind[j] = list[nodoActual] + ListaK[i].costo;
                                list[j] = list[nodoActual] + ListaK[i].costo;
                                list[j + grafito.Count * 2] = nodoActual;
                                list[j + grafito.Count] = j;
                            }
                        }
                    }
                }
                else if (grafito[nodoActual].origen == ListaK[i].d)
                {
                    for (int j = 0; j < grafito.Count; j++)
                    {
                        if (ListaK[i].o == grafito[j].origen)
                        {
                            if (list[j] < list[nodoActual] + ListaK[i].costo)
                            { }
                            else
                            {
                                cambio = true;
                                ind[j] = list[nodoActual] + ListaK[i].costo;
                                list[j] = list[nodoActual] + ListaK[i].costo;
                                list[j + grafito.Count * 2] = nodoActual;
                                list[j + grafito.Count] = j;

                            }
                        }
                    }
                }

            }
            recorrido = recorrido + grafito[nodoActual].origen;
            if (!cambio)
            {
                for (int i = 0; i < grafito.Count; i++)
                {
                    if (list[i] != 10000)
                    {
                        if (!recorrido.Contains(grafito[i].origen))
                        {
                            nodoActual = i;
                        }
                    }
                }
                return nodoActual;
            }
            else
            {
                menor = aristaMenor(ind);
                return menor;
            }
        }
        public int aristaMenor(int[] indicadores)
        {
            int menor = 0;
            for (int i = indicadores.Length - 1; i != 0; i--)
            {
                if (indicadores[menor] > indicadores[i])
                {
                    menor = i;
                }
            }
            return menor;
        }

        private void DikstraForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < listaV.Count; i++)
            {
                ListaK.Add(listaV[i]);
            }
        }

        private void grafoRecorridoT()
        {
            Pen arista = new Pen(Color.Blue, 3);
            SolidBrush colorLetras = new SolidBrush(Color.Black);
            ListaVuelos listaRecorrido = new ListaVuelos();

            int origen = 0;
            for (int i = 0; i < grafito.Count; i++)
            {
                if (destinoBox.Text == grafito[i].origen)
                {
                    origen = i;
                }
            }
            int destino = 0;
            for (int i = 0; i < grafito.Count; i++)
            {
                if (origenBox.Text == grafito[i].origen)
                {
                    destino = i;
                }
            }
            int[] listaDij = Dijkstra;
            int[] ind = new int[grafito.Count];
            for (int i = 0; i < grafito.Count; i++)
            {
                ind[i] = 100;
            }

            int h = 0;

            bool exist = false;
            for (int i = 0; i < listaV.Count; i++)
            {
                if (grafito[origen].origen == listaV[i].o && grafito[destino].origen == listaV[i].d)
                {
                    for (int j = 0; j < grafito.Count; j++)
                    {
                        if (ind[j] != 100)
                        {
                            ind[j] = i;
                            listaRecorrido.Add(listaV[i]);
                            h++;
                            break;
                        }
                    }
                    exist = true;
                }
                else if (grafito[origen].origen == listaV[i].d && grafito[destino].origen == listaV[i].o)
                {
                    exist = true;
                    string route = "SK1" + grafito[origen].origen + grafito[destino].origen;
                    Vuelocs v = new Vuelocs(route, listaV[i].o, listaV[i].d, listaV[i].fecha, listaV[i].tiempo, listaV[i].costo);
                    listaV.Add(v);

                    for (int j = 0; j < grafito.Count; j++)
                    {
                        if (ind[j] != 100)
                        {
                            ind[j] = listaV.Count - 1;
                            listaRecorrido.Add(v);
                            h++;
                            break;
                        }
                    }
                    break;
                }
            }
            if (!exist)
            {
                int nodoActual = destino;

                while (nodoActual != origen)
                {
                    int indice = 0;
                    bool existioDerecho = false;
                    for (int i = 0; i < listaV.Count; i++)
                    {
                        if (grafito[nodoActual].origen == listaV[i].o && grafito[listaDij[nodoActual + grafito.Count * 2]].origen == listaV[i].d)
                        {
                            for (int j = 0; j < grafito.Count; j++)
                            {
                                if (ind[j] == 100)
                                {
                                    existioDerecho = true;
                                    ind[j] = i;
                                    listaRecorrido.Add(listaV[i]);
                                    h++;
                                    break;
                                }
                            }
                        }
                        else if (grafito[nodoActual].origen == listaV[i].d && grafito[listaDij[nodoActual + grafito.Count * 2]].origen == listaV[i].o && !existioDerecho)
                        {
                            existioDerecho = false;
                            indice = i;
                        }
                        if (i == listaV.Count - 1 && !existioDerecho)
                        {
                            string route = "SK1" + grafito[nodoActual].origen + grafito[listaDij[nodoActual + grafito.Count * 2]].origen;
                            Vuelocs vuelo = new Vuelocs(route, listaV[indice].d, listaV[indice].o, listaV[indice].fecha, listaV[indice].tiempo, listaV[indice].costo);
                            listaV.Add(vuelo);

                            for (int j = 0; j < grafito.Count; j++)
                            {
                                if (ind[j] == 100)
                                {
                                    ind[j] = listaV.Count - 1;
                                    listaRecorrido.Add(vuelo);
                                    h++;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    nodoActual = listaDij[nodoActual + grafito.Count * 2];


                }
            }          

            this.Refresh();
            Grafo graphDijs = new Grafo();

            for (int i = 0; i < listaRecorrido.Count; i++)
            {
                for (int j = 0; j < grafito.Count; j++)
                {
                    if (listaRecorrido[i].o == grafito[j].origen)
                    {
                        graphDijs.Add(grafito[j]);
                    }
                    if (listaRecorrido[i].d == grafito[j].origen)
                    {
                        graphDijs.Add(grafito[j]);
                    }
                }
            }

            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            for (int i = 0; i < listaRecorrido.Count; i++)
            {
                for (int j = 0; j < graphDijs.Count; j++)
                {
                    if (listaRecorrido[i].o == graphDijs[j].origen)
                    {
                        x1 = graphDijs[j].x;
                        y1 = graphDijs[j].y;
                    }

                    for (int y = 0; y < graphDijs[j].listaAristas.Count; y++)
                    {
                        if (listaRecorrido[i].d == graphDijs[j].listaAristas[y].destino)
                        {
                            x2 = graphDijs[j].listaAristas[y].x;
                            y2 = graphDijs[j].listaAristas[y].y;
                        }

                    }
                }

                dikstra.CreateGraphics().DrawLine(arista, x1, y1, x2, y2);
                dikstra.CreateGraphics().DrawString(listaRecorrido[i].costo.ToString(), DefaultFont, colorLetras, (x1 + x2) / 2, (y1 + y2) / 2);

            }


        }

        private void dikstra_Paint(object sender, PaintEventArgs e)
        {
            int contador = grafito.Count;
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            string b;
            Pen pluma1 = new Pen(Color.Black);
            Pen pluma2 = new Pen(Color.Red, 2);
            SolidBrush nodo = new SolidBrush(Color.Purple);
            Pen pluma3 = new Pen(Color.Cyan, 3);
            AdjustableArrowCap flecha = new AdjustableArrowCap(3, 5);
            pluma3.CustomEndCap = flecha;

            double a = 2 * Math.PI / contador;
            double r;
            int x, y;
            r = (dikstra.Height - 20) / 2;
            for (int i = 0; i < grafito.Count; i++)
            {
                b = grafito[i].origen;
                x = Convert.ToInt32(Math.Cos(i * a) * r + 20 + r);
                y = Convert.ToInt32(Math.Sin(i * a) * r + 20 + r);
                dikstra.CreateGraphics().DrawEllipse(pluma2, x - 15, y - 15, 20, 20);
                dikstra.CreateGraphics().DrawString(b, DefaultFont, nodo, x - 10, y - 10);
                grafito[i].x = x;
                grafito[i].y = y;

                for (int j = 0; j < grafito[i].listaAristas.Count; j++)
                {
                    if (grafito[i].listaAristas[j].destino == b)
                    {
                        grafito[i].listaAristas[j].x = grafito[i].x;
                        grafito[i].listaAristas[j].y = grafito[i].y;
                    }
                }
            }

            for (int i = 0; i < listaV.Count; i++)
            {
                for (int j = 0; j < grafito.Count; j++)
                {
                    if (listaV[i].o == grafito[j].origen)
                    {
                        x1 = grafito[j].x;
                        y1 = grafito[j].y;

                    }
                    for (int k = 0; k < grafito[j].listaAristas.Count; k++)
                    {
                        if (listaV[i].d == grafito[j].listaAristas[k].destino)
                        {
                            x2 = grafito[j].listaAristas[k].x;
                            y2 = grafito[j].listaAristas[k].y;
                        }
                    }
                }
                dikstra.CreateGraphics().DrawLine(pluma3, x1, y1, x2, y2);

            }
        }

        private void comprar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (i == 0)
                {

                    FormularioForn formulario = new FormularioForn(ref  listaV, true, arreglo[i], ref arreglos);
                    formulario.ShowDialog();
                }
                else {
                    FormularioForn formulario = new FormularioForn(ref  listaV, false, arreglo[i], ref arreglos);
                    formulario.ShowDialog();
                }
            }
        }

    }
}
