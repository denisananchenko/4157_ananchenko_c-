// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

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

int number = GetNumberFromConsole("Введите трехзначное число: ");
if ((number < 100 && number > -100) || number < -999 || number > 999)
    Console.WriteLine("число не трехзначное");
else
{   
int firstDigit = number / 100;
int secondDigit = (number - firstDigit * 100) / 10;
int thirdDigit = (number - firstDigit * 100) % 10;

if (secondDigit < 0)
  secondDigit = secondDigit * (-1);
Console.Write($"ваше число = {secondDigit}");}