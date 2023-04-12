// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = number("Введите M : ");
int n = number("Введите N : ");
Console.WriteLine($" M = {m}; N = {n} -> {summa(m, n)}");

int number(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int summa(int m, int n)
{
    if (m == n) return n;
    return n + summa(m, n - 1);
}