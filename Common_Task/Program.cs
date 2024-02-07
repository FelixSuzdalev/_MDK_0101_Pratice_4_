//ghd
using System;
namespace Common_Task
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                long a, b, c;
                Console.WriteLine("Программа сложения больших чисел (больше 10^9)\nВведите первое большое число:");
                a = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Введите второе большое число:");
                b = Convert.ToInt64(Console.ReadLine());
                double p = Math.Pow(10, 9);
                if (a > p && b > p)
                {
                    c = a + b;
                    Console.WriteLine("Сумма = {0}", c);
                }
                else Console.WriteLine("Числа меньше 10^9");
            }
            catch (OverflowException е)
            {
                Console.WriteLine("Exception: " + е.Message);
            }
            finally 
            {
                Console.WriteLine("Подсчет окончен успешно");
                Console.Write("\nНажмите Enter для продолжения работы программы");
                while (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.ReadKey();
                    Main();
                };
            }
        }  
    }
}
