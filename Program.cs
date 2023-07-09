using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Степень_двойки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minNumber = 0;
            int maxNumber = 100;
            int number = random.Next(minNumber, maxNumber + 1);
            int degree = 0;
            int result = 1;
            int factor = 2;

            while (result <= number)
            {
                result *= factor; ;
                degree++;
            }

            Console.WriteLine("Рандомное число: " + number);
            Console.WriteLine("Минимальная степень двойки, превосходящая рандомное число: " + degree);
            Console.WriteLine("Расчет примера: " + factor + " ^ " + degree + " = " + result);
        }
    }
}
