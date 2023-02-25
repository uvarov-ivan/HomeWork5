// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int InputInt(string msg)
{
    System.Console.Write(msg + " > ");
    return (Convert.ToInt32(Console.ReadLine()));
}

int[] GenerationArray(int length, int minValue, int maxValue)
{
    int[] resalt = new int[length];
    for (int i = 0; i < length; i++)
    {
        resalt[i] = new Random().Next(minValue, maxValue + 1);
    }
    return (resalt);
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
}

int MinElement(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return (min);
}

int MaxElement(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return (max);
}

int size = InputInt("Введите длину массива");
int minValue = InputInt("Введите минимальное значение элементов массива");
int maxValue = InputInt("Введите максимальное значение элементов массива");
int[] myArray = GenerationArray(size, minValue, maxValue);

ShowArray(myArray);
System.Console.WriteLine($"разница между минимальным и максимальным элементами массива равна {MaxElement(myArray) - MinElement(myArray)}.");

