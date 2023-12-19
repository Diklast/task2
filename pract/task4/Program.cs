using System;

namespace FileNameFromPath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полный путь к файлу:");
            string filePath = Console.ReadLine();

            string fileName = ExtractFileName(filePath);

            Console.WriteLine($"Имя файла: {fileName}");
        }

        static string ExtractFileName(string filePath)
        {
            string[] pathParts = filePath.Split(new char[] { '\\', '/' });
            return pathParts[pathParts.Length - 1];
        }
    }
}
