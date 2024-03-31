// Задание
// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"



void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N: ");
    CompareMN(ref M, ref N);
    PrintNumbers(M, N);
}

void CompareMN(ref int M, ref int N)
{
    if (M > N)
    {
        int temp = M;
        M = N;
        N = temp;
        System.Console.WriteLine("Поменяли значения M и N местами, т.к. данные введены некорректно (M > N): ");
    }
}

void PrintNumbers(int M, int N)
{
    if (N < M) return;
    PrintNumbers(M, N - 1);
    System.Console.Write(N + ", ");

}


int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
