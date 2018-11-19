using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Prolema2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo = 0, tiempo = 0, nuevoSueldo = 0, aumento = 0;

            Console.WriteLine("Introduzca el sueldo:");
            sueldo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el tiempo de antiguedad :");
            tiempo = Convert.ToInt32(Console.ReadLine());

            if ((sueldo < 500) & (tiempo > 10))
            {
                aumento = sueldo * 20 / 100;
                nuevoSueldo = sueldo + aumento;
                Console.WriteLine("El nuevo sueldo sera RD$" + nuevoSueldo);

            }
            else if ((sueldo < 500) & (tiempo < 10))

            {
                aumento = sueldo * 5 / 100;
                nuevoSueldo = sueldo + aumento;

                Console.WriteLine("El nuevo sueldo sera RD$" + nuevoSueldo);
            }
            else if (sueldo >=500)

            {
                
                Console.WriteLine("El  sueldo es RD$" + sueldo);
            }
            Console.ReadLine();


        }
    }
}
