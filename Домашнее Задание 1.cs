using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int newInt = 10;
            float newFloat = 8.4f;
            string newStr = "True";
            float bigInt = newInt * 3.5f;
            newFloat = newFloat - 1;
            string bigStr = "NoNoYesYesYes";
            string bigStr2 = newStr + "NoNoYesYesYes";
            Console.WriteLine($"newInt/newFloat - {newInt / newFloat}");
            Console.WriteLine($"bigInt/newFloat - {bigInt / newFloat}");
            Console.WriteLine($"newInt - {newInt}");
            Console.WriteLine($"newFloat - {newFloat}");
            Console.WriteLine($"newStr - {newStr}");
            Console.WriteLine($"bigInt - {bigInt}");
            Console.WriteLine($"bigStr - {bigStr}");
            Console.WriteLine($"bigStr2 - {bigStr2}");
            Console.ReadKey();
        }
    }
}
