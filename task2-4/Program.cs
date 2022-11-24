// на вход число и проверяем кратно ли 7 и 23 одновременно
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;
if (number % a ==0 && number % b == 0)
Console.WriteLine("Кратно");
else
    Console.WriteLine("Некратно");
