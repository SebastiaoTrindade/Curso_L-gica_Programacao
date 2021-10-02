using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ClassMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(" ");

            Console.WriteLine("********************************************************");
            Console.WriteLine(" ");

            //Tornar mais intuitiva o programa
            Console.WriteLine("Valor máximo: " + Math.Max(5, 10));
            Console.WriteLine("Valor mínimo: " + Math.Min(5, 10));
            Console.WriteLine(" ");

            Console.WriteLine("********************************************************");
            Console.WriteLine(" ");

            //Raiz quadrada
            Console.WriteLine("Raiz quadrada: " + Math.Sqrt(64));
            Console.WriteLine(" ");

            Console.WriteLine("********************************************************");
            Console.WriteLine(" ");

            //Arredondamento
            Console.WriteLine("Arredondamento: " + Math.Round(9.99));

            Console.ReadKey();
        }
    }
}
