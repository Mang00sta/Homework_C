
// Методы
double [,] CreateRandom2DArrayMaterialNum (int rows, int columns)
{
    double [,] newArray =new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i<rows; i++) // цикл 1
            for (int j=0; j<columns; j++ ) // цикл 2
            {
              newArray[i,j] = Math.Round(rnd.NextDouble() * (100 - (-100)) + (-100),2); // округлил до сотых через Math.Round. Сделал числа через NextDouble и конверитировал их до десятых.   Как сделать что бы и сотые были и целые я не знаю!         
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

//! Задача 47. 
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
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
int [,] Create2DArray (int rows, int columns)
{
    
    int [,] newArray= new int [rows, columns];
    for (int i = 0; i<rows; i++) // цикл 1
        for (int j=0; j<columns; j++ ) // цикл 2
        newArray [i,j] = new Random().Next(0,100); 
        Console.WriteLine(); 
    return newArray;    
}

void Show2DArray (int [,] array)
{
    for (int i =0; i<array.GetLength(0); i++) // 0??
    {
        for (int j=0; j<array.GetLength(1); j++) 
        Console.Write(array[i,j] + "\t");
        Console.WriteLine(); 
    }
}

void Searchforthenumber (int [,] array, int Digit)
{
    int i =0;   
    int j=0;
    for (;i<array.GetLength(0); i++)
        for (; j<array.GetLength(1); j++) 
            if (array[i,j]==Digit)
            {
                
                Console.WriteLine("Your digit in the table! ");
                
            }
            else
            {
               
                Console.WriteLine("!!!!Your digit NON in the table!!!! ");     
                  
            } 
            
}


Console.Write("Input digit: ");
int Digit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write ("2D Array: ");
int m = 5;
int n = 5;
Console.WriteLine();

int [,] Myarray = Create2DArray(m,n);
Show2DArray (Myarray);
Console.WriteLine();
Searchforthenumber(Myarray, Digit);
Console.WriteLine();
/*/

//! Задача 52. 
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int [,] Create2DArray (int rows, int columns)
{
    
    int [,] newArray= new int [rows, columns];
    for (int i = 0; i<rows; i++) // цикл 1
        for (int j=0; j<columns; j++ ) // цикл 2
        newArray [i,j] = new Random().Next(0,100); 
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

void FindDigSumm (int [,] array)
{
    int sum = 0;
    for (int x =0; x<array.GetLength(0); x++)
        for (int y =0; y<array.GetLength(1); y++)
        
        if (y==1) 
        //sum=(array[j,j]+array[j,j]); 
        Console.Write(array[x,y] + "\t");
    //return sum;

}
Console.Write ("2D Array: ");
int m = 5;
int n = 5;

Console.WriteLine();

int [,] Myarray = Create2DArray(m,n);
Show2DArray (Myarray);
//Console.WriteLine($"Среднее арифмитическое столбца {FindDigSumm (Myarray)}  " );
Console.WriteLine();
FindDigSumm (Myarray);

