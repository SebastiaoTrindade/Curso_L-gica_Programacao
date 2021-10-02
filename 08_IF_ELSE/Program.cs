using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 0;

            Console.Write("Que horas são? ");
            time = Convert.ToInt32(Console.ReadLine());

            if (time < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if(time < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
           
        }
    }
}
