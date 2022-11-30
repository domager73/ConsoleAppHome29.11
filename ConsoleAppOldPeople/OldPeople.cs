int maxage = 0;
Console.WriteLine("Введите количество проживающих в доме")
int numPeople = int.Parse(Console.ReadLine());
int count = 0;



for (int i = 1; i <= numPeople; i++)
{
    int age = int.Parse(Console.ReadLine());
    int gender = int.Parse(Console.ReadLine());
    if (age > maxage && gender == 1)
    {
        count = i;
    }
}

Console.WriteLine($"Самый взрослый человек под номером {count}");
Console.ReadKey();
