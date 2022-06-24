// Задача №4

/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int a, b, c;

Console.Write("Insert first number =  ");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("Insert second number =  ");
b=Convert.ToInt32(Console.ReadLine());
Console.Write("Insert third number =  ");
c=Convert.ToInt32(Console.ReadLine());

if(a>b)
{
Console.WriteLine("max: " + a);
}
else if(b>c)
{
Console.WriteLine("max:" + b);
}
else if (c>a)
{
Console.WriteLine("max:" + c);
}

if(a==b)
{
Console.WriteLine("Identically: " + a);
}
else if(b==c)
{
Console.WriteLine("Identically: " + b);
}
else if (c==a)
{
Console.WriteLine("Identically: " + c);
}

