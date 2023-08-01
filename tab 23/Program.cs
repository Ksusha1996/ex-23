//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8 

using System;

namespace CubeTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод числа N
            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());

            // Вывод таблицы кубов чисел от 1 до N
            Console.WriteLine("Таблица кубов чисел:");
            for (int i = 1; i <= n; i++)
            {
                int cube = i * i * i;
                Console.WriteLine($"{i}^3 = {cube}");
            }
        }
    }
}


