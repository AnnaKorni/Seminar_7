// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

void Main()
{
    int m = ReadInt("Введите неотрицательное число m: ");
    int n = ReadInt("Введите неотрицательное число n: ");
    int digitFuncAker = FunctionAkerman(m, n);
    System.Console.WriteLine("A(m,n) = " + digitFuncAker);
}


int FunctionAkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    else if (n == 0)
    {
        return FunctionAkerman(m - 1, 1);
    }

    else 
    {
        return FunctionAkerman(m - 1, FunctionAkerman(m, n - 1));
    }

    
}

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
