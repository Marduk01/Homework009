// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int i = FinalCountdown("Введите положительное число : ");
int N = 1;
Console.WriteLine(numbers(i, N));

int numbers(int i, int N)
{
    if (i == N)
        return N;
    else
        Console.Write($"{numbers(i, N + 1)}, ");
    return N;
}

int FinalCountdown(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}