using System;
using System.Linq;

namespace ArrayMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы первого массива через пробел:");
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Введите элементы второго массива через пробел:");
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (array1.Length != array2.Length)
            {
                Console.WriteLine("Массивы разной длины. Невозможно выполнить умножение.");
                return;
            }

            int[] productArray = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                productArray[i] = array1[i] * array2[i];
            }

            Console.WriteLine("Результат умножения массивов:");
            Console.WriteLine(string.Join(" ", productArray));
        }
    }
}
