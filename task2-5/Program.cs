// на вход 2 числа и является ли одно из них квадратом числа
Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2*number2 || number2 == number1*number1)
Console.WriteLine("Является");
else
    Console.WriteLine("Не является");