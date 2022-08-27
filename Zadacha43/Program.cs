﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите переменную b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную k2:");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (b1 - b2) / (k2 - k1);
double y = k1 * x + b1;
Console.WriteLine($"[{x}, {y}]");
