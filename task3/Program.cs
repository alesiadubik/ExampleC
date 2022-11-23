// Задача номер 5, вместо номер 3
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (n > 0)
    for (int nOpposite = -n; nOpposite <= n; nOpposite++)
    {
        Console.WriteLine (nOpposite);
    }
else
for (int nOpposite = n; nOpposite < -n; nOpposite++)
    {
        Console.WriteLine (nOpposite);
    }
    
    


