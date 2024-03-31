// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void Main()
{
    int sizeArray = ReadInt("Введте размер массива: ");
    int[] array = GenerateArray(sizeArray, 0, 99);
    PrintArray(array);
    System.Console.Write(" => ");
    ReversArray(array, 0, array.Length - 1);
    PrintArray(array);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    return tempArray;
}

void PrintArray(int[] arrayFarPrint)
{
    foreach (int number in arrayFarPrint)
    {
        System.Console.Write(number + " ");
    }
}

void ReversArray(int[] array, int i, int j)
{
    if (i >= j) return;

    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;

    ReversArray(array, i + 1, j - 1);
}

Main();
