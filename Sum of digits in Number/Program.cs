// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();

WriteLine("Введите число для нахождения суммы цифр: ");
int number = int.Parse(ReadLine()!);
WriteLine($"Сумма цифр числа {number} равна {SumOfDigitsInNumber(number)}.");

int SumOfDigitsInNumber(int number)
{
    int result = 0;
    int digitsQuantity = Convert.ToInt32(Math.Floor(Math.Log10(Math.Abs(number))) + 1);


    for (int i = 0; i < digitsQuantity; i++)
    {
        result = result + number % 10;
        number = number / 10;

    }
    return result;
}