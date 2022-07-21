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

int[,] CreateArraySpiral ()
{

    int[,] newArray = new int[4, 4] { { 1, 2,3,4 }, { 5,6,7,8 }, { 9,10,11,12 }, { 13, 14,15,16 } };
    
    Console.WriteLine();
    return newArray;
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
/*
int[,] ChangeString(int[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
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
/*/

//!Задача 56:
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка.

/*
void FindDigSumm (int [,] array)       
{
            int[] tempMass  = new int[100];
            int sum1 = 0;
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum1 += array[i, j];   
                }
                tempMass[i] = sum1; 
                sum1 = 0; 
            }

            int max = 0;   
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (tempMass[j] > tempMass[max])   
                    max = j;
            }
            Console.WriteLine($"Line number with the maximum amount of elements:  {max+1}");
}     
/*/            

// 2й вариант не доделал не хватило времени
/*
void FindDigSumm (int [,] array)
{
    
    int sum = 0;
    //int sum1 = 0;
    int sum2 = 0;
    int min = 0;
    int count =0;
    int temp =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum=sum+array[i, j];            
        }
        int sum1=sum;
                Console.WriteLine("Выходная сумма  " + sum1);    
        sum=0;
            
            if (sum1>temp)
                {
                    temp = sum1;
                    sum1 = temp;    
                    
                   Console.WriteLine("Круги внутри   " + count);                     
                }  
                count++;
           
        Console.WriteLine("Круги   " + count);
    }
    Console.WriteLine("Суммы  " + temp);
}

Console.WriteLine();
Console.Write("2D Array: ");
int m = 5;
int n = 4;
Console.WriteLine();

int[,] Myarray = Create2DArray(m, n);
Show2DArray(Myarray);
Console.WriteLine();
FindDigSumm (Myarray);
Console.WriteLine();
/*/

//!Задача 62. 
//Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


void SpiralArray (int [,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
        else if (i < j && i + j >= array.GetLength(0) - 1) i++;
        else if (i >= j && i + j > array.GetLength(1) - 1) j--;
        else i--;
    }
}

int[,] Myarray = CreateArraySpiral();
SpiralArray(Myarray);
Show2DArray(Myarray);
Console.WriteLine();

