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
                string a, b, c = "";
                Console.WriteLine("Программа сложения больших чисел (больше 10^9)\nВведите первое большое число:");
                a = Console.ReadLine();
                Console.WriteLine("Введите второе большое число:");
                b = Console.ReadLine();
                int maxLength = Math.Max(a.Length, b.Length);
                int perenos = 0;
                char[] result = new char[maxLength + 1];
                for (int i = 0; i < maxLength; i++) 
                {
                    int res1 = i < a.Length ? a[a.Length - 1 - i] - '0' : 0; 
                    int res2 = i < b.Length ? a[a.Length - 1 - i] - '0' : 0; 

                    int sum = res1 + res2 + perenos; 
                    perenos = sum / 10; // Определяем новый перенос
                    result[maxLength - i] = (char)('0' + sum % 10); // Записываем сумму в массив результата
                }
                
                Console.WriteLine("Сумма = {0}", result);
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
