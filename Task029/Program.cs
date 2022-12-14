// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Console.Clear();

// Console.Write("Случайный массив из 8 элементов в диапозоне [0, 99] - ");
// int i = 0;
// int coul = 0;
// Console.Write("[ ");
// while (coul < 8)
// {
//     i = new Random().Next(0, 100);
//     coul++;
//     Console.Write(i);
//     Console.Write(", ");
// }
// Console.Write("]");

//Правильный вариант

int[] array = GetRandomArray(8,0,100); //"8" - количество элементов, "0" - от 0, "100" - до 100
Console.WriteLine($"[{String.Join(",",array)}]"); // String.Join - вывод элементов через запятую

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
   
