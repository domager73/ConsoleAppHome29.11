int num = int.Parse(Console.ReadLine());

int count = 0;
for (int i = 1; i <= num / 2; i++)
{
    for (int i1 = i; i1 <= num / 2; i1++)
    {
        for (int i2 = i1; i2 <= num / 2; i2++)
        {
            int chislo = num - (i + i1 + i2);
            if (chislo >= i2)
            {
                if (num == i + i1 + i2 + chislo)
                {
                    count++;
                }
            }
        }
    }
}
Console.WriteLine(count);
