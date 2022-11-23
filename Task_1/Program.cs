// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Без использования функции Math.Pow.

int number1 = ReadInt("Введите первое число A: ");
int number2 = ReadInt("Введите второе число B: ");
int count = 1;
int degree = number1;
while (count < number2)
{
    degree = degree * number1;
    count++;
}
Console.WriteLine(degree);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}