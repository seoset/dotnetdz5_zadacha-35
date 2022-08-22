//Задача 35
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int minRange = 10;
int maxRange = 99;
int[] array = GenerateRandomIntArray();
ShowArray(array);
Console.Write($"The Quantity of elements in the array in the range from {minRange} to {maxRange} is - {SearchAllNubersInRange(array, minRange, maxRange)}");

int[] GenerateRandomIntArray(int quantity = 123, int minNumber = 0, int maxNumber = 1000)
{
    int[] array = new int[quantity];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minNumber, maxNumber);
    }

    return array;
}

void ShowArray(int[] array)
{
    Console.Write("Generated array - ");

    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }

    Console.WriteLine();
}

int SearchAllNubersInRange(int[] array, int minRangeNumber, int maxRangeNumber)
{
    int count = 0;

    foreach (int item in array)
    {
        if (item >= minRangeNumber && item <= maxRangeNumber)
        {
            count ++;
        }
    }

    return count;
}
