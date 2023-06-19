string[] createArrayManually(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}й элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

int CountLength(string[] array)
{
    int elementLength3 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            elementLength3++;
        }
    }
    return elementLength3;
}

string[] createFilterArray(string[] array, int elementLength3)
{
    string[] newArray = new string[elementLength3];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[j] = array[i];
            j++;
        }
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
int size = Convert.ToInt32(Console.ReadLine()); // этап 1

string[] myArray = createArrayManually(size); // этап 2

printArray(myArray); // этап 3

int filter = CountLength(myArray); // этап 4

string[] myFilterArray = createFilterArray(myArray, filter); // этап 5

printArray(myFilterArray); // этап 6