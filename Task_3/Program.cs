// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.

Console.WriteLine("Введите натуральное число (N): ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

void FillArray(int[] coll)
{
    int length = coll.Length;
    int index = 0;
    while (index < length)
    {
        coll[index] = new Random().Next(1, 100);
        index++;
    }
}
void PrintArray(int[] coll)
{
    int length = coll.Length;
    int index = 0;
    while (index < length - 1)
    {
        Console.Write($"{coll[index]},");
        index++;
    }
    if (index == length - 1)
    {
        Console.Write($"{coll[index]}]");
    }
}
Console.Write($"{number}->[");
FillArray(array);
PrintArray(array);