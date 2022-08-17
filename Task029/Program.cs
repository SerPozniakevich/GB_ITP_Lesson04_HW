// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

Console.Write("Случайный массив из 8 элементов в диапозоне [0, 99] - ");
int i = 0;
int coul = 0;
Console.Write("[ ");
while (coul < 8)
{
    i = new Random().Next(0, 100);
    coul++;
    Console.Write(i);
    Console.Write(", ");
    
}
Console.Write("]");
   
