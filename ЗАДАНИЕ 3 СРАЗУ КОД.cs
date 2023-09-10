using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            int dva, tri, ch;
            bool kishlak = Int32.TryParse(first, out dva);
            if (kishlak == true)

            {
                tri = dva + 1;
                ch = dva - 1;
                Console.WriteLine($"The next number for the number {dva} is {tri}." + $"The previous number for the number {dva} is {ch}.");
            }
            else
            {
                Console.WriteLine("Это не число.");
            }
            Console.ReadKey();
        }
    }
}
