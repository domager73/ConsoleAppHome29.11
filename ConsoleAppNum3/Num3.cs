int count = 0; // это счетчик
int num3 = 0; // поиск числа 3
Console.WriteLine("Ведите число");
int num = int.Parse(Console.ReadLine());
for (int i = 0; num > 0; i++)
{
    num3 = num % 10;
    if (num3 == 3)
    {
        count ++;

    }
    num = num / 10;
}
if (count > 0)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}
