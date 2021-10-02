using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "ABCDEFGHIJKLMNOP";
            Console.WriteLine(texto.Length);

            Console.WriteLine(" ");
            Console.Write("**************** Concatenação ****************");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            string nome = "Paula ";
            string sobrenome = "Toller";

            Console.WriteLine(string.Concat(nome, sobrenome));

            Console.WriteLine(" ");
            Console.Write("**************** Interpolação ****************");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            string nome2 = "Sebastiao ";
            string sobrenome2 = "Trindade";

            Console.WriteLine($"{nome} {sobrenome}");

            Console.WriteLine(" ");
            Console.Write("**************** Mostrando o índice ****************");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            string nome3 = "Jose ";
            Console.WriteLine(nome3[0]);

            Console.WriteLine(" ");
            Console.Write("**************** Posição do índice ****************");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            string nome4 = "Joao";
            Console.WriteLine(nome4.IndexOf("a"));


        }
    }
}
