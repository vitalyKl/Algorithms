using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.HW1
{
    public static class YearsOfHuman
    {

        public static void DefineWord()
        {
            Console.WriteLine("Введите возраст человека от 1 до 150");
            int age = Convert.ToInt32(Console.ReadLine());

            if ((age % 100 >= 11 && age % 100 <= 14) || age % 10 >= 5 || age % 10 == 0)
                Console.WriteLine($"{age} лет");
            else if (age % 10 == 1)
                Console.WriteLine($"{age} год");
            else if (age % 10 <= 4)
                Console.WriteLine($"{age} года");
        }
    }
}
