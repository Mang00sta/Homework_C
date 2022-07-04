//! Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//14212 -> нет
//12821 -> да
//23432 -> да

//*
void Polindrom(int n)
{
    int i=0;
    int j=0;
    for (j=0; j<=i/2; j++)
        for (i=0; i<=i-1; i--)
            if (j!=i-1)
            {
                Console.WriteLine("No");
            }
}
Console.WriteLine("Insert n "  );
int num = Convert.ToInt32(Console.ReadLine());

Polindrom(num);
//Console.ReadKey();
//Console.Clear();
//*/


//! Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*
void CubeN(int n)
{
     for (int i=0; i<n; i++)
    {
        Console.Write(i*i*i + "\t");
    }
} 

Console.WriteLine("Insert n "  );
int num = Convert.ToInt32(Console.ReadLine());

CubeN(num);

Console.ReadKey();
Console.Clear();
//*/