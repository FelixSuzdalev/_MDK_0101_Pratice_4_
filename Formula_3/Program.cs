using System;
namespace Formula_3
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите начало отрезка a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите конец отрезка b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите шаг h: ");
                double h = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Значения функции F(x) на отрезке [a, b] с шагом h:");

                for (double x = a; x <= b; x += h)
                {
                    double res = 7 * Math.Pow(Math.Sin(x), 2) - 1/(2*x) * Math.Cos (x) ;
                    Console.WriteLine($"F({x}) = {res:f2}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
