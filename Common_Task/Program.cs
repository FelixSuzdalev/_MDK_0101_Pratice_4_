using System; 

class Program
{
    static void Main()
    {
        string a, b;
        Console.WriteLine("Программа сложения больших чисел (больше 10^9)\nВведите первое большое число:");
        a = Console.ReadLine();
        Console.WriteLine("Введите второе большое число:");
        b = Console.ReadLine();
        if (a.Length > 9 && b.Length > 9)
        {
            string sum = BigNumbers(a, b);
            Console.WriteLine($"Сумма чисел = {sum}");
        }
        else Console.WriteLine("Число меньше 10^9");
    }

    static string BigNumbers(string num1, string num2)
    {
        int maxDlina = Math.Max(num1.Length, num2.Length); 
        char[] rezultat = new char[maxDlina + 1]; 
        int perenos = 0; 

        for (int i = 0; i < maxDlina; i++)
        {
            int chislo1 = i < num1.Length ? num1[num1.Length - 1 - i] - '0' : 0; 
            int chislo2 = i < num2.Length ? num2[num2.Length - 1 - i] - '0' : 0; 

            int sum = chislo1 + chislo2 + perenos; 
            perenos = sum / 10;
            rezultat [maxDlina - i] = (char)('0' + sum % 10); 
        }

        if (perenos > 0)
        {
            rezultat [0] = (char)('0' + perenos); 
            return new string(rezultat); 
        }
        else
        {
            return new string(rezultat, 1, maxDlina); 
        }
    }
}
