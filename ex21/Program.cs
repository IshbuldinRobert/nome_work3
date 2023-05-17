﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double Sum(double coord1, double coord2)
{
    double sum = coord1 - coord2;
    return sum;
}

double distance = Math.Sqrt(Math.Pow(Sum(x1, x2), 2) + Math.Pow(Sum(y1, y2), 2) + Math.Pow(Sum(z1, z2), 2));
Console.WriteLine($"Расстояние между двумя точками {Math.Round(distance, 3)}");