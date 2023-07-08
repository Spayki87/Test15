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

            int namber = random.Next(0, 100);
            int degree = 0;
            int result = 1;

            while (result <= namber)
            {
                result *= 2;
                degree++;
            }

            Console.WriteLine("Рандомное число - " + namber);
            Console.WriteLine("Минимальная степень двойки, превосходящая рандомное число - " + degree);
            Console.WriteLine("Расчет примераж: 2 ^ " + degree + " = " + result);
        }
    }
}
