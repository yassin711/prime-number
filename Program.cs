using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter n2: ");
            int n2 = int.Parse(Console.ReadLine());


            for (int i = n1; i <= n2; i++)
            {
              
                if (i == 2)
                {
                    Console.WriteLine(i);
                }
                for (int j = 2; j < i ; j++)
                {
                    if (i % j == 0)

                    {
                        break;
                    }

                    if (j == i -1 )
                    {
                        Console.WriteLine(i);
                    }

                }


            }
            Console.ReadKey();
        }
    }
}
