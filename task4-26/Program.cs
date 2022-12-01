// На вход число и выдает кол-во цифр в числе

//Первый вариант решения задачи:
/*Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (number>0)
{
    number/=10;
    count++;
}
Console.WriteLine($"Кол-во цифр числа = {count}");*/


Console.WriteLine("Введите число");
string number = Console.ReadLine();
int count = 0;
char[] array = new char[number.Length];
for (int i=0; i<array.Length; i++)
{
    array[i] = number[i];
    count++;
}
Console.WriteLine($"Кол-во цифр числа = {count}");