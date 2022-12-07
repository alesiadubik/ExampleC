// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,
// и наоборот.[-4, -8, 8, 2] -> [4, 8, -8, -2] 
Console.WriteLine("Задаем массив");
int[] array = new int[4];
string original = string.Empty;
string oposite = string.Empty;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,11);
    original += $"{array[i]}, ";
    array [i] = array[i]*-1;
    oposite += $"{array[i]}, "; 
}
Console.WriteLine(original);
Console.WriteLine(oposite);