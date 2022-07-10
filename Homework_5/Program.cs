// методы
int [] CreateRandomArray (int size) // метод который генерирует случайные числа
{
    int[] NewArray = new int [size];

    for (int i=0; i<size; i++)
    NewArray[i] = new Random().Next(100);

    return NewArray;    
}
int [] CreateArray (int size) // создание массива с помошью введения числа пользователем
{
    int[] NewArray = new int [size];

    Console.WriteLine("creating array: ");
    for (int i=0; i<size; i++)
    {
        {
            Console.WriteLine($"input {i+1} element: "); // {i+1} запрос по индексу поэтому i+1 
            NewArray[i] = Convert.ToInt32(Console.ReadLine());   
        }
    }
    Console.WriteLine();
    return NewArray;
}
void ShowArray (int[] array) // метод печати на экран
{
    for (int i=0; i<array.Length; i++) //если начинаем поиск с i+1, тогда мы должны 1 единицу отнять i<Array.Length -1
    Console.Write(array[i] + " ");
    
}
int FindDishwindSum(int[] array) //метод нахождения суммы нечетных чисел
{
    int sum=0;
    int i=0;
    for (; i<array.Length; i++)
        
        if (array[i]%2!=0)  
        sum += array[i];
        return sum;
}
int FindEvenDig(int[] array) //метод нахождения четного числа
{
    int i=0;
    int count=0;
    for (; i<array.Length; i++)
        if (array[i]%2==0)
            count++;
        return count;
}
int Position (int[] array) // метод подбора минимальной позиции
{
    int i=0;
    int minPosition=i;
    int j=0;
    for (i=0; i<array.Length-1; i++) //если начинаем поиск с i+1, тогда мы должны 1 единицу отнять i<Array.Length -1
    {
        for (j = i+1; j<array.Length; j++) //начинаем с отсартированного места j = i+1
         {
            //ищем минимальный. Текущий меньше элемента котрый находиться на minPosition. 
            //то сохраняем minPosition (minPosition=j) 
            if (array[j]<array[minPosition]) minPosition=j; 
         }
        
        int temporary=array[i]; // Замена позиции через темп 
        array[i]=array[minPosition]; // в i кладем минимальную
        array[minPosition]=temporary; // кладем временный элемент
        
    }
    return minPosition;
} 
int MinDigit(int [] array) // метод подбора минимального числа
{
    int minArray=array[0];
    for (int i=0; i<array.Length; i++)
        if (array[i]<minArray)
        {
           minArray=array[i];
        } 
    return minArray;
}
int MaxDigit(int [] array) // метод подбора максимального числа
{
    int maxArray=array[0];
    for (int i=0; i<array.Length; i++)
        if (array[i]>maxArray)
        {
           maxArray=array[i];
        } 
    return maxArray;
}

//! Задача 34**: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
Console.Write("Input array: ");
int size=Convert.ToInt32(Console.ReadLine()); Console.WriteLine();

int [] array = CreateRandomArray (size);
Console.Write ($"Array: "); ShowArray(array); // не получаеться собрать 

Console.WriteLine();
int array2 = FindEvenDig (array);
Console.WriteLine ($"The sum of even numbers in the array: {array2}"); 
/*/


//! Задача 36:** Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
Console.Write("Input array: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [] array = CreateRandomArray (size);
ShowArray(array); Console.WriteLine();
int sumofDiswind=FindDishwindSum(array); Console.WriteLine();
Console.WriteLine("Summ diswind array: " + sumofDiswind);

Console.ReadKey();
Console.Clear();
/*/

//! Задача 38:** Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// Подумать с учетом отрицательных 
// Подумать с учетом double  
/*
Console.Write("Input array: ");
int size=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine();

int [] array = CreateArray (size);
Console.Write("Array: "); ShowArray(array);
Console.WriteLine();

int Max=MaxDigit(array);
Console.WriteLine("Max: " + Max);
int Min=MinDigit(array); 
Console.WriteLine("Min: " + (Min));
Console.WriteLine();
Console.WriteLine("Result: " + (Max-Min));

Console.ReadKey();
Console.Clear();
/*/