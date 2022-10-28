using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Entrer un nbre:");
            n = int.Parse(Console.ReadLine());
            if (n == 0 || n == 1)
            {
                Console.WriteLine(n + "n'est pas un nbre premier");
                Console.ReadLine();
            }
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(n + "n'est pas un nbre premier");
                        Console.ReadLine();
                    }
                }
            }
            Console.WriteLine(n + "est  un nbre premier");
            Console.ReadLine();
        }
    }
}
