string again = "д";
while (again == "д")
{
    double a;
    double b;
    double total;
    char oper;

    Console.WriteLine("Введите 1 число");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите оператор");
    oper = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Введите 2 число");
    b = Convert.ToDouble(Console.ReadLine());

    if (oper == '+')
    {
        total = a + b;
        Console.WriteLine("Сумма " + a + " и " + b + " равна " + total + ".");
    }

    else if (oper == '-')
    {
        total = a - b;
        Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
    }

    else if (oper == '*')
    {
        total = a * b;
        Console.WriteLine("Умножение " + a + " и " + b + " равно " + total + ".");
    }

    else if (oper == '/')
    {
        total = a / b;
        Console.WriteLine("Деление " + a + " и " + b + " равно " + total + ".");
    }

    else if (oper == '%')
    {
        total = a % b;
        Console.WriteLine("Остаток " + a + " и " + b + " равен " + total + ".");
    }

    else
    {
        Console.WriteLine("Неизвестный оператор");
    }
    Console.WriteLine("Нажмите (д) если хотите продолжить работу в калькуляторе.");
    again = Convert.ToString(Console.ReadLine());

}