// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// Пример: 

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void Main()
{
    int[] myArray = { 4, 3, 2, 7, 12, 8 };
    PrintArray(myArray);

}

void PrintArray(int[] myArray, int i = 0)
{
    if (i < myArray.Length)
    {
        PrintArray(myArray, i + 1);
        System.Console.Write(myArray[i] + " ");
    }
}

Main();