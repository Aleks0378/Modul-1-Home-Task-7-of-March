using System;
/*
  Задание 2
Пользователь вводит с клавиатуры два числа. Первое
число — это значение, второе число процент, который
необходимо посчитать. Например, мы ввели с клавиатуры
90 и 10. Требуется вывести на экран 10 процентов от 90.
Результат: 9.
*/


namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nВведите число: ");
            string numberString = Console.ReadLine();
            int number1 = Int16.Parse(numberString);
            Console.WriteLine($" Число: {number1}");
            Console.Write("\nВведите второе число-процент: ");
            numberString = Console.ReadLine();
            int number2 = Int16.Parse(numberString);
            Console.WriteLine($" Второе число: {number2} %");
            Console.WriteLine($"\n Результат: {number2}% от {number1} = {(number1 * number2) / 100}");
        }
    }
}
