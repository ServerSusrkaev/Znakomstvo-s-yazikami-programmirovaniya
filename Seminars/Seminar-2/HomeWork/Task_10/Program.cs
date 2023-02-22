//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
//выходе показывает вторую цифру этого числа.

//bool value = true;
Console.WriteLine("Введите 3-х значное чило: ");
int number = int.Parse(Console.ReadLine());
if (number.ToString().Length == 3)
{
    //int number = int.Parse(Console.ReadLine());
    int result = number / 10;
    result = result % 10;
    Console.WriteLine(result % 10);
}
else
{
    Console.WriteLine("Введенное число не является 3-х значным");
}