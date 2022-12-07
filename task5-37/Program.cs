//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
Console.WriteLine("Введите число элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int[] newarray = new int[number/2];
int middle=0;
string res = string.Empty;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
    Console.Write(" " +array[i] +" ");
    middle = array [number/2];  
}
for (int j = 0; j < newarray.Length; j++) 
    {    
        newarray[j] = array[j] * array[array.Length -j -1];
        res+=$"{newarray[j]} ";
    }
 if (number%2!=0)                 
Console.Write("[ "+ res + " " +middle  +"]");
else
Console.Write("[ "+ res + "]");