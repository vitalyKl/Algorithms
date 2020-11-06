using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.HW1
{
    public static class QuadraticEquation
    {
        public static void FindRoots()
        {
            Console.WriteLine("Введите переменную \"a\"");
            double aNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите переменную \"b\"");
            double bNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите переменную \"c\"");
            double cNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Уравнение имеет вид: {aNumber}x^2 + {bNumber}x + {cNumber} = 0");

            double discriminant = Math.Pow(bNumber, 2) - (4 * aNumber * cNumber);

            double root1;
            double root2;

            if (discriminant > 0)
            {
                root1 = (-bNumber + Math.Sqrt(discriminant)) / 2 * aNumber;
                root2 = (-bNumber - Math.Sqrt(discriminant)) / 2 * aNumber;

                Console.WriteLine($"Уровнение имеет два корня: x1 = {root1}, x2 = {root2}");
            }
            else if (discriminant == 0)
            {
                root1 = -bNumber / 2 * aNumber;
                Console.WriteLine($"Уравнение имеет 1 корень: x1 = {root1}");
            }
            else
            {
                Console.WriteLine("Корней при действительных коэффициентах нет!");
            }
        }
    }
}
