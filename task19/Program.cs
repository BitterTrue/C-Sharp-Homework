﻿//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int Numb = int.Parse(Console.ReadLine());

int N1 = Numb / 100;
int N2 = (Numb % 10)*100 + ((Numb % 100)/10)*10 + (Numb % 1000)/100;

Console.WriteLine($"N1= {N1}");
Console.WriteLine($"N2= {N2}");
if (N1==N2)
{
  Console.WriteLine($"число является палиндромом {N1} = {N2}");
}
else
{
  Console.WriteLine($"число не является палиндромом с левой стороны читается как {N1} а с правой читается как {N2}");
}