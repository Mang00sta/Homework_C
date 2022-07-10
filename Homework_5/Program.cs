// методы
int [] CreateRandomArray (int size) // метод который генерирует случайные числа от заданных чисел
{
    int[] NewArray = new int [size];

    for (int i=0; i<size; i++)
    NewArray[i] = new Random().Next(100);

    return NewArray;    
}

void ShowArray (int[] array) // метод подбора
{
    for (int i=0; i<array.Length; i++) //если начинаем поиск с i+1, тогда мы должны 1 единицу отнять i<Array.Length -1
    Console.Write(array[i] + " ");
    
}

int FindDishwindSum(int[] array)
{
    int sum=0;

    for (int i=0; i<array.Length; i++)
        if (array[i]%2==0) 
        {
            sum=sum+array[i];
        }
        

    return sum;
}




//! Задача 34**: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2




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




