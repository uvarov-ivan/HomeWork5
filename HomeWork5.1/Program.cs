// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int InputInt(string msg)
{
    System.Console.Write(msg + " >");
    return (Convert.ToInt32(Console.ReadLine()));
}

int[] GeneraitArray(int lenght)
{
    int[] resalt = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        resalt[i] = new Random().Next(100, 1000);
    }
    return (resalt);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
}

int EventCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return (count);
}

int size = InputInt("Введите количество чисел в массиве");
int[] myArray = GeneraitArray(size);
PrintArray(myArray);
System.Console.WriteLine($"в указанном массиве количество чётных чисел равно {EventCount(myArray)}.");