// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Clear();

// Console.WriteLine("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine($"{num1} в степени {num2} = {Math.Pow(num1, num2)}");

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int sum = 0;
while (num > 0)
{
        sum += num % 10;
        num /= 10;   
}

Console.WriteLine($"Сумма цифр  = {sum} ");


