// на вход два числа и выводит 1-у кратное второму да или нет
Console.WriteLine("Введите числа");
int  num1 = Convert.ToInt32(Console.ReadLine());
int  num2 = Convert.ToInt32(Console.ReadLine());

//int result = 0;
//if (result == num1%num2)
//    Console.WriteLine("Кратно", result);
//else
//    Console.WriteLine("Некратно", result);

//if ( num1 % num2 == 0)
//    Console.WriteLine("Кратно");
//else
//    Console.WriteLine($"Некратно. Остаток: {num1 % num2}");

//if (num1%num2 == 0 || num2%num1 ==0)
//   Console.WriteLine("num1 может делиться на num2");
//else
//    Console.WriteLine($"num1 не может делиться на num2, result = {num1%num2}");

int temp = 0;
if (num1%num2 ==0)
    Console.WriteLine("num1 может делиться на num2");
else if  (num2%num1 ==0)
{
    temp = num1;
    num1=num2;
    num2=temp;
    Console.WriteLine($"num1 может делиться на num2, result = {num1%num2}");
}
else
    Console.WriteLine($"num1 не может делиться на num2, result = {num1%num2}");
