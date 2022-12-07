//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-20,20);
    Console.Write(" " +array[i]);
}
bool count =false;
for (int index = 0; index < 5; index++)
{    
    if (array[index] == number)
    count = true;
}
if (count)
    {
    Console.WriteLine();
    Console.WriteLine("да, массив содержит это число");
    }
else
    { 
        Console.WriteLine();
        Console.WriteLine("нет, массив не содержит это число");
    }
