int floor = int.Parse(Console.ReadLine());
int num = 0;
int count = 0; 

while (floor > 0) 
{
    num = floor % 10;
    if (num == 1)
    {
        count++;
    }
    else if (num == 2) 
    {
        count--;
    }
    floor /= 10;
}
Console.WriteLine(Math.Abs(count) +1);