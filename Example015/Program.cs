// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

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

int number = GetNumberFromConsole("Введите день недели (число от 1 до 7): ");
if (number < 1 || number > 7)
    Console.WriteLine("некорректное число");
else
{
    if (number < 0 || number < 6)
        Console.WriteLine("будний день");
    else
        Console.WriteLine("Выходной");
}