//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
double max = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
double min = max; 
for (int k = 0; k < array.Length; k++)
{
    if (array[k] < min)
    {
        min = array[k];
    }
}
Console.WriteLine($"Максимальный элемент массива: {max}");
Console.WriteLine($"Минимальный элемент массива: {min}");

double deff = max - min; 

Console.WriteLine($"Разница между max и min элементами: {deff}");