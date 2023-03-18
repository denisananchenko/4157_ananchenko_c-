// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

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
int GetThirdDigit(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

int number = GetNumberFromConsole("Введите число: ");
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
  Console.Write($"третья цифра = {GetThirdDigit(number)}");
}