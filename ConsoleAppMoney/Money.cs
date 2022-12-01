Console.Write("Ведите сумму: ");
double num = double.Parse(Console.ReadLine());
int prov = 0;
int step = 0;

int count = 0;
while (num > 0)
{
    for (int i = 0; i <= 6; i++)
    {
        if (num >= Math.Pow(2, i))
        {
            step = i;
        }

    }
    num = num - Math.Pow(2, step);
    count++;
}
Console.WriteLine($"Минимальное количесвтво купюр {count}");

