/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void CalcArray(int[] numArray)
{
    int sum = 0;
    for (int i = 1; i < numArray.Length; i += 2)
    {
        sum += numArray[i];
    }
    Console.WriteLine($"-> {sum} (сумма чисел стоящих на нечётных позициях массива)");
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

// Генерация массива и вывод массив.
int[] numArray = GetArray(inputNum, -10, 10);
Console.WriteLine($"[{String.Join(" ", numArray)}]");

// Подсчет и вывод суммы числ стоящих на нечётных позициях массива.
CalcArray(numArray);