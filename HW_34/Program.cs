/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int [] generateArray (int length, int start, int end)
{
    int [] result = new int[length];
    for (int i=0; i<length; i++)
    {
        result[i] = new Random().Next(start, end+1);
    }
return result;
}

int GetUserData(string message)
{
    Console.WriteLine(message);
    int userDate = int.Parse(Console.ReadLine()!);
    return userDate;
}

int FindCount(int [] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0)
        {
            count++;
        }
    }
     return count;
}

void printArray(int [] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]);
        if (i<array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int number = GetUserData("Введите количество элементов массива");
int [] array = generateArray(number, 100, 1000);
int result = FindCount(array);
printArray(array);

Console.WriteLine($"Количество четных чисел в массиве  - {result}");