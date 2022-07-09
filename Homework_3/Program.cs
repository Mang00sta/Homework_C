//! Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//14212 -> нет
//12821 -> да
//23432 -> да
/*
void Polindrom(int num)
 {  
    int temp = num, sum=0, rem=0; // ввели переменные
    for (; temp>sum; ) // нужно было while, no я решил через for попробовать.  
        {                       // 75457
            rem = num % 10;  // нашли последнее число 7-5-4-5-4-7
            num = num / 10;  // нашли остальное число 7545-754-75-7
            sum = sum * 10 + rem;  // нашли число в обратном порядке .... 7-75-754-7545-75457 
        }
    if (temp == sum) Console.WriteLine (" Number is Palindrome" ); // сравнили с исходным 
    if (temp != sum) Console.WriteLine (" NO " ); // неравен с исходным
}

Console.WriteLine("Insert n "  );
int n = Convert.ToInt32(Console.ReadLine());

Polindrom(n);

Console.ReadKey();
Console.Clear();
/*/

//! Решение через string не удалось в виду малых знаний написания кода. Хотелось бы быстро разобрать такой вариант решения на семинаре. 

/*
string s = "123456"; //не удалось начало ввод

string Polindrom(string s)
{
     int length = s.Length;
     for (int i = 0; i < length / 2; ++i)
        if (s[i] != s[length - 1 - i])
            {
                return Console.WriteLine("1");
            }
        else 
            {
                return Console.WriteLine("2");
            }
}

Console.WriteLine(Polindrom(s));
*/

//! Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//*
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
