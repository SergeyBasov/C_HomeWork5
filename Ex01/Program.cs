/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

void EvenArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            array[i] = 1;
            result += array[i];
        }
    }
    Console.WriteLine($"-> {result} (количество чётных чисел в массиве)");
}

int[] GetArray(int size, int fist, int last)
{
    int[] emptyArray = new int[size];
    for (int index = 0; index < size; index++)
    {
        emptyArray[index] = new Random().Next(fist, last + 1);
    }
    return emptyArray;
}

int GetNumber(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Запрос количества элементов массива.
int inputNum = GetNumber("Задайте размер массива: ");

// Генерация и вывод массива.
int[] array = GetArray(inputNum, 100, 999);
Console.WriteLine($"[{String.Join(", ", array)}]");

// Подсчёт и вывод количества чётных чисел в массиве. 
EvenArray(array);