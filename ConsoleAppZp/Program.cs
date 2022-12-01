Random random = new Random();
int sum = 0;
int zpPeople = 0;
int zp1 = 0;
int zp2 = 0;
int zp3 = 0;

Console.WriteLine("          Месяц       ");
Console.WriteLine("    1       2       3");


for (int i = 1; i <= 12; i++)
{
    Console.Write($"{i}.");
    for (int j = 1; j <= 3; j++)
    {
        int zp = random.Next(10000, 30000);
        Console.Write($" {zp} ");
        sum += zp;
        zpPeople += zp;
        if (j == 1) 
        {
            zp1 += zp;
        }
        else if (j == 2)
        {
            zp2 += zp;
        }
        else if (j == 3)
        {
            zp3 += zp;
        }

    }
    Console.Write($"     Общая сумма: {zpPeople}");
    Console.WriteLine();
    
    zpPeople = 0;
}

Console.WriteLine($"Общая сумма за квартал: {sum}");
Console.WriteLine($"");
Console.WriteLine($"Сумма за 1 месяц = {zp1}");
Console.WriteLine($"Сумма за 2 месяц = {zp2}");
Console.WriteLine($"Сумма за 3 месяц = {zp3}");

