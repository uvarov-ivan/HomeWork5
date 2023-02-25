// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int InputInt(string msg)
{
    System.Console.Write(msg + " > ");
    return (Convert.ToInt32(Console.ReadLine()));
}

int[] GenerateArray(int length, int minValue, int maxValue)
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

int SumEventElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return(sum);
}

int size = InputInt("Введите длину массива");
int minValue = InputInt("Введите минимальное значение эллементов массива");
int maxValue = InputInt("Введите максимальное значение элементов массива");
int [] myArray = GenerateArray(size, minValue, maxValue);
ShowArray(myArray);
System.Console.WriteLine($"Сумма нечётных элементов массива равна {SumEventElements(myArray)}.");