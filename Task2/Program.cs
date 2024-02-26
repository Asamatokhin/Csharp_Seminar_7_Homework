//Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void Main()
{
    int m = ReadInt("Введите М: ");
    int n = ReadInt("Введите N: ");
    Console.WriteLine($"A({m},{n}) = {AkkermanFunction(m, n)}");

}
int ReadInt(string msg)
{
    Console.Write(msg);
    int result = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return result;
}

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

Main();