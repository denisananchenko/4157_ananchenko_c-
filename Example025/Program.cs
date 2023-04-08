// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

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


int number1 = GetNumberFromConsole("Введите первое число: ");
int number2 = GetNumberFromConsole("Введите второе число: ");
double power = Math.Pow(number1, number2);
Console.WriteLine($"{number1} ^ {number2} = {power}");