// Задача №1
/* 
Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее. 
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int a, b;

Console.Write("Insert first number =  ");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("Insert second number =  ");
b=Convert.ToInt32(Console.ReadLine());


if(a==b)
{
        Console.Write("Identically");
        System.Environment.Exit(0);
} 

if(a>b) 
{
Console.WriteLine("max:" + a);
Console.Write("min:" + b);
}
else
{
Console.WriteLine("max:" + b);
Console.Write("min:" + a);
}

