// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы

// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Main()
{
    int N = ReadInt("Введите число M: ");
    int M = ReadInt("Введите число N: ");
    Numbers(N,M);
}

void Numbers(int m, int n)
{
    if (m > n)
        return;
    {
        Console.Write($"{m}  ");
    }
    Numbers(m + 1, n);

}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();