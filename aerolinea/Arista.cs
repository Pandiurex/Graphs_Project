using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aerolinea
{
    public class Arista
    {
       public  string destino;
        int peso;
      public  int x, y;

        public Arista(string d, int p)
        {
           
            destino = d;
            peso = p;
        }
    }
}
