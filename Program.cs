// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// ------------Methods-------------
// int[] GetArray (int size,int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min,max);
//     }
//     return array;
// }
// // _________________________________
// int[]massive = GetArray(100,99,1000);
// int sum = 0;
// foreach (var i in massive)
// {
//     if((i % 2) == 0)
//     {
//         sum++;
//     }
// }

// Console.WriteLine($"[{String.Join("|", massive)}]");
// Console.WriteLine($"Сумма четных чисел в массиве равна {sum}");

// __________________________________________________________________________________________

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// // ------------Methods-------------
// int[] GetArray (int size,int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min,max);
//     }
//     return array;
// }
// int[]collection = GetArray(10,-7,7);
// int sum = 0;
// for(int i =0; i<collection.Length; i++)
// {
//     if((i % 2) != 0)
//     {
//         sum += collection[i];
//     }
// }
// Console.WriteLine($"[{String.Join("|",collection)}]");
// Console.Write($"Сумма элементов нечётных индексов массива равна: {sum}");

// __________________________________________________________________________________________

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// ------------Methods-------------

// ---1---
int[] GetArray (int size,int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
    return array;
}

System.Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray (size,2,7);
Console.WriteLine($"[{String.Join("|",array)}]");

if(array.Length % 2 != 0) //условие если массив не четный 
{
    int[] array2 = new int[array.Length/2 + 1];//добавил одну ячейку к новому массиву чтобы в нее записать неучтенную середину
    for (int j = 0; j < array.Length/2; j++)
    {
        array2[j] = (array[array.Length -1 - j]) * array[j] ;
    }
    array2[array2.Length-1] = array[array.Length/2]; // закинул значение неучтенной середины в конец нового массива

    Console.WriteLine($"[{String.Join("|",array2)}]");
}
else
{
    int[] array2 = new int[array.Length/2];

    for (int j = 0; j < array.Length/2; j++)
        {
            array2[j] = (array[array.Length -1 - j]) * array[j] ;
        }

Console.WriteLine($"[{String.Join("|",array2)}]");
}