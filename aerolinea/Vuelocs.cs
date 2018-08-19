using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aerolinea
{
    public class Vuelocs
    {
        public List<Pasajero> listaP;
        public string ruta;
        public DateTime fecha;
        public bool[] asientos = new bool[18];
        public int asientosDisponibles = 18;
        public int costo;
        public int tiempo;
        public string o, d;

        public Vuelocs(string Ruta, string origen, string destino,  DateTime fecha, int tiempo, int costo)
        {
            this.ruta = Ruta;
            this.costo = costo;
            this.tiempo = tiempo;
            this.fecha = fecha;
            this.o = origen;
            this.d = destino;
        }

        public Vuelocs(string Ruta,string origen, string destino, int Asiento, int costo, int tiempo, DateTime fecha, bool [] asientoDisponible)
        {
            this.ruta = Ruta;
            this.asientosDisponibles = Asiento;
            this.costo = costo;
            this.tiempo = tiempo;
            this.fecha = fecha;
            this.o =origen;
            this.d=destino;
            listaP = new ListaPasajeros();
            for (int i = 0; i < 18; i++)
                asientos[i] = asientoDisponible[i];
        }

        public Vuelocs(string cad)
        {
            int ind;
            this.asientos = new bool[18];
            string indS;
            indS = "";
            for (int i = 3; i < cad.Length; i++)
            {
                if (cad[i] != '|')
                    indS += cad[i];
                else
                {
                    ind = Int32.Parse(indS);
                    asientos[ind] = false;
                }
            }
        }

        public override string ToString()
        {
            return ruta + " " + asientosDisponibles.ToString()+" "+costo+" "+tiempo+" " + "  " + fecha;
        }

        public void setAD(int ind)
        {
            asientosDisponibles--;
            this.asientos[ind] = false;

        }

        public bool getAD(int ind)
        {
            return asientos[ind];
        }
        public void setPasajero(Pasajero p)
        {
            this.listaP.Add(p);
        }

        public string getRuta()
        {
            return ruta;
        }

        public Pasajero getPasajero(int ind)
        {
            return listaP[ind];
        }

        public int getOcupados()
        {
            return listaP.Count();
        }
        public string getO()
        {
            return o;
        }
        public string getD()
        {
            return d;
        }
    }
}