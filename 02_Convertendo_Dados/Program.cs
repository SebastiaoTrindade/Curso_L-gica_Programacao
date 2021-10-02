using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Convertendo_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            int meuInteiro = 10;
            double meuDouble = 5.25;
            bool meuBool = true;

            Console.WriteLine(Convert.ToString(meuInteiro));
            Console.WriteLine(Convert.ToDouble(meuDouble));
            Console.WriteLine(Convert.ToInt32(meuDouble));

        }
    }
}
