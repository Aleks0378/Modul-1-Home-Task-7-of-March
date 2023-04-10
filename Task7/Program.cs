//Задание 7
//Пользователь вводит с клавиатуры два числа. Нужно
//показать все четные числа в указанном диапазоне. Если
//границы диапазона указаны неправильно требуется про-
//извести нормализацию границ. Например, пользователь
//ввел 20 и 11, требуется нормализация, после которой
//начало диапазона станет равно 11, а конец 20.

using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1= int.Parse(Console.ReadLine());
            Console.Write("\nEnter second number: ");
            int num2= int.Parse(Console.ReadLine());
            int max=num2, min=num1;
            if (num1 > num2) { max = num1;min = num2; }
            Console.WriteLine();
            for (int i = min; i < max; i++) 
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}