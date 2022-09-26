start1:
Console.ResetColor();
Console.Clear();
Console.WriteLine("Выберите какое действие хотите выполнить: ");
Console.WriteLine("1. Сложить 2 числа ");
Console.WriteLine("2. Вычесть первое из второго ");
Console.WriteLine("3. Перемножить два числа ");
Console.WriteLine("4. Разделить первое на второе ");
Console.WriteLine("5. Возвести первое число в степень из второго числа ");
Console.WriteLine("6. Найти квадратный корень из числа ");
Console.WriteLine("7. Найти 1 процент от числа ");
Console.WriteLine("8. Найти факториал из числа ");
Console.WriteLine("9. Выйти из программы ");
Console.ForegroundColor = ConsoleColor.Green;
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    Console.ResetColor();
    Console.WriteLine("Введите первое число: ");
    Console.ForegroundColor = ConsoleColor.Green;
    int b = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    Console.WriteLine("Введите второе число");
    Console.ForegroundColor = ConsoleColor.Green;
    int c = Convert.ToInt32(Console.ReadLine());
    if (c < 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(b + " + (" + c + ") = " + b + " - " + (c * -1) + " = " + (b + c));
        goto start;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(b + " + " + c + " = " + (b + c));
        goto start;
    }
}
if (a == 2)
{
    Console.ResetColor();
    Console.WriteLine("Введите первое число: ");
    Console.ForegroundColor = ConsoleColor.Green;
    int b = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    Console.WriteLine("Введите второе число");
    Console.ForegroundColor = ConsoleColor.Green;
    int c = Convert.ToInt32(Console.ReadLine());
    if (c < 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(b + " - (" + c + ") = " + b + " + " + (c * -1) + " = " + (b - c));
        goto start;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(b + " - " + c + " = " + (b - c));
        goto start;
    }
}
if (a == 3)
{
    Console.ResetColor();
    Console.WriteLine("Введите первое число: ");
    Console.ForegroundColor = ConsoleColor.Green;
    int b = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    Console.WriteLine("Введите второе число");
    Console.ForegroundColor = ConsoleColor.Green;
    int c = Convert.ToInt32(Console.ReadLine());
    if (c < 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(b + " * (" + c + ") = " + (b * c));
        goto start;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(b + " * " + c + " = " + (b * c));
        goto start;
    }
}
if (a == 4)
{
    Console.ResetColor();
    Console.WriteLine("Введите первое число: ");
    Console.ForegroundColor = ConsoleColor.Green;
    double b = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();
    Console.WriteLine("Введите второе число");
    Console.ForegroundColor = ConsoleColor.Green;
    double c = Convert.ToDouble(Console.ReadLine());
    if (c == 0)
    {
        goto finish1;
    }
    if (c < 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(b + " / (" + c + ") = " + (b / c));
        goto start;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(b + " / " + c + " = " + (b / c));
        goto start;
    }
}
if (a == 5)
{
    Console.ResetColor();
    Console.WriteLine("Введите первое число: ");
    Console.ForegroundColor = ConsoleColor.Green;
    int b = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    Console.WriteLine("Введите второе число");
    Console.ForegroundColor = ConsoleColor.Green;
    int c = Convert.ToInt32(Console.ReadLine());
    if (c < 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(b + " ^ (" + c + ") = " + (Math.Pow(b, c)));
        goto start;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(b + " ^ " + c + " = " + (Math.Pow(b, c)));
        goto start;
    }
}
if (a == 6)
{
    Console.ResetColor();
    Console.WriteLine("Введите число: ");
    Console.ForegroundColor = ConsoleColor.Green;
    int b = Convert.ToInt32(Console.ReadLine());
    if (b < 0)
    {
        goto finish3;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Квадратный корень из " + b + " = " + (Math.Sqrt(b)));
        goto start;
    }
}
if (a == 7)
{
    Console.ResetColor();
    Console.WriteLine("Введите число: ");
    Console.ForegroundColor = ConsoleColor.Green;
    double b = Convert.ToDouble(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("1% числа " + b + " = " + (b / 100));
    goto start;
}
if (a == 8)
{
    Console.ResetColor();
    Console.WriteLine("Введите число: ");
    Console.ForegroundColor = ConsoleColor.Green;
    int b = Convert.ToInt32(Console.ReadLine());
    if (b < 1)
    {
        goto finish3;
    }
    else
    {
        int d = b;
        int c = b;
        while (a > 1)
        {
            b = b * (c - 1);
            c--;
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(d + "! = " + b);
        goto start;
    }
}
if (a == 9)
{
    Environment.Exit(0);
}
else
{
    goto finish;
}
start:
Console.ResetColor();
Console.WriteLine("Выберите действие еще раз: ");
Console.ForegroundColor = ConsoleColor.Green;
int k = Convert.ToInt32(Console.ReadLine());
do
{

    if (k == 1)
    {
        Console.ResetColor();
        Console.WriteLine("Введите первое число: ");
        Console.ForegroundColor = ConsoleColor.Green;
        int b = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();
        Console.WriteLine("Введите второе число");
        Console.ForegroundColor = ConsoleColor.Green;
        int c = Convert.ToInt32(Console.ReadLine());
        if (c < 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(b + " + (" + c + ") = " + b + " - " + (c * -1) + " = " + (b + c));
            goto start;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(b + " + " + c + " = " + (b + c));
            goto start;
        }
    }
    if (k == 2)
    {
        Console.ResetColor();
        Console.WriteLine("Введите первое число: ");
        Console.ForegroundColor = ConsoleColor.Green;
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        Console.ForegroundColor = ConsoleColor.Green;
        int c = Convert.ToInt32(Console.ReadLine());
        if (c < 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(b + " - (" + c + ") = " + b + " + " + (c * -1) + " = " + (b - c));
            goto start;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(b + " - " + c + " = " + (b - c));
            goto start;
        }
    }
    if (k == 3)
    {
        Console.ResetColor();
        Console.WriteLine("Введите первое число: ");
        Console.ForegroundColor = ConsoleColor.Green;
        int b = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();
        Console.WriteLine("Введите второе число");
        Console.ForegroundColor = ConsoleColor.Green;
        int c = Convert.ToInt32(Console.ReadLine());
        if (c < 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(b + " * (" + c + ") = " + (b * c));
            goto start;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(b + " * " + c + " = " + (b * c));
            goto start;
        }
    }
    if (k == 4)
    {
        Console.ResetColor();
        Console.WriteLine("Введите первое число: ");
        Console.ForegroundColor = ConsoleColor.Green;
        double b = Convert.ToDouble(Console.ReadLine());
        Console.ResetColor();
        Console.WriteLine("Введите второе число");
        Console.ForegroundColor = ConsoleColor.Green;
        double c = Convert.ToDouble(Console.ReadLine());
        if (c == 0)
        {
            goto finish1;
        }
        if (c < 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(b + " / (" + c + ") = " + (b / c));
            goto start;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(b + " / " + c + " = " + (b / c));
            goto start;
        }
    }
    if (k == 5)
    {
        Console.ResetColor();
        Console.WriteLine("Введите первое число: ");
        Console.ForegroundColor = ConsoleColor.Green;
        int b = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();
        Console.WriteLine("Введите второе число");
        Console.ForegroundColor = ConsoleColor.Green;
        int c = Convert.ToInt32(Console.ReadLine());
        if (c < 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(b + " ^ (" + c + ") = " + (Math.Pow(b, c)));
            goto start;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(b + " ^ " + c + " = " + (Math.Pow(b, c)));
            goto start;
        }
    }
    if (k == 6)
    {
        Console.ResetColor();
        Console.WriteLine("Введите число: ");
        Console.ForegroundColor = ConsoleColor.Green;
        double b = Convert.ToDouble(Console.ReadLine());
        if (b < 0)
        {
            goto finish3;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Квадратный корень из " + b + " = " + (Math.Sqrt(b)));
            goto start;
        }
    }
    if (k == 7)
    {
        Console.ResetColor();
        Console.WriteLine("Введите число: ");
        Console.ForegroundColor = ConsoleColor.Green;
        double b = Convert.ToDouble(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("1% числа " + b + " = " + (b / 100));
        goto start;
    }
    if (k == 8)
    {
        Console.ResetColor();
        Console.WriteLine("Введите число: ");
        Console.ForegroundColor = ConsoleColor.Green;
        int b = Convert.ToInt32(Console.ReadLine());
        if (b < 1)
        {
            goto finish3;
        }
        else
        {
            int d = b;
            int c = b;
            while (a > 1)
            {
                b = b * (c - 1);
                c--;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(d + "! = " + b);
            goto start;
        }
    }
    if (k == 9)
    {
        Environment.Exit(0);
    }
    else
    {
        goto finish;
    }
} while (k != 9);
finish:
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Вы выбрали неправильное дейстивие, попробуйте снова...");
Thread.Sleep(5000);
goto start1;
finish1:
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("На 0 делить нельзя, попробуйте повторить действие и ввести другие значения...");
Thread.Sleep(5000);
goto start1;
finish3:
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Вы ввели неккоректное значение, попробуйте повторить действие и ввести другое значение");
Thread.Sleep(5000);
goto start1;