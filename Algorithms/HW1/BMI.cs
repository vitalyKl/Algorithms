using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithms.HW1
{
    public static class BMI
    {
        public static void CalculateBMI()
        {
            Console.WriteLine("Введите массу:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите рост в сантиметрах:");
            double height = Convert.ToDouble(Console.ReadLine())/100;

            double output = weight / Math.Pow(height, 2);

            Console.WriteLine($"ИМТ = {output}");
        }
    }
}
