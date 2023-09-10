using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет создатель, как тебя зовут?");
            string answeruser = Console.ReadLine();

            Console.WriteLine("А как ты назовешь меня?");
            string namebot = Console.ReadLine();
            Console.WriteLine($"Приятно познакомиться {answeruser}. Меня зовут {namebot} - это ты меня так назвал.");
            Console.ReadKey();
        }
    }
}
