void PrintArray(string[] array) // метод печать массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ,");
    }
    Console.WriteLine();
}

string[] array = { "hello", "-2", "5678", "-))", "fgh" }; // задан массив строк
Console.WriteLine("Входной массив:");
PrintArray(array); // печать входного массива
int j=0;
for (int i=0; i < array.Length; i++) // находим количество строк массива с тремя или меньше символами
{    if (array[i].Length <= 3)
        j++;
}
string[] newarray = new string[j];
j = 0;
for (int i=0; i < array.Length; i++) // заполняем новый массив
{    if (array[i].Length <= 3)
    {    newarray[j] = array[i];
        j++;
    }
}
Console.WriteLine("Выходной массив:");
PrintArray(newarray); // печать нового массива