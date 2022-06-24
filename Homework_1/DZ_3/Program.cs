// Задача №6
/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). 
4 -> да
-3 -> нет
7 -> нет
*/

int number;

Console.Write("Insert number: ");
number=Convert.ToInt32(Console.ReadLine());


if (number%2==0)
{
    Console.WriteLine("An even number ");
}
else 
{
    Console.WriteLine("Odd number");
}

