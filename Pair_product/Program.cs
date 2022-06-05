//Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();
int [] array = new int [20];
int count = 0;
for ( int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,20);
    Console.Write($"{array[i] + " "}");
}
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    count = array[i] * array.Length - 1;
}
Console.WriteLine($"{count}");