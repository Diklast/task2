using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Конвертер температур");
            Console.WriteLine("1: Цельсий");
            Console.WriteLine("2: Фаренгейт");
            Console.WriteLine("3: Кельвин");

            Console.Write("Выберите исходную шкалу (1-3): ");
            int fromScale = Convert.ToInt32(Console.ReadLine());

            Console.Write("Выберите целевую шкалу (1-3): ");
            int toScale = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите температуру: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            double convertedTemperature = ConvertTemperature(temperature, fromScale, toScale);

            Console.WriteLine($"Конвертированная температура: {convertedTemperature} градусов");
        }

        static double ConvertTemperature(double temperature, int fromScale, int toScale)
        {
            double tempInCelsius;

            // Конвертация в Цельсий
            switch (fromScale)
            {
                case 1: // Цельсий
                    tempInCelsius = temperature;
                    break;
                case 2: // Фаренгейт
                    tempInCelsius = (temperature - 32) * 5 / 9;
                    break;
                case 3: // Кельвин
                    tempInCelsius = temperature - 273.15;
                    break;
                default:
                    throw new ArgumentException("Неверная шкала температур");
            }

            // Конвертация из Цельсия в целевую шкалу
            switch (toScale)
            {
                case 1: // Цельсий
                    return tempInCelsius;
                case 2: // Фаренгейт
                    return tempInCelsius * 9 / 5 + 32;
                case 3: // Кельвин
                    return tempInCelsius + 273.15;
                default:
                    throw new ArgumentException("Неверная целевая шкала температур");
            }
        }
    }
}
