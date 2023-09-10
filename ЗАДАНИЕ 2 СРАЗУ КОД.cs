using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string solo = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Вы ввели - {solo}");
            char solos;
            bool soloss = char.TryParse(solo, out solos);
            if (soloss == true)
            {
                Console.WriteLine($"Вы ввели символ");
            }
            int s;
            bool solosss = Int32.TryParse(solo, out s);
            if (solosss == true)
            {
                Console.WriteLine($"У вас есть целое число.");
            }
            double kishlak;
            bool kishlakl = Double.TryParse(solo,out kishlak);
            if (kishlakl == true)
            {
                Console.WriteLine($"У вас есть дробное число");
            }
            bool z;
            bool zz = Boolean.TryParse(solo,out z);
            if (zz == true)
            {
                Console.WriteLine($"У вас есть логическое значение");
            }
            Console.ReadKey();
        }
    }
}
