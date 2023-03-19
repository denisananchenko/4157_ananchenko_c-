// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число, или ввели 0. Повторите ввод!");
        }
    }
    return result;
}

int N = GetNumber("Введите число: ");
int i = 1;
int j = 1;
if (N < 0)
{
    N = -N;
}
else
{
    Console.Write("Таблица кубов: ");
    while (i <= N)
    {
        j = i * i * i;
        Console.Write($"{j} ");
        i++;
    }
}