//Массивы
int[,] Create2DArray(int rows, int columns)
{

    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++) // цикл 1
        for (int j = 0; j < columns; j++) // цикл 2
            newArray[i, j] = new Random().Next(0, 20); //+ NextDouble() 
                                                       //использовать mathRaund
    Console.WriteLine();
    return newArray;
}
void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // 0??
    {
        for (int j = 0; j < array.GetLength(1); j++) //??
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}


//!Задача 54
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] ChangeString(int[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                int temp = array[i, k + 1];
                array[i, k + 1] = array[i, k];
                array[i, k] = temp;
                }
            }
        }
    }


     return array;
}


Console.WriteLine();
Console.Write("2D Array: ");
int m = 5;
int n = 5;
Console.WriteLine();

int[,] Myarray = Create2DArray(m, n);
Show2DArray(Myarray);
Console.WriteLine();
Show2DArray(ChangeString(Myarray));
Console.WriteLine();


//!Задача 56:
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка.

//!Задача 62. 
//Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7