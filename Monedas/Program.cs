using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pido la cadena
            Console.WriteLine("Escriba la cadena.");
            string cadena = Console.ReadLine();

            //1 oro = 100 plata
            //1 plata = 100 bronce
            //1 bronce = 1 bronce.

            //Convertir a bronce

            int cantidad_Bronce = 0; //Cantidad de bronce

            //La cadena contiene la letra?
            var contieneOro = cadena.Contains('o');
            var contienePlata = cadena.Contains('p');
            var contieneBronce = cadena.Contains('b');


            //Si contiene oro, entonces...
            if (contieneOro)
            {
                var oro = ""; //Variable oro inicializada
                int indexOro = cadena.IndexOf("o");

                //Recorro la cadena A PARTIR de la O.
                for (int i = indexOro; i < cadena.Length; i++)
                {
                    int num; //Variable utilizable para el out del TryParse.
                    bool success = int.TryParse(cadena[i].ToString(), out num); //Consulto si se puede convertir a entero

                    if (success)
                    {
                        oro += num; //Si se puede convertir a entero, coloco el valor en la variable como string
                    }
                    else
                    {
                        if (i > indexOro) break; //En caso de que no, y no sea la misma O de oro, se rompe el ciclo.
                    }
                }
                //Calcula la cantidad de oro en bronce
                cantidad_Bronce += (int.Parse(oro) * 10000);
            } //endif

            //Si contiene plata, entonces...
            if (contienePlata)
            {
                var plata = ""; //Variable plata inicializada
                int indexPlata = cadena.IndexOf("p");

                //Recorro la cadena A PARTIR de la P.
                for (int i = indexPlata; i < cadena.Length; i++)
                {
                    int num; //Variable utilizable para el out del TryParse.
                    bool success = int.TryParse(cadena[i].ToString(), out num); //Consulto si se puede convertir a entero

                    if (success)
                    {
                        plata += num; //Si se puede convertir a entero, coloco el valor en la variable como string
                    }
                    else
                    {
                        if (i > indexPlata) break; //En caso de que no, y no sea la misma P de plata, se rompe el ciclo.
                    }
                }
                //Calcula la cantidad de plata en bronce
                cantidad_Bronce += (int.Parse(plata) * 100);
            } //endif

            //Si contiene bronce, entonces...
            if (contieneBronce)
            {
                var bronce = ""; //Variable plata inicializada
                int indexBronce = cadena.IndexOf("b");

                //Recorro la cadena A PARTIR de la B.
                for (int i = indexBronce; i < cadena.Length; i++)
                {
                    int num; //Variable utilizable para el out del TryParse.
                    bool success = int.TryParse(cadena[i].ToString(), out num); //Consulto si se puede convertir a entero

                    if (success)
                    {
                        bronce += num; //Si se puede convertir a entero, coloco el valor en la variable como string
                    }
                    else
                    {
                        if (i > indexBronce) break; //En caso de que no, y no sea la misma B de bronce, se rompe el ciclo.
                    }
                }
                //Suma la cantidad de bronce
                cantidad_Bronce += (int.Parse(bronce));
            } //endif

            Console.WriteLine(cantidad_Bronce + " bronce.");
            Console.ReadKey();
        }
    }
}
