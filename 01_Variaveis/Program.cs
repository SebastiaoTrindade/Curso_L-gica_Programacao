using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 42;
            string nome = "Sebastiao Trindade";

            Console.WriteLine(idade);
            Console.WriteLine(nome);
            Console.WriteLine("Me chamo " + nome + " e tenho " + idade + " anos.");
            Console.ReadKey();
        }
    }
}
