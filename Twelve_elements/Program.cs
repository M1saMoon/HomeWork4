// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива

Console.Clear();
int [] array = new int[12];
int sumPos = 0;
int sumNeg = 0;
for ( int i = 0; i < 12; i++)
{
   array[i] = new Random().Next(0,10);
   Console.Write(array[i] + " ");

   if ( array [i] >= 0)
   sumPos = sumPos + array [i];
   else 
   Console.WriteLine(sumNeg);
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов: {sumPos}");
Console.WriteLine($"Сумма отрицательных элементов: {sumNeg}");




