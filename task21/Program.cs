//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.WriteLine("Введите координаты первой точки в 3D пространстве");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки в 3D пространстве");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
double result = Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2);
Console.WriteLine(result);
