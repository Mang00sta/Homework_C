//!Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом. 
//N = 4532 -> 4

int NumDigi(int n)
{
    int count = 1;
    if (n!=0)
    {
    if (n / 10 != 0)
      count+= NumDigi(n / 10);
    }
    return count;
}
Console.WriteLine(NumDigi(851)); 

//!Задача 66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120 
//M = 4; N = 8. -> 30

int SumofDigi (int m, int n)
{   
    if (n > m) 
    {
    return n + SumofDigi(m,n-1);
    }
    return n;
}
Console.WriteLine(SumofDigi(4,8));
