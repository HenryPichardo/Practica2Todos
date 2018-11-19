using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, x = 1, valor = 0, pares = 0, impares = 0, positivos = 0, negativos = 0;

            Console.WriteLine("Cuantos numeros vas a introducir: ");

            n = Convert.ToInt32(Console.ReadLine());

            while (x <= n)
            {
                Console.WriteLine("Ingrese el valor " + x + ":");

                valor = Convert.ToInt32(Console.ReadLine());

                if (valor % 2 == 0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }
                if (valor > 0)
                {
                    positivos = positivos + 1;
                }
                else
                {
                    negativos = negativos + 1;

                }

                x = x + 1;

            }
            Console.WriteLine("Cantidad de pares = " + pares);
            Console.WriteLine("Canridad de impares = " + impares);
            Console.WriteLine("Cantidad de numeros positivos = " + positivos);
            Console.WriteLine("Canridad de numeros negativos = " + negativos);

            Console.ReadKey();


        }
    }
    
}
