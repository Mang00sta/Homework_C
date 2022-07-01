// Задача 10: 
/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
456 -> 5
782 -> 8
918 -> 1 */
// Решение через VOID рабочее полностью с исключением числа больше 3х знаков. 
/*
    void SecondNumber(int num) // создаем метод поиска 2й цифры в числе 
    {
        if (num<99||num>999) // оператор в котором переменная введенная пользователем проверяеться что введенное число в периоде 99 до 999 
        {
            Console.WriteLine("The number is introduced incorrectly!!! Start the input again.");
            return; 
        }
        
        int result = num/10%10;
        Console.Write("Second-digit number: " + result);
    }

    Console.Write("Insert three-digit number: "  ); // вывели текст на экран
    int n = Convert.ToInt32(Console.ReadLine()); //конвертировали что ввел пользователь в тип данных int  

    SecondNumber(n); // Расчет n(числа) с помощью метода SecondNumber
/*/


// Решение через int не совсем правильное но работает

/*/
    int SecondNumber(int num) // создаем метод поиска 2й цифры в числе 
    {   
        int result = num/10%10;   
        return result;    
    }

    Console.Write("Insert three-digit number: "  ); // вывели текст на экран
    int n = Convert.ToInt32(Console.ReadLine()); //конвертировали что ввел пользователь в тип данных int  

    // неполучилось проверку включить в метод как в случае с void все перепробовал, что то я упускаю

    if (n<99||n>999) 
    {
    Console.WriteLine("The number is introduced incorrectly!!!");
    }
    else
    {
    Console.WriteLine("Result " + SecondNumber(n));
    }
/*/


// Потуги решить нормально через int 
/*/
int SecondNumber(int num) // создаем метод поиска 2й цифры в числе 
{   
    
    if (num>99||num<999)
    {
         result = num/10%10;   
         return result;
    } 
    else
    {
       Console.WriteLine("The number is introduced incorrectly!!! Start the input again."); // !что то упускаю неполучаеться отправить запутался
       return 0;
    }
    //return result;
}

Console.Write("Insert three-digit number: "  ); // вывели текст на экран
int n = Convert.ToInt32(Console.ReadLine()); //конвертировали что ввел пользователь в тип данных int  

SecondNumber(n);
//Console.WriteLine("Result " + SecondNumber(n));
/*/



// Задача 15
/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
6 -> да 
7 -> да
1 -> нет */

//*/

void Weeked(int day) 
{
if (day<0||day>7) // оператор в котором переменная введенная пользователем проверяеться что введенное число в периоде 99 до 999 
    {
        Console.WriteLine("The number is introduced incorrectly!!! Start the input again."); //выводим текст на экран
        return; //окончание оператора
    }

    if (day==6)
    {
      Console.WriteLine("Good! This day is weekend (Saturday).");
    }
    else    
        if (day==7)
        {
        Console.WriteLine("Good! This day is weekend (Sanday).");
        }
        else
        {
        Console.WriteLine("Sorry! This day is not weekend!");
        }    
}

Console.Write("Insert number day: "); // принимаем цифру
int day=Convert.ToInt32(Console.ReadLine());

Weeked(day);

/*/


// Задача 13 
/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
//*

// 1 вар. Сделать из числа массив и забрать 3. цифру
// 2. вар Сделать цикл который будет по 1 убирать цифру из числа до 3го знака
// 3. вар С помощью сдвига влево до 3й ?????
// 4. Через string забрать число из конкретной номера (но это мы еще не учили)


/*
int ThirdNum(int n);
int number=0;
int d =0;
    while (n>number)
    {
        number = n/100;
        d = number%10;
        Console.WriteLine("Result: " + d);
        break;   
    }
        if(d<100) 
        {
            Console.WriteLine("Шляпа  ");
        }
    return d;

Console.Write("Insert number: "  ); // вывели текст на экран
int n = Convert.ToInt32(Console.ReadLine()); //конвертировали что ввел пользователь в тип данных int  

ThirdNum(n);

// else 
// {
//     number = (number*100)%100;
//     Console.WriteLine("Result2: " + number);
// }


// if (num<9999||num>999)
// {
//     n=n/10;
// }
// if (num<99||num>999)
// {
//     n=n/10;
// }
// if (num<99||num>999)
// {
//     n=n/10;
// }


// if (n<100)
// {
    
// }
//int number=number/100; 


// int Digit(int x)
// {
//     while (i>n) 
//         {
//            x /= 10;
//         }
//     return (x % 10) + '0';
// }

// Digit(); // метод - распечатал
     





// int k; // объявили переменную 

// Console.Write("Insert number: "  ); // вывели текст на экран
// k = Convert.ToInt32(Console.ReadLine()); //конвертировали что ввел пользователь в тип данных int  

// int des = k/=10;

//     // if (k=>0) 
//     // {
//     //     k /= 10;
//     //     return des;
//     // }

// Console.WriteLine("Result: " + des);


// }

// void ThirdVoidNumber()
// {
//     //int num=new Random().Next(10,1000); //нашли переменную рандомом
//     //Console.WriteLine("Random number:  " + num); // вывели на экран 
   
//         if (num<=100)
//         {
//             Console.WriteLine("There in no third number");
//         }


//     Console.WriteLine("Result: " + sot); //вывели ее на экран
// }

// ThirdVoidNumber();
//*/















