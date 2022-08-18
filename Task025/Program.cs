// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Clear();

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int count = 1;
int expon = 1;

while (count <= Math.Abs(num2))
{
    expon *= num1;
    count++;
}
if (num1 != 0 && num2 > 0) Console.WriteLine($"{num1} в {num2} степени- {expon}");
if (num1 == 0 && num2 != 0) Console.WriteLine($"{num1} в {num2} степени- 0 ");
if (num1 != 0 && num2 == 0) Console.WriteLine($"{num1} в {num2} степени- 1 "); 
if (num1 != 0 && num2 < 0) Console.WriteLine($"{num1} в {num2} степени- -(1 / {Math.Abs(expon)})");











