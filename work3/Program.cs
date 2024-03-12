// See https://aka.ms/new-console-template for more information
//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = 0;
Console.WriteLine("Введите число из отрезка [10, 99]");
number = Convert.ToInt32(Console.ReadLine());
if (number < 10 && number > 99)
{
    Console.WriteLine("Не соотвествует деапозону  [10, 99]");
}
else
{
    int num1 = number / 10;
    int num2 = number % 10;
    if (num1 > num2)
    {
        Console.WriteLine(num1 + " больше");
    }
    else
    {
        Console.WriteLine(num2 + " больше");
    }
}
