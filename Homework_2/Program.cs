﻿// Задача 10: 
/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
456 -> 5
782 -> 8
918 -> 1 */
/*/

int num; // объявили переменную 

Console.Write("Insert three-digit number: "  ); // вывели текст на экран
num = Convert.ToInt32(Console.ReadLine()); //конвертировали что ввел пользователь в тип данных int  

    if (num<99||num>999) // оператор в котором переменная введенная пользователем проверяеться что введенное число в периоде 99 до 999 
    {
        Console.WriteLine("The number is introduced incorrectly!!! Start the input again."); //выводим текст на экран
        return; //окончание оператора
    }
        
void SecondNumberVoid() // создаем метод поиска 2й цифры в числе 
{
        int des = num /10%10; // вводим переменную des и находим вторую цифру в числе делением на целое % 
        Console.WriteLine("Result - " + des); // выводим значение  des на экран
}
SecondNumberVoid(); // оканчиваем метод
/*/

// Задача 13 
/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
/*

void ThirdVoidNumber()
{
    int num=new Random().Next(10,1000); //нашли переменную рандомом
    Console.WriteLine("Random number:  " + num); // вывели на экран 

    int sot=num/10;   //посчитали и добавили переменную
    Console.WriteLine("Result: " + sot); //вывели ее на экран




}
ThirdVoidNumber();
/*/

// Задача 15
/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
6 -> да 
7 -> да
1 -> нет */

/*
int day;

Console.Write("Insert number day: "); // принимаем цифру
day=Convert.ToInt32(Console.ReadLine());

if (day<0||day>7) // оператор в котором переменная введенная пользователем проверяеться что введенное число в периоде 99 до 999 
    {
        Console.WriteLine("The number is introduced incorrectly!!! Start the input again."); //выводим текст на экран
        return; //окончание оператора
    }

    if (day==6)
    {
      Console.WriteLine("Good! This day is weekend (Saturday).");
    }
    else    
        if (day==7)
        {
        Console.WriteLine("Good! This day is weekend (Sanday).");
        }
        else
        {
        Console.WriteLine("Sorry! This day is not weekend!");
        }    
/*/



