﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaSemana = 0;

            Console.Write("Digite o valor: ");
            diaSemana = Convert.ToInt32(Console.ReadLine());

            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;

                case 2:
                    Console.WriteLine("Segunda - Feira");
                    break;

                case 3:
                    Console.WriteLine("Terça - Feira");
                    break;

                case 4:
                    Console.WriteLine("Quarta - Feira");
                    break;

                case 5:
                    Console.WriteLine("Quinta - Feira");
                    break;

                case 6:
                    Console.WriteLine("Sexta - Feira");
                    break;

                case 7:
                    Console.WriteLine("Sábado");
                    break;

                default:
                    Console.WriteLine("Valor incorreto!");
                    break;
            }
        }
    }
}
