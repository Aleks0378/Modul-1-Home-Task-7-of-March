using System;
/*
  Задание 3
Пользователь вводит с клавиатуры четыре цифры.
Необходимо создать число, содержащее эти цифры. На-
пример, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
сформировать число 1578.
*/

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            double number = 0;
            for (int i = 3; i >= 0; i--)
            {
                Console.Write("\nВведите число: ");
                str = Console.ReadLine();
                number += Int16.Parse(str) * Math.Pow(10, i);
            }
            Console.WriteLine($"\n Результат= {number}\n");
        }
    }
}
