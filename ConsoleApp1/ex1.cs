using System.Globalization;

for (var i = 1; i <= 5; i++)
{
    for (var j = 1; j <= i; j++)
    {
        Console.Write($"{10 * i} ");
    }
    Console.WriteLine("");
}
