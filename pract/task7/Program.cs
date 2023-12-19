using System;

namespace MaxMinFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Введите пять чисел:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxNumber = numbers[0];
            int minNumber = numbers[0];

            foreach (int number in numbers)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }

                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            Console.WriteLine($"Максимальное число: {maxNumber}");
            Console.WriteLine($"Минимальное число: {minNumber}");
        }
    }
}
