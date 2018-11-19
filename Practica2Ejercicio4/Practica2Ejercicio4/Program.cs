using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0, n3 = 0, p=0;

            Console.WriteLine("Ingrese la primera nota");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera nota");
            n3 = Convert.ToDouble(Console.ReadLine());

            p = (n1 + n2 + n3) / 3;

            if (p > 10)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                if (p > 7)
                {
                    Console.WriteLine("Desaprobado");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
                
            }
            Console.ReadLine();



        }
    }
}
