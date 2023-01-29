// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[9];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int sum = 0;
for (int j = 0; j < array.Length; j++)
{
    if (j % 2 != 0)
    {
        sum = sum + array[j];
    }
}
Console.Write($"Сумма элементов на нечетных позициях = {sum}");