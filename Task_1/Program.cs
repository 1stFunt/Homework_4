﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Без использования функции Math.Pow.

int numberA = ReadInt("Введите первое число A: ");
int numberB = ReadInt("Введите второе число B: ");
int degree = numberA;
for (int count = 1; count < numberB; count++)
{
    degree = degree * numberA;

}
Console.WriteLine(degree);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}