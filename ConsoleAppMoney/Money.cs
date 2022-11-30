double count = 0, sumAll = 0, res = 0;
int bound = 0, i = 6;

Console.WriteLine("Введи сумму ");
int sum = int.Parse(Console.ReadLine());

if (sum == 1)
{
    sumAll = 1;
    Console.WriteLine(sumAll);
    Console.ReadKey();
}
do
{
    if (sum < Math.Pow(2, i))
    {
        --i;
        continue;
    }

    count = sum / Math.Pow(2, i);
    bound = (int)count;
    sumAll += bound;
    res = sum % Math.Pow(2, i);
    int residue = (int)res;
    if (residue == 1)
    {
        sumAll += 1;
    }
    sum = residue;
    --i;

} while (i != 0);

Console.WriteLine(sumAll);
Console.ReadKey();
