using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Semana_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcion;

            do
            {
                Console.Write("Ingrese una opción 1/2/3: ");
                opcion = char.Parse(Console.ReadLine());
                Console.WriteLine();

                
            }
            while (!(opcion == '1' || opcion == '2' || opcion == '3'));

            if (opcion == '1')
            {
                Console.WriteLine("Acaba de indicar la opción: "+ "Calcular Suma");
            }
            else
            {
                if (opcion == '2')
                {
                    Console.WriteLine("Acaba de indicar la opción: " + "Calcular Resta");
                }
                else
                {
                    if (opcion == '3')
                    {
                        Console.WriteLine("Acaba de indicar la opción: " + "Salir");
                    }
                }
            }
            Console.WriteLine("");
            Console.Write("Pulse una tecla");
            Console.ReadKey();

        }
    }
}
