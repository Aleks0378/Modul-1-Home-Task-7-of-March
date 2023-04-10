using System;
/*Задание 1
Пользователь вводит с клавиатуры число в диапа-
зоне от 1 до 100. Если число кратно 3 (делится на 3 без
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
вывести само число.
Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке.*/

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("\nВведите целое число от 1 до 100: ");
            string numberString = Console.ReadLine();
            int number = Int16.Parse(numberString);

            if (number < 1 || number > 100)
                Console.WriteLine($"\nОшибка!!! Число за пределами диапазона от 1 до 100 \n");
            else if (number % 3 == 0 & number % 5 == 0)
                Console.WriteLine("\n Fizz Buzz\n");
            else if (number % 3 == 0)
                Console.Write("\nFizz\n");
            else if (number % 5 == 0)
                Console.WriteLine("\nBuzz\n");
            else
                Console.Write($"\n Число: {number}\n");
        }
    }
}