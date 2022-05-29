//Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

Console.Clear();
int [] array = new int[15];
int countEven = 0;
int countOdd = 0;
for ( int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i] + " ");

    if (array[i] % 2 == 0)
    countEven++;
    else 
    countOdd++;
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел: {countEven}");
Console.WriteLine($"Количество нечетных чисел: {countOdd}");


