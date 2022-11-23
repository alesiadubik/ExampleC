Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if ((n>99) && (n<1000))
{
    Console.WriteLine("Последняя цифра "+n%10);
}
else
{
    Console.WriteLine("Ошибка, введите трёхзначное число!");
}