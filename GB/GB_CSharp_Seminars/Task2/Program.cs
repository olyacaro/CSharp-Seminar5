﻿/* Напишите программу, которая на вход принимает 2 числа
и выдает, какое число большее, а какое меньшее
a = 5 b = 7  -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите два числа ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1<num2)
{
    Console.WriteLine($"Число {num2} больше числа {num1}");
}
else if (num2<num1)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else
{
    Console.WriteLine("Числа равны");
}