// Задача №8

/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. 
5 -> 2,4
8 -> 2, 4, 6, 8
*/

int n, current=0;

Console.Write("input a num ");
n = Convert.ToInt32(Console.ReadLine());

while(current <= n)
{
        if (current % 2 == 0) 
        Console.Write(current + " ");
        current++; 
}

//Второй вариант решения 
/*
int n, current=0;

Console.Write("input a number: ");
n = Convert.ToInt32(Console.ReadLine());


while(current <= n)
{
    Console.Write(current + " ");
    current+=2; 
}    
*/


