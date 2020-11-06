using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.HW1
{
    public static class TimeOfYear
    {
        public static void DefineTime()
        {
            Console.WriteLine("Введите номер месяца от 1 до 12");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            if (monthNumber < 3 || monthNumber == 12)
            {
                Console.WriteLine($"Месяц под номером {monthNumber} относится к зиме!");
            }
            else if (monthNumber >= 3 && monthNumber < 6)
            {
                Console.WriteLine($"Месяц под номером {monthNumber} относится к весне!");
            }
            else if (monthNumber >= 6 && monthNumber < 9)
            {
                Console.WriteLine($"Месяц под номером {monthNumber} относится к лету!");
            }
            else if (monthNumber >= 9 && monthNumber < 12)
            {
                Console.WriteLine($"Месяц под номером {monthNumber} относится к осени!");
            }
        }
    }
}
