/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();

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
        arr[i] = rnd.Next(-100, 101);
    }
    return arr;
}

int[] array = Array();
Console.WriteLine(string.Join(",", array));

int SumOddPosition()
{
    int count = 0;
    for (int i = 1; i < size; i ++ )
    {
        if (i % 2 != 0) 
        {
            count += array[i];
        }
    }
    return count;
}
int sum = SumOddPosition();
Console.Write($"Сумма элементов на нечетных позициях: {sum}");



