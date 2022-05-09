void PrintArray(string[] array) // метод печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($" {array[i]} ,");
    }
    Console.WriteLine();
}

string[] array = { "hello", "-2", "5678", "-))", "fgh" }; // задан массив строк
Console.WriteLine("Входной массив:");
PrintArray(array); // печать входного массива

