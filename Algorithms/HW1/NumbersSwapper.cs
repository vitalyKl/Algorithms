using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.HW1
{
    public static class NumbersSwapper
    {
        public static void SwapNumberWithThird()
        {
            Console.WriteLine("Введите число \"a\":");
            int aNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число \"b\":");
            int bNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Число \"a\" было {aNumber}, число \"b\" было {bNumber}");

            int cNumber = aNumber;
            aNumber = bNumber;
            bNumber = cNumber;

            Console.WriteLine($"Число \"a\" стало: {aNumber}, число \"b\" стало: {bNumber}");
        }

        public static void SwapNumbersWithoutThird()
        {
            Console.WriteLine("Введите число \"a\":");
            int aNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число \"b\":");
            int bNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Число \"a\" было {aNumber}, число \"b\" было {bNumber}");

            aNumber += bNumber;

            bNumber = aNumber - bNumber;
            aNumber = aNumber - bNumber;

            Console.WriteLine($"Число \"a\" стало: {aNumber}, число \"b\" стало: {bNumber}");
        }
    }
}
