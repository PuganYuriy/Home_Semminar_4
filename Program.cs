// Урок 4. Функции продолжение
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Ввести первое целое число"); //вводим первое целое число
// int a = Convert.ToInt32(Console.ReadLine()); //конвектирует первое вводимое число в переменную "а"

// Console.WriteLine("Ввести второе целое число"); //вводим второе целое число
// int b = Convert.ToInt32(Console.ReadLine()); //конвектирует второе вводимое число в переменную "b"

// Console.Write (a + ", в " + b + " степени->");
//     if (a>0 && b>0) // сравниваем переменные
// {
//     Console.Write(Math.Pow(a, b) + ", "); //при помощи метода "Math.Pow" возводим число в степень и выводим на консоль
// }
//     else // (a<=0)
// {
//     Console.Write("0"); 
// }



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12






// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Generate_random_array(int n, int start, int end)
{
    int[] RandomArray = new int [n];
    for (int i = 0; i < n; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void Show_array(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine ( );
}

Console.WriteLine("Введите количество элементов в массиве"); 
int num_1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите первое число случайно генирируемых числел"); 
int num_min = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите последнее число случайно генирируемых числел"); 
int num_max = Convert.ToInt32(Console.ReadLine()); 

int [] array_random = Generate_random_array (num_1, num_min, num_max);
Show_array(array_random);