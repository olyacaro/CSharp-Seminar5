﻿// Напишите программу, которая на вход принимает одно число (N)
// а на выходе показывает все целые числа от -N до N.
// 4 -> "-4 -3 -2 -1 0 1 2 3 4"
// 2 -> "-2 -1 0 1 2"

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numNegative = num * -1;
while(numNegative <= num)
{
    Console.Write(numNegative);
    Console.Write(", ");
    numNegative = numNegative + 1;
}