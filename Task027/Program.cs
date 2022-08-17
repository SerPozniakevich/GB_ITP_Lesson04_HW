//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int sum = 0;
while (num > 0)
{
        sum += num % 10;
        num /= 10;   
}

Console.WriteLine($"Сумма цифр  = {sum} ");
