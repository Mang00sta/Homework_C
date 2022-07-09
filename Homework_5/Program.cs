// методы
int[] CreateRandomArrayMinMax(int size, int minValue, int maxValue) 
{ 
    int[] newArray = new int[size];  
 
    for(int i = 0; i < size; i++) 
        newArray[i] = new Random().Next(minValue, maxValue+1); 
 
    return newArray; 
} 

int[] CreateRandomArray(int size) 
{ 
    int[] newArray = new int[size];  
 
    for(int i = 0; i < size; i++) 
        newArray[i] = new Random().Next(); 
 
    return newArray; 
} 

void ShowArray(int[] array) 
{ 
    for(int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
} 




//! Задача 34**: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2




//! Задача 36:** Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] SummNechet(int[] newArray)
{
    int sum=0;
    for (int i=0; i>newArray.Length; i++)
        newArray[i]=newArray[i]/2;
            if (newArray[i]>0)
            {
                 sum=sum+newArray[i];
            }
    return sum;
}



Console.Write("Input size of array: "); 
int size = Convert.ToInt32(Console.ReadLine()); 

 
int[] array = CreateRandomArray(size); 
ShowArray(array); 
int[] array1 = SummNechet(sum); 
ShowArray(array1); 




//! Задача 38:** Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76





/*
Задача 1. Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие  
//отрицательные, и наоборот. 
 
int[] CreateRandomArray(int size, int minValue, int maxValue) 
{ 
    int[] newArray = new int[size];  
 
    for(int i = 0; i < size; i++) 
        newArray[i] = new Random().Next(minValue, maxValue+1); 
 
    return newArray; 
} 
 
int[] Otric(int[] newArray) 
{ 
    for(int i = 0; i < newArray.Length; i++) 
    newArray[i] = newArray[i] * -1; 
 
    return newArray; 
} 
 
void ShowArray(int[] array) 
{ 
    for(int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
} 
 
Console.Write("Input size of array: "); 
int size = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input min possible value of elements: "); 
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input max possible value of elements: "); 
int max = Convert.ToInt32(Console.ReadLine()); 
 
int[] array = CreateRandomArray(size, min, max); 
ShowArray(array); 
int[] otric2 = Otric(array); 
ShowArray(otric2);


int [] arr = 
int ( )




Console.Write ("Insert number: ");
int num=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The sum og the numbers among: " + Dig(num));
*/