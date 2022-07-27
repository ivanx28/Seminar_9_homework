// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

double AckermannFunction(double m, double n)            // Тип double, так как значение функции Аккермана может быть очень большое.
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AckermannFunction(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    } 
    else return n + 1;
}

Console.WriteLine("Введите первое число:");
double numberM = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число:");
double numberN = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Значение функции Аккермана для введённых чисел равняется: {AckermannFunction(numberM, numberN)}");