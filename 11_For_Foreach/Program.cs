using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_For_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            string[] carros = { "Fusca", "Brasilia", "Variant" };

            foreach (string y in carros)
            {
                Console.WriteLine(y);
            }

            Console.ReadKey();
        }
    }
}
