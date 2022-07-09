// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
int Dig (int n)
{
     int temp = n, rem=0, sum=0; 
    for (; n>0 ;   ) 
        {                      
            rem = n % 10; 
            n = n / 10;
            sum=sum+rem;
  
        }
        return sum;

}

Console.Write ("Insert number: ");
int num=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The sum og the numbers among: " + Dig(num));
/*/

// !Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
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
 
Console.Write("Input size of array: "); 
int size = Convert.ToInt32(Console.ReadLine()); 
 
int[] array = CreateRandomArray(size); 
ShowArray(array); 
*/




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