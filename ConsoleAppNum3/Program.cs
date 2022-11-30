int count = 0; // это счетчик
int num3 = 0; // поиск числа 3
Console.WriteLine("Ведите число");
int num = int.Parse(Console.ReadLine());
while (num > 0) 
{
    num3 = num % 10;
    Console.WriteLine(num3);
    if (num3 == 3) 
    {
        count++;

    }
    num = num / 10;
}
Console.WriteLine($"число 3 встречаеться {count} раз");

