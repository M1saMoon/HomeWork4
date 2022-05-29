//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Console.Clear();
int [] Binare = new int[8];
for (int i = 0; i < 8; i++)
{
    Binare[i] = new Random().Next(0,2);
    Console.Write(Binare[i] + " ");
}