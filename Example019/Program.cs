// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

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
    Console.Write("Таблица квадратов: ");
    while (i <= N)
    {
        j = i * i;
        Console.Write($"{j} ");
        i++;
    }
}