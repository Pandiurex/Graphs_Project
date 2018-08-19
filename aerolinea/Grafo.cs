using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aerolinea
{
    public class Grafo : List<Nodo>
    {
        ListaVuelos listaV;

        public Grafo() { }

        public Grafo(ListaVuelos listaV)
        {
            this.listaV = listaV;
              List<string> listaN = new List<string>();
              for (int i = 0; i < listaV.Count; i++)
              {
                  if (!listaN.Contains(listaV[i].getO())){
                      listaN.Add(listaV[i].getO());
                  }
                  if (!listaN.Contains(listaV[i].getD())){
                      listaN.Add(listaV[i].getD());
                  }
               
              }
              for (int i = 0; i < listaN.Count; i++)
              {
                  ListaAristas listaA = new ListaAristas();
                  for (int j = 0; j < listaV.Count; j++)
                  {
                      if (listaV[j].getD() == listaN[i])
                      {
                          Arista arista = new Arista(listaV[j].d, listaV[j].costo);
                          listaA.Add(arista);
                      }
                      
                  }

                  Nodo n = new Nodo(listaN[i],listaA);
                  this.Add(n);
              }
          }
        }
    }

