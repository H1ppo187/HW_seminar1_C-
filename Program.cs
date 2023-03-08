// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите певрое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите Второе число: ");
int B = int.Parse(Console.ReadLine()!);
if (A>B)Console.Write("Первое число большее второго " );
if (A<B)Console.Write("Первое число меньше второго " );
    
