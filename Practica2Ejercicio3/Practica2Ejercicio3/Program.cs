using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0, x=1, valor=0, pares=0, impares=0;

            Console.WriteLine("Cual es el valor de n o cuantos numeros vas a introducir: ");

            n = Convert.ToInt32(Console.ReadLine());

             while (x <= n)
            {
                Console.WriteLine("Ingrese el valor "+x+":");

                valor = Convert.ToInt32(Console.ReadLine());

                if (valor % 2 == 0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }
                x = x + 1;

             }
            Console.WriteLine("Cantidad de pares" + pares);
            Console.WriteLine("Canridad de impares" + impares);

            Console.ReadKey();


        }
    }
}
