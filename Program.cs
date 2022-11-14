//************************
// практическая работа №7*
// выполнил: Ханов Артур *
//************************
using System;

namespace PR_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,z,v,c;//объявление переменных
            uint i ;
            ulong fact;
            Console.WriteLine("здравствуйте!");
            Console.Write("введите число x = ");
            x = Convert.ToDouble(Console.ReadLine());
            fact = 1;
            c = 0;


                for (i = 3; i <= 15; i += 2)// цикл для решения задачи
                {
                    fact = fact * (i - 1) * i;// расчет факториала
                    Console.WriteLine(fact);
                    z = Math.Pow(x, i);
                    Console.WriteLine($"факториал 1  {z}");
                    v = z / fact;
                    Console.WriteLine($"факториал 2  {v}");
                    c += v;
                }
            Console.WriteLine($"x равен  {c}");
            Console.ReadLine();
        }
    }
}
