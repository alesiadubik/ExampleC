// выдает 3-е число и удаляет 2-ю цифру
Random random = new Random ();
int number = random.Next (100,1000);
Console.WriteLine ($"Random number = {number}"); //("Random number = {0}", number);

//int a = number / 100;
//int b = number % 10;
//Console.WriteLine ("" +a +b);


int delete = 2;
var str = number.ToString();
number = int.Parse(str.Remove(str.Length-delete, 1));
Console.WriteLine (number);
