/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
 */
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
        arr[i] = rnd.Next(100);
    }
    return arr;
}

int[] array = Array();
Console.WriteLine(string.Join(",", array));

int MaxNum()
{
    int[] newArr = array;
    int max = newArr[0];
    for (int i = 0; i < size; i ++ )
    {
        if (newArr[i] > max) 
        {
            max = newArr[i];
        }
    }
    return max;
}

int MinNum()
{
    int[] newArr = array;
    int min = newArr[0];
    for (int i = 0; i < size; i ++ )
    {
        if (newArr[i] < min) 
        {
            min = newArr[i];
        }
    }
    return min;
}

int maxnum = MaxNum();
int minnum = MinNum();
Console.Write($"Разница между наибольшим и наименьшим элементами массива равна: {maxnum - minnum}");
