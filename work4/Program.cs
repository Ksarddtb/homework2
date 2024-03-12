// See https://aka.ms/new-console-template for more information
//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.


Console.WriteLine("Введите число!");
int number=Convert.ToInt32(Console.ReadLine());

if(number > 1){
    int i=1;
    string result="";
    while(i < number){
        int num1=number/i;    
        result=num1%10+","+result;
        i=i*10;
    }
 Console.WriteLine(result);
}