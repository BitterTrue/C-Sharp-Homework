﻿//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
for (int i = 0; i <= N; i++)
{
  Console.WriteLine(Math.Pow(i, 3));
}
