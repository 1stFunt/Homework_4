// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = Convert.ToString(number).Length;
int summ = 0;
if (number < 0)
{
    number *= -1;
}
while (counter > 0)
{
    summ = summ + number % 10;
    number /= 10;
    counter--;
}
Console.WriteLine(summ);