using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, contador = 0, nota=0;
            double promedio;
            Console.WriteLine("PARA FINALIZAR DIGITE -1");
            Console.WriteLine("Ingresar nota: ");
           
            while(nota != -1)
            {
                nota=int.Parse(Console.ReadLine());
                if (nota != -1)
                {
                    suma = suma + nota;
                    contador++;
                }
            }

            promedio = suma / contador;
            Console.WriteLine("La suma es: {0} ", suma);
            Console.WriteLine("Usted ingresó {0} notas", contador);
            Console.WriteLine("Promedio de notas: {0}", promedio);
        }
    }
}
 