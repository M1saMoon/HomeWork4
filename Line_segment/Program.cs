//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Clear();
int[] array = new int[123];
int count = 0;
for ( int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-1000,1000);
    Console.Write(array[i] + " ");
    if (array[i] > 10 && array[i] < 99)
    count++;
}
Console.WriteLine();
Console.WriteLine($"Количество элементов о отрезке: {count}");