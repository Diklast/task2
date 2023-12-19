using System;

namespace AverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четыре числа для вычисления их среднего значения:");

            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите третье число: ");
            double number3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите четвертое число: ");
            double number4 = Convert.ToDouble(Console.ReadLine());

            double average = (number1 + number2 + number3 + number4) / 4;

            Console.WriteLine($"Среднее значение: {average}");
        }
    }
}
