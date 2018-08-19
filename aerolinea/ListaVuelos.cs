using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aerolinea
{
    public class ListaVuelos:List<Vuelocs>
    {
        public void QuickSortAsientos(ref ListaVuelos listaVuelos, int first, int last)
        {
            int i = first;
            int j = last;
            int central;
            int pivote;

            central = (first + last) / 2;
            pivote = listaVuelos[central].asientosDisponibles;

            while (i <= j)
            {
                while (listaVuelos[i].asientosDisponibles > pivote) { i++; }
                while (listaVuelos[j].asientosDisponibles < pivote) { j--; }

                if (i <= j)
                {
                    Vuelocs temp = listaVuelos[i];
                    listaVuelos[i] = listaVuelos[j];
                    listaVuelos[j] = temp;
                    i++;
                    j--;
                }
            }

            if (first < j)
            {
                QuickSortAsientos(ref listaVuelos, first, j);
            }
            if (i < last)
            {
                QuickSortAsientos(ref listaVuelos, i, last);
            }
        }
        public void QuickSortFecha(ref ListaVuelos listaVuelos, int posicionInicialLista, int posicionFinalLista)
        {
            int i = posicionInicialLista;
            int j = posicionFinalLista;
            int central;
            DateTime pivote;

            central = (posicionInicialLista + posicionFinalLista) / 2;
            pivote = listaVuelos[central].fecha;

            while (i <= j)
            {
                while (listaVuelos[i].fecha < pivote) { i++; }
                while (listaVuelos[j].fecha > pivote) { j--; }

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
                QuickSortFecha(ref listaVuelos, posicionInicialLista, j);
            }
            if (i < posicionFinalLista)
            {
                QuickSortFecha(ref listaVuelos, i, posicionFinalLista);
            }
        }
        
    }
}
