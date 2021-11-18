using System;

namespace restless
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a, b;
            Console.Write("Стипендия студента за месяц: ");
            a = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Расходы студента в первый месяц: ");
            b = Convert.ToDecimal(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                a += a;
                b += b * 1.03m;
            }
            Console.WriteLine($"{b - a:F2} рублей;"); 
            Console.ReadKey();
        }
    }
}
