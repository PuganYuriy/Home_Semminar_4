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
// void sum_number1 (int num_2) // создал метод "void"
//     {
//         // int num_3 = num_2;
//         // int num_2a1 = num_3 % 10;
//         // int num_2a2 = num_3 / 10 % 10;
//         // int num_2a3 = num_3 / 100 % 10;
//         // int num_2a4 = num_3 / 1000 % 10;
//         // int num_2a5 = num_3 / 10000 % 10;

//         //     Console.WriteLine (num_2a1 + num_2a2 + num_2a3 + num_2a4 + num_2a5);
//     }

void sum_number (int num_2) // создал метод "void"
    {
        int sum_num = 0; // создание переменной
        int sum = 0; // создание переменной
        for (int i = 1; i < num_2; i = i * 10) // цикл "for" 
        {
            sum_num = (num_2 / i % 10) + sum; // выводит остаток числа и складывает его с сохранненой переменной "sum"
            sum = sum_num; // сохраняет в переменную полученный результат
        }
        Console.WriteLine (sum); // выводит на экран полученный результат
    }

Console.WriteLine("Введите целое число"); 
int num_1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write (num_1 + " -> "); // выводит на консоль введенное число
sum_number (num_1); // вызывает функцию и выводит на экран полученный результат




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] Generate_random_array(int n, int start, int end)
// {
//     int[] RandomArray = new int [n];
//     for (int i = 0; i < n; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void Show_array(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine ( );
// }

// Console.WriteLine("Введите количество элементов в массиве"); 
// int num_1 = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("Введите первое число случайно генирируемых числел"); 
// int num_min = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("Введите последнее число случайно генирируемых числел"); 
// int num_max = Convert.ToInt32(Console.ReadLine()); 

// int [] array_random = Generate_random_array (num_1, num_min, num_max);
// Show_array(array_random);