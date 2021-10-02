using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carros = { "Fusca", "Brasilia", "Ônix", "Volvo" };
            int[] numeros = { 0, 1, 2, 3 };

            Console.WriteLine(carros[3]);

            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);
            }

            Console.ReadKey();
        }
    }
}
