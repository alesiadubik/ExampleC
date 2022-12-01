// вывод массива из 8 элементов, заполненный нулями и единицами в случайном порядке
//int number = 8;
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
    Console.Write($" {array[i]}");
}
