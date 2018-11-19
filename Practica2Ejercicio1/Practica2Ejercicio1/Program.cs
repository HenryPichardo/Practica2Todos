using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float sueldo;
            
            Console.WriteLine("Ingrese el sueldo");
            sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }

            Console.ReadKey();


        }
    }
}
