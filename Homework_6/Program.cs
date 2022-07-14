//!Задача 41: 
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
int [] CreateArray (int size) 
{
    int[] array = new int [size];

    Console.WriteLine("Creating array: ");
    for (int i=0; i<size; i++)
    {
        {
            Console.WriteLine($"Input {i+1} element: "); 
            array[i] = Convert.ToDouble(Console.ReadLine());   
        }
    }
    Console.WriteLine();
    return array;
}
void ShowArray (int[] array) 
{
    for (int i=0; i<array.Length; i++) 
    Console.Write(array[i] + " ");
    
}
int HowDigit (int [] array)
    {
        int count = 0;
        for (int i=0;i<array.Length; i++)
            if (array[i]>0) count++; 
        
        return count;
        
    }
    
Console.Write("Input array: ");
int num=Convert.ToDouble(Console.ReadLine()); Console.WriteLine();

int [] array = CreateArray (num);
Console.WriteLine ($"Array: "); ShowArray(array); 
Console.WriteLine();
int array2 = HowDigit (array);
Console.WriteLine($"Numbers more thеrе '0': {array2}"); 
/*/

// Вариант по моему мнению более правильный под определение "Пользователь вводит с клавиатуры M чисел". Нарыл в stack overflow как ввести массив пользователю цифрами подряд и конвертнуть в int32.    
/*
int HowDigit (int [] array)
    {
        int count = 0;
        for (int i=0;i<array.Length; i++)
            if (array[i]>0) count++; 
        
        return count;
        
    }
 
Console.Write("Input array from space: ");
int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
// создаем массив который забирает string от пользователя через пробел Split и конвертим в int 32 с помощью Parse. Ну и convertAll переводит в массиве из одного типа в другой. Единственное не смог сделать это как то раздельно, что бы отработал split -> метод конвертирования массива в численное -> метод поиска сколько чисел больше 0. т.е. приближено к решению выше. Ради интереса. Так то этот вариант лучше и на 1 метод меньше.    

Console.WriteLine();
int array2 = HowDigit (num);
Console.WriteLine($"Numbers more thеrе '0': {array2}"); 
/*/

//! Задача 43: 
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
double Dot1 (double b1,     double k1,   double b2,     double k2   ) 
{
     double x=0;
     double y=0;
     double result=0;

            x= - (b1-b2)/(k1-k2);
            y= k1*x+b1;
            if (x==y)
            {
               Console.WriteLine($"Пересечение в точке: ({x};{y})");
            }
            
            else 
            {
               Console.WriteLine($"Пересечения нет: ({x};{y})"); 
            }
           return result;
      
}


Console.Write("Input array b1: ");
Double b1=Convert.ToDouble(Console.ReadLine()); Console.WriteLine();
Console.Write("Input array k1: ");
Double k1=Convert.ToDouble(Console.ReadLine()); Console.WriteLine();
Console.Write("Input array b2: ");
Double b2=Convert.ToDouble(Console.ReadLine()); Console.WriteLine();
Console.Write("Input array k2: ");
Double k2=Convert.ToDouble(Console.ReadLine()); Console.WriteLine();


Dot1(b1, k1, b2, k2);
/*/

// Просто решил более простым способом (это было первое решение).
/*
Console.Write("Input array b1: ");
Double b1=Convert.ToDouble(Console.ReadLine()); Console.WriteLine();
Console.Write("Input array k1: ");
Double k1=Convert.ToDouble(Console.ReadLine()); Console.WriteLine();
Console.Write("Input array b2: ");
Double b2=Convert.ToDouble(Console.ReadLine()); Console.WriteLine();
Console.Write("Input array k2: ");
Double k2=Convert.ToDouble(Console.ReadLine()); Console.WriteLine();

double x= - (b1-b2)/(k1-k2);
double y= k1*x+b1;

Console.WriteLine($"Пересечение в точке: ({x};{y})");
/*/