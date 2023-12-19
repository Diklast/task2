using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество уровней пирамиды: ");
            int levels = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= levels; i++)
            {
                // Печать пробелов для выравнивания
                Console.Write(new string(' ', levels - i));

                // Печать чисел для каждого уровня
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
