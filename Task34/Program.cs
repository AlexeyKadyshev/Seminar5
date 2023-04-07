/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();

int Number(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int size = Number("Введите размер массива >> ");

int[] Array()
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i ++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int[] array = Array();
Console.WriteLine(string.Join(",", array));

int SumPositive()
{
    int[] newArr = array;
    int count = 0;
    for (int i = 0; i < size; i ++ )
    {
        if (newArr[i] % 2 == 0) 
        {
            count += 1;
        }
    }
    return count;
}
int sum = SumPositive();
Console.Write($"Количество положительных чисел в массиве: {sum}");








