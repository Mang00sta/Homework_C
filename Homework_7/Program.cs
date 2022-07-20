
// Методы
double [,] CreateRandom2DArrayMaterialNum (int rows, int columns)
{
    double [,] newArray =new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i<rows; i++) // цикл 1
            for (int j=0; j<columns; j++ ) // цикл 2
            {
              newArray[i,j] = Math.Round(rnd.NextDouble()*10,1); 
              // Подглядел! округлил до сотых через Math.Round.          
              //newArray[i,j] = Math.Round(rnd.NextDouble() * (100 - (-100)) + (-100),2); 
              // -отрицательные 
            }
    
        return newArray;
}
void Show2DArrayMaterialNum (double [,] array)
{
    for (int i =0; i<array.GetLength(0); i++) // 0??
    {
        for (int j=0; j<array.GetLength(1); j++) //??
        //Console.Write("{0,6:F2}", array[i,j]);
       Console.Write(array[i,j] + "\t");

        Console.WriteLine(); 
    }
}
int [,] Create2DArray (int rows, int columns)
{
    
    int [,] newArray= new int [rows, columns];
    for (int i = 0; i<rows; i++) // цикл 1
        for (int j=0; j<columns; j++ ) // цикл 2
        newArray [i,j] = new Random().Next(0,100); //+ NextDouble() 
        //использовать mathRaund
        Console.WriteLine(); 
    return newArray;    
}
void Show2DArray (int [,] array)
{
    for (int i =0; i<array.GetLength(0); i++) // 0??
    {
        for (int j=0; j<array.GetLength(1); j++) //??
        Console.Write(array[i,j] + "\t");
        Console.WriteLine(); 
    }
}

/*/
//! Задача 47. 
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
//*

/*
Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] RandomArrayMaterialNum = CreateRandom2DArrayMaterialNum(m,n);
Show2DArrayMaterialNum (RandomArrayMaterialNum);
/*/


//!Задача 50. 
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*
void Searchforthenumber (int [,] array, int pos1, int pos2)
{
    if (pos1 < 0 | pos1 > array.GetLength(0)| pos2 < 0 | pos2 > array.GetLength(1))
    {
         //Console.WriteLine("Your digit in the table: " + array[pos1-1, pos2-1] );
         Console.WriteLine("!!!!Your digit NON in the table!!!! ");
    }
    else
    {
        Console.WriteLine("Your digit in the table: " + array[pos1-1, pos2-1] );
        //Console.WriteLine("!!!!Your digit NON in the table!!!! ");
    }        
}

Console.Write("Input rows: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns: ");
int pos2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write ("2D Array: ");
int m = 5;
int n = 5;
Console.WriteLine();

int [,] Myarray = Create2DArray(m,n);
Show2DArray (Myarray);
Console.WriteLine();
Searchforthenumber(Myarray,pos1,pos2);
Console.WriteLine();
/*/

//! Задача 52. 
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Если использовать Create2DArray и Show2DArray в int системе то ответ получаеться не дробный.  Как сделать так как в задании? Только 1 вариант это делать через if по каждому столбцу. Фактически искать вручную. Но это как то мне показалось неправильно. Поэтому вот такой вариант.
//*
void FindDigSumm (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        double digi=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum=sum+array[j, i];
            digi = sum/array.GetLength(0);
        }
        Console.WriteLine("Sum in column: "+  digi);
    }
}

Console.Write ("2D Array: ");
int m = 5;
int n = 5;

Console.WriteLine();
double [,] Myarray = CreateRandom2DArrayMaterialNum(m,n);
Show2DArrayMaterialNum (Myarray);
Console.WriteLine();
FindDigSumm (Myarray);
//*/