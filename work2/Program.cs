// See https://aka.ms/new-console-template for more information
Console.WriteLine("Программа определание четверти по координатам!");

int x = 0;
int y = 0;

Console.WriteLine("Введите X координаты:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y координаты:");
y = Convert.ToInt32(Console.ReadLine());

if (x==0 && y==0){
    Console.WriteLine("Не правильное значение");
}
if (x > 0 && y > 0)
{
    Console.WriteLine("1 Четверт");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("2 Четверт");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("3 Четверт");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("4 Четверт");
}