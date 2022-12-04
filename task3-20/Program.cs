// Ввести координаты точек и рассчитать расстояние между ними
Console.WriteLine("Введите координаты точек");
Console.Write("X1 = ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 = ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("X2 = ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
double y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)));
Console.WriteLine($"Расстояние между точками = {result}");