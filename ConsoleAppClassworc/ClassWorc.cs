using System;
public class Dima
{
    static void Main(string[] args) 
    {
        int count = 0;
        for (int i = 0; i <= 10; i++)
        {
            for (int j = 0; j <= 10; j++)
            {
                for (int h = 0; h <= 10; h++)
                {
                    for (int g = 0; g <= 10; g++)
                    {
                        if (i + j == 8 && j + h == 8 && g - h == 6 && i + g == 13)
                        {
                            count++;
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }

}