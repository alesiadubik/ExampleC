// На вход число и выдает сумму цифр от 1 до заданного числа
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i <= number; i++)
{
    sum = sum + i;
}
Console.WriteLine(sum);
