string[] createArrayManually(int size)
{
    string[] newArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}й элемент массива: ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(); // для новой строки
}

Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myArray = createArrayManually(size);
printArray(myArray);