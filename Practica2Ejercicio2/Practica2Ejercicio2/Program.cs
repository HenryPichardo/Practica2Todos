using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Introduzca el primer numero:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El primer numero es el mayor de los dos___"+"("+num1+")");
            }
            else
            {
                Console.WriteLine("El segundo numero es el mayor de los dos___"+"("+num2+")");
            }
            Console.ReadLine();
            

        }
    }
}
