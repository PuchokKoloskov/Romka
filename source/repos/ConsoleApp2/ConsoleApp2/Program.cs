using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Задание 10.2.3");

            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (N >= 1)
            {
                if (N % 2 != 0)
                {
                    count++;
                }
                N = N / 2;
            }

            Console.Write("Разрядность числа N: ");
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}

