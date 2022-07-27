// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Sum (int m, int n, int amount)
{
    if (m > n)
    {
        return amount;
    }
    amount = amount + (m++);
    return Sum(m, n, amount);
}

Console.WriteLine("Введите первое число:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма всех натуральных чисел в промежутке от первого до второго числа равняется: {Sum(numberM, numberN, 0)}");