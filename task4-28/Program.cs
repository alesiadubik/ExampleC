// На вход число и выдает произведение цифр от 1 до заданного числа
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= number; i++)
{
    result = result * i;
}
Console.WriteLine(result); 

