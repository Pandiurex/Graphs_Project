using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace aerolinea
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ListaVuelos listaVuelos=new ListaVuelos();
            ListaCiudades listaCity = new ListaCiudades();
            string[] arreglo = new string[3];
            /*Vuelocs v1;
            Vuelocs v2;
            Vuelocs v3;
            Vuelocs v4;
            Vuelocs v5;
            Vuelocs v6;
            Vuelocs v7;
            Vuelocs v8;
            Vuelocs v9;
            Vuelocs v10;
            Vuelocs v11;
            Vuelocs v12;
            Vuelocs v13;
            Vuelocs v14;
            Vuelocs v15;
            Vuelocs v16;
            Vuelocs v17;
            Vuelocs v18;
            Vuelocs v19;
            Vuelocs v20;
            Vuelocs v21;
            Vuelocs v22;
            Vuelocs v23;
            Vuelocs v24;
            Vuelocs v25;
            Vuelocs v26;
            Vuelocs v27;
            Vuelocs v28;
            Vuelocs v29;
            Vuelocs v30;
            Vuelocs v31;
            Vuelocs v32;
            Vuelocs v33;
            Vuelocs v34;

            

            v1 = new Vuelocs("SK1AB", 18, Convert.ToDateTime("12/12/2016 15:24:16 "));
            v2 = new Vuelocs("SK1AF", 18, Convert.ToDateTime("09/11/2016 12:30:20 "));
            v3 = new Vuelocs("SK1AG", 18, Convert.ToDateTime("1/10/2015  04:34:22 "));
            v4 = new Vuelocs("SK1BA", 18, Convert.ToDateTime("21/01/2008 08:28:28 "));
            v5 = new Vuelocs("SK1BC", 18, Convert.ToDateTime("28/04/2004 13:24:17 "));
            v6 = new Vuelocs("SK1BD", 18, Convert.ToDateTime("12/12/2005 18:48:18 "));
            v7 = new Vuelocs("SK1BD", 18, Convert.ToDateTime("11/09/2013 16:49:19 "));
            v8 = new Vuelocs("SKICD", 18, Convert.ToDateTime("21/12/2006 17:22:20 "));
            v9 = new Vuelocs("SK1CE", 18, Convert.ToDateTime("12/12/2007 19:36:21 "));
            v10 = new Vuelocs("SK1EC", 18, Convert.ToDateTime("31/12/1996 12:14:22 "));
            v11 = new Vuelocs("SK1EG", 18, Convert.ToDateTime("02/02/2015 23:48:23 "));
            v12 = new Vuelocs("SK1EL", 18, Convert.ToDateTime("17/12/1996 12:59:24 "));
            v13 = new Vuelocs("SK1ED", 18, Convert.ToDateTime("05/11/1991 11:00:25 "));
            v14 = new Vuelocs("SK1DE", 18, Convert.ToDateTime("01/05/1992  11:21:26 "));
            v15 = new Vuelocs("SK1DB", 18, Convert.ToDateTime("15/06/2003 13:27:27 "));
            v16 = new Vuelocs("SK1FB", 18, Convert.ToDateTime("02/12/2015 10:29:28 "));
            v17 = new Vuelocs("SK1FL", 18, Convert.ToDateTime("09/12/2008 09:41:29 "));
            v18 = new Vuelocs("SK1GA", 18, Convert.ToDateTime("11/04/1999 03:34:30 "));
            v19 = new Vuelocs("SK1GE", 18, Convert.ToDateTime("23/10/2000 04:24:31 "));
            v20 = new Vuelocs("SK1GL", 18, Convert.ToDateTime("22/02/2002 11:27:32 "));
            v21 = new Vuelocs("SK1GJ", 18, Convert.ToDateTime("13/07/2014 13:35:33 "));
            v22 = new Vuelocs("SK1GH", 18, Convert.ToDateTime("23/08/2012 14:24:34 "));
            v23 = new Vuelocs("SK1HG", 18, Convert.ToDateTime("13/05/2013 12:23:35 "));
            v24 = new Vuelocs("SK1HI", 18, Convert.ToDateTime("19/09/1995 12:12:36 "));
            v25 = new Vuelocs("SK1IH", 18, Convert.ToDateTime("05/03/1993 20:10:37 "));
            v26 = new Vuelocs("SK1IK", 18, Convert.ToDateTime("15/03/1998 22:16:38 "));
            v27 = new Vuelocs("SK1KI", 18, Convert.ToDateTime("21/11/1999 20:45:39 "));
            v28 = new Vuelocs("SK1KJ", 18, Convert.ToDateTime("11/09/2013 10:35:54 "));
            v29 = new Vuelocs("SK1JL", 18, Convert.ToDateTime("02/08/1993 15:30:18 "));
            v30 = new Vuelocs("SK1JM", 18, Convert.ToDateTime("21/09/2008 23:27:05 "));
            v31 = new Vuelocs("SK1LM", 18, Convert.ToDateTime("11/04/1997 21:09:15 "));
            v32 = new Vuelocs("SK1LK", 18, Convert.ToDateTime("16/11/2014 17:04:19 "));
            v33 = new Vuelocs("SK1LE", 18, Convert.ToDateTime("07/02/1991 18:02:10 "));
            v34 = new Vuelocs("SK1ML", 18, Convert.ToDateTime("23/02/1992 16:22:05 "));

            listaVuelos.Add(v1);
            listaVuelos.Add(v2);
            listaVuelos.Add(v3);
            listaVuelos.Add(v4);
            listaVuelos.Add(v5);
            listaVuelos.Add(v6);
            listaVuelos.Add(v7);
            listaVuelos.Add(v8);
            listaVuelos.Add(v9);
            listaVuelos.Add(v10);
            listaVuelos.Add(v11);
            listaVuelos.Add(v12);
            listaVuelos.Add(v13);
            listaVuelos.Add(v14);
            listaVuelos.Add(v15);
            listaVuelos.Add(v16);
            listaVuelos.Add(v17);
            listaVuelos.Add(v18);
            listaVuelos.Add(v19);
            listaVuelos.Add(v20);
            listaVuelos.Add(v21);
            listaVuelos.Add(v22);
            listaVuelos.Add(v23);
            listaVuelos.Add(v24);
            listaVuelos.Add(v25);
            listaVuelos.Add(v26);
            listaVuelos.Add(v27);
            listaVuelos.Add(v28);
            listaVuelos.Add(v29);
            listaVuelos.Add(v30);
            listaVuelos.Add(v31);
            listaVuelos.Add(v32);
            listaVuelos.Add(v33);
            listaVuelos.Add(v34);*/
            if(File.Exists("Vuelos.txt")){
            StreamReader reader = new StreamReader("Vuelos.txt");
                string ruta;
                string origen;
                string destino;
                int asiento;
                DateTime fecha;
                int costo;
                int tiempo;
                string leer = reader.ReadLine();
                bool[] asientosD = new bool[18];

                string [] formato;
                int o;
                while(leer!=null){
                    for (int i = 0; i < 18; i++) 
                    {
                        asientosD[i] = true;
                    }
                formato=leer.Split('|');
                ruta=formato[0];
                origen = formato[1];
                destino = formato[2];
                asiento=Int32.Parse(formato[3]);
                costo =Int32.Parse(formato[4]);
                tiempo = Int32.Parse(formato[5]);
                fecha=Convert.ToDateTime(formato[6]);
                o=7;
                while(formato[o]!="."){
                    int jg = Int32.Parse(formato[o]);
                    asientosD[jg] = false; 
                    o++;
                }

                Vuelocs vuelos = new Vuelocs(ruta,origen,destino,asiento,costo,tiempo,fecha,asientosD);
                listaVuelos.Add(vuelos);
                leer=reader.ReadLine();
                }
            
            
            reader.Close();
            }
            if(File.Exists("Pasajero.txt")){
                StreamReader lectura = new StreamReader("Pasajero.txt");

                string nombre, apellido,vuelo;
                string asiento,edad;
                
                string [] formatoo;

                string leer = lectura.ReadLine();

                while (leer != null) {
                    formatoo = leer.Split('|');
                    nombre = formatoo[0];
                    apellido = formatoo[1];
                    asiento = formatoo[2];
                    edad = formatoo[3];
                    vuelo = formatoo[4];

                    Pasajero pass=new Pasajero(nombre,apellido,edad,asiento,vuelo);

                    for (int i = 0; i < listaVuelos.Count; i++) { 
                        if(vuelo==listaVuelos[i].ruta){
                        listaVuelos[i].setPasajero(pass);
                        listaVuelos[i].asientos[Int32.Parse(asiento)-1]=false;
                        break;
                        }
                    }
                    leer = lectura.ReadLine();

                }
                lectura.Close();
            }
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal(ref listaVuelos, listaCity,ref arreglo);
            ventanaPrincipal.ShowDialog();

            //Application.Run(new Form1());

        }
    }
}
 