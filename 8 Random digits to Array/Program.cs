// Задача 29: Напишите метод, который формирует массив из 8 случайных элементов и выводит их на экран.

// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33]

using static System.Console;
Clear();

WriteLine("Введите число эементов в массиве: ");
int arrayLength = int.Parse(ReadLine()!);

int[] array = new int[arrayLength];


ArrayWithRandomElements(array,arrayLength);
Array.ForEach(array,el=> Write(" "+el));


void ArrayWithRandomElements(int[] array, int numberOfElements)
{
    for (int i = 0; i < numberOfElements; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

