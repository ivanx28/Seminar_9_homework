//  Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string number (int m, int n)
{
   return m == n ? n.ToString(): m.ToString() + " " + number(m += 1, n);
}

Console.WriteLine("Введите первое число:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа от первого до второго числа: {number(numberM, numberN)}");
