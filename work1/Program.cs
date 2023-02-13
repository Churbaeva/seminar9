 /*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine(CountNaturalSum(4,8));

int CountNaturalSum(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return n + CountNaturalSum(m, n - 1);
}
