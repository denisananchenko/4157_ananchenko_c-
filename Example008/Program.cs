// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 2 || number == -2)
{
    Console.WriteLine(number);
}
else
{
    if (number > 0)
    {
        int result = 2;
        while (result < number)
        {
            Console.Write($"{result}; ");
            result = result + 2;
        }
    }
    else
    {
        int b = -2;
        while (b > number)
        {
            Console.Write($"{b}; ");
            b = b - 2;
        }
    }
}