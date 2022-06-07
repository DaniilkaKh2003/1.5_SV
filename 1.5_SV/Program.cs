using System;
namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            while (n != 0)
            {
                if (n % 10 > 7)
                {
                    a = a * (n % 10);
                }
                n /= 10;
            }
            if (a == 1) a = 0;
            Console.WriteLine($"Произведение цифр больших семи = {a}");
        }
    }
}
