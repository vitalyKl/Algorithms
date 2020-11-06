using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.HW1
{
    public static class FourNumbers
    {
        public static void  FindMax()
        {
            Console.WriteLine("Введите первое число:");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            int third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите четвёртое число:");
            int fourth = Convert.ToInt32(Console.ReadLine());

            int max = first;

            if (max < second)
            {
                max = second;
            }
            if (max < third)
            {
                max = third;
            }
            if (max < fourth)
            {
                max = fourth;
            }

            Console.WriteLine($"Максимальное число: {max}");
        }
    }
}
