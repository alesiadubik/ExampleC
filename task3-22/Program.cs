// ввести номер четверти системы координат и вывести диапазон x, y
Console.WriteLine("Введите номер четверти на оси ХУ");
int q = Convert.ToInt32(Console.ReadLine());
switch (q)
{
    case 1:
    Console.WriteLine("Диапазон возможных координат точек в этой четверти x > 0, y > 0");
    break;
    case 2:
    Console.WriteLine("Диапазон возможных координат точек в этой четверти x < 0, y > 0");
    break;
    case 3:
    Console.WriteLine("Диапазон возможных координат точек в этой четверти x < 0, y < 0");
    break;
    case 4:
    Console.WriteLine("Диапазон возможных координат точек в этой четверти x > 0, y < 0");
    break;
    default:
    Console.WriteLine("Неправильные данные введены");
    break;
}
