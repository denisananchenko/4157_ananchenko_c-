// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int GetNumberFromConsole(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }

    }

    return result;
}
int number = GetNumberFromConsole("Введите число: ");
if (number < 0)
    number = -number;
int sum = 0;
string numberStr = number.ToString();
for (int i = 0; i < numberStr.Length; i++)
{
    sum = sum + (numberStr[i] - '0');
}
Console.WriteLine($"Сума цифр числа {number} = {sum}");