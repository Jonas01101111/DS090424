using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string req;
            double valor, total;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("O que será comprado:");
                Console.ResetColor();
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Quanto será gasto:");
                Console.ResetColor();
                valor = double.Parse(Console.ReadLine());
                total = +valor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("DESEJA CONTINUAR? S/N");
                Console.ResetColor();
                req = Console.ReadLine().ToUpper();
            }
            while (req == "S");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Valor total:"+total.ToString("C"));
            Console.ResetColor();  
            Console.ReadKey();
        }
    }
}
