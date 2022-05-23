/*
Знакомство с языками программирования (семинары)
Урок 9. Как не нужно писать код. Часть 3
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int sum = 0;
int RecursMetod(int m, int n)
{
    if (m <= n)
    {
        sum += m;
        m++;
        RecursMetod(m, n);       
    }
    return m;
}
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(RecursMetod(m,n));
Console.WriteLine();
Console.WriteLine($"M = {m}; N = {n} -> {sum}");

*/

/*

Знакомство с языками программирования (семинары)
Урок 9. Как не нужно писать код. Часть 3
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
/*
int digitsSum(int number)
    {
        if(number==0) return 0;
        return number % 10 + digitsSum(number/10);
    }
Console.Write("Введите целое натуральное число N < 1000: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"{n} -> ");
Console.WriteLine(digitsSum(n));
*/