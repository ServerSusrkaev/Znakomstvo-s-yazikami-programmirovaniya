//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число 
// квадратом другого.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a * a == b)
{
    Console.WriteLine("Число b является квадратом числа a");
}
else if (b * b == a)
{
    Console.WriteLine("Число a является квадратом числа b");
}
else
{
    Console.WriteLine("Числа не являются квадратами друг для друга");
}

