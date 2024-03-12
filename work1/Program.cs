
// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Введите число!");
int number=Convert.ToInt32(Console.ReadLine());
if(number % 7==0 || number % 23==0){
    Console.WriteLine("Да");
}else{
    Console.WriteLine("Нет");
}