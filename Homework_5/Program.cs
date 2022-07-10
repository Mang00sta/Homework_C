// методы
int [] CreateRandomArray (int size) // метод который генерирует случайные числа
{
    int[] NewArray = new int [size];

    for (int i=0; i<size; i++)
    NewArray[i] = new Random().Next(i+1000); // Для задачи 36 ставим (-100,100). Не хватило тямы сделать через ограничение цикла if (array[i]>99||array[i]<999) 

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
int FindDishwindSum(int[] array) //метод нахождения суммы нечетных чисел (по ошибке сделал не стал удалять)
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
    {
        if (array[i]%2==0)
                 count++; 
    }
           
    return count;
}
int DishwindPosition (int[] array) // метод подбора нечетной позиции
{
    int i=0;
    int current=i;
    int sum=0;
    for (i=0; i<array.Length; i++) 
            if (i%2!=0) 
            {
                current=array[i];
                sum=sum+current;  
                Console.WriteLine(current);
            }
    return sum;
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
Console.Write ($"Array: "); ShowArray(array); // не получаеться собрать в одну строку

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
int sumofDiswind=DishwindPosition(array); Console.WriteLine();
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