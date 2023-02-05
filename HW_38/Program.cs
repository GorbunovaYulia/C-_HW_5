/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
int[] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}

int GetUserData(string message)
{
    Console.WriteLine(message);
    int userDate = int.Parse(Console.ReadLine()!);
    return userDate;
}

int FindMax(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
        {
            max = array[i];
        }
    return max;
}

int FindMin(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
        {
            min = array[i];
        }
    return min;
}


void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int number = GetUserData("Введите количество элементов массива");
int[] array = generateArray(number, -10, 10);
printArray(array);
int max = FindMax(array);
int min = FindMin(array);
Console.WriteLine($"Максимальное число в массиве = {max}, минимальное число в массиве = {min}, разница между максимальным и минимальным элементами массива = {max-min}");