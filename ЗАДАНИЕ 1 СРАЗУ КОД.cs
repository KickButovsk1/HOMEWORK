using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChyProgect
{
    public class Program
    {
        
        private static void Main()
        {
           
            char firstNumber = Convert.ToChar(Console.ReadLine());
            int result = Convert.ToInt32(firstNumber);
            Console.WriteLine(result);
            Console.WriteLine($"Введеный символ -  {firstNumber}");
            bool resDigit = Char.IsDigit(firstNumber);
            bool resLetter = Char.IsLetter(firstNumber);
            bool resLower = Char.IsLower(firstNumber);
            bool resUpper = Char.IsUpper(firstNumber);
            bool resPunctuation = Char.IsPunctuation(firstNumber);
            bool resWhiteSpace = Char.IsWhiteSpace(firstNumber);
            bool resControl = Char.IsControl(firstNumber);
            if (resDigit == true)
            {
                Console.WriteLine($"Число входит в промежуток от 0 до 9");
            }
            if (resLower == true && resLetter == true)
            {
                Console.WriteLine($"Это символ из категории букв и в нижнем регистре");
            }
            if (resUpper == true && resLetter == true)
            {
                Console.WriteLine($"Это символ из категории букв и в верхнем регистре");
            }
            if (resPunctuation == true)
            {
                Console.WriteLine($"Это символ из категории знаков препинания");
            }
            if (resWhiteSpace == true)
            {
                Console.WriteLine($"Это символ из категории пробельных");
            }
            if (resControl == true)
            {
                Console.WriteLine($"Это символ из категории управляющих символов");
            }


            Console.ReadKey();

        }

    }
}
