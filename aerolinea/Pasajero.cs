using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aerolinea
{
    public class Pasajero
    {
        public string nombre;
        public string apellido;
        int asiento;
        string edad;
        string vuelo;


        public Pasajero(string nombre, string apellido,string edad, string asiento,string vuelo) {
            this.nombre = nombre;
            this.apellido= apellido;
            this.edad = edad;
            this.asiento = Int32.Parse(asiento);
            this.vuelo = vuelo;
        }
        public string getNombre()
        {
            return nombre + " " + apellido;
        }
        public string getAsiento() {
            return (asiento).ToString();
        }
        public string getEdad() {
            return edad;
        }
        public string getVuelo() {
            return vuelo;
        }

    }
    
}
