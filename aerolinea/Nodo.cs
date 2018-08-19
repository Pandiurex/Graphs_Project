using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aerolinea
{
   public class Nodo
    {
        public string origen;
        public int x, y;
       public ListaAristas listaAristas;
        public Nodo(string o, ListaAristas aristList)
        {
            
            origen = o;
            listaAristas = new ListaAristas();
            listaAristas = aristList;
        }
        
    }
    
}
