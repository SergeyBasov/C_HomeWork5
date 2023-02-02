/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void CalcMaxMinNumArray(int[] numArray)
{
    int maxNumberArray = numArray[0];
    int minNumberArray = numArray[0];
    for (int i = 0; i < numArray.Length; i++)
    {
        if (maxNumberArray < numArray[i]) maxNumberArray = numArray[i];
        if (minNumberArray > numArray[i]) minNumberArray = numArray[i];
    }
    Console.WriteLine($"-> {maxNumberArray - minNumberArray} (разница между MAX ({maxNumberArray}) и MIN ({minNumberArray}) элементами массива)");
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
    int number = int.Parse(Console.ReadLine());
    return number;
}
// Запрос количества элементов массива.
int inputNum = GetNumber("Задайте размер массива: ");

// Генерация и вывод массива.
int[] numArray = GetArray(inputNum, 0, 100);
Console.WriteLine(String.Join(" ", numArray));

// Поиск МАХ и MIN элементов заданного массива, подсчет их разницы и вывод на экран.
CalcMaxMinNumArray(numArray);
