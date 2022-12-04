// на вход две координты точки и вывести четверть координат
Console.WriteLine("Введите число х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y");
int y = Convert.ToInt32(Console.ReadLine());
if (x < 0 && y > 0)
{
    Console.WriteLine("Первая четверть");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Вторая четверть");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Четвертая четверть");
}