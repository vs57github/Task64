using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");

            int n = int.Parse(Console.ReadLine());

            PrintNumbers(n);          
        }

        static void PrintNumbers(int n)  // Рекурсивная функция для вывода чисел от N до 1.
        {
            if (n == 0) return;

            Console.WriteLine(n);

            PrintNumbers(n - 1);   // Рекурсивный вызов функции. 
        }
    }
}
