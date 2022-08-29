/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double b1 = ReadDouble ("Введите значение b1: ");
double k1 = ReadDouble ("Введите значение k1: ");
double b2 = ReadDouble ("Введите значение b2: ");
double k2 = ReadDouble ("Введите значение k2: ");

double b2b1 = b2-b1;
double k1k2 = k1-k2;

double x = b2b1/k1k2;
double y = k1*x +b1;

Console.WriteLine($"Пересечение прямых в точке: {x} ; {y} ");

double ReadDouble(string message)
{
     Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}