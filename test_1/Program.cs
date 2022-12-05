string[] array_1 = { "Hello", "2", "world", ":-)" };
string[] array_2 = { "1234", "1567", "-2", "computer science" };
string[] array_3 = { "Russia", "Denmark", "Kazan" };

int max_length_of_symbol = 3;

string[] GetNewArray(string[] array)
{
    int length = array.Length;
    string[] new_array = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= max_length_of_symbol)
        {
            new_array[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref new_array, count);

    return new_array;
}

void PrintFinalWork(string[] array)
{
    Console.WriteLine("Изначальный массив: ");
    PrintArray(array);
    string[] NewArray = GetNewArray(array);
    Console.WriteLine($"Новый массив из строк, длина которых меньше, либо равна {max_length_of_symbol} символам:");
    PrintArray(NewArray);
    Console.WriteLine();
}

void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("[ ]");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}

PrintFinalWork(array_1);
PrintFinalWork(array_2);
PrintFinalWork(array_3);
