// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.

// 3, 5 -> 243 (3⁵)

// // 2, 4 -> 16
using static System.Console;
Clear();

WriteLine("Введите число для возведения в степень: ");
int A = int.Parse(ReadLine()!);
WriteLine("Введите степень возведения числа: ");
int B = int.Parse(ReadLine()!);

WriteLine($" Число {A} в степени {B} равно {AtothePowerB(A,B)}.");


int AtothePowerB(int number, int tothePower)
{
    int result = 1;
    for (int i = 1; i <= tothePower; i++)
    {
        result = result * number;
    }
    return result;
}