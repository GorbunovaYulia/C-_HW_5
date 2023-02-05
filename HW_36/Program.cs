/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int FindResult(int [] array)
{
    int result = 0;
    for (int i=1; i<array.Length; i=i+2)
    {
        result += array[i];
    }
     return result;
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
int [] array = generateArray(number, -10, 10);
printArray(array);
int result = FindResult(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");