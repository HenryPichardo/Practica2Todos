using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 0, numCuenta = 0, totalAcreedores = 0;

            string status = "";
            while (numCuenta >=0)
            {
                Console.WriteLine("Ingrese el numerode cuenta");
                numCuenta = Convert.ToInt32(Console.ReadLine());
                             
                Console.WriteLine("Ingrese el balance actual");
                balance = Convert.ToInt32(Console.ReadLine());

                if (balance > 0)
                {
                    totalAcreedores = balance + totalAcreedores;
                    status = "Acreedor";
                }
                else if (balance < 0)
                {
                    status = "Deudor";
                }
                else if (balance == 0)
                {
                    status = "Nulo";
                }
            }
            Console.WriteLine("NUMERO DE CUENTA: "+numCuenta+" ESTADO DE LA CUENTA = "+status);
            Console.WriteLine("SUMA TOTAL DE SALDO DE ACREEDORES = "+totalAcreedores);
            
            Console.ReadKey();


        }
    }
}
