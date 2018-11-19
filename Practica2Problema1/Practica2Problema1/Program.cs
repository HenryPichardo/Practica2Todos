using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            
            while (n < 200)
            {               
                if ( n % 3 == 0)
                {
                    Console.WriteLine(n);
                }
                n = n + 1;                
            }         

            Console.ReadKey();

        }
    }
}
