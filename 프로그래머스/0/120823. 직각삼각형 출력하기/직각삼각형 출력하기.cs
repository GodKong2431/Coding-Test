using System;

public class Example
{
    public static void Main()
    {
        String s;

        s = Console.ReadLine();
        Console.Clear();
        int n = Int32.Parse(s);

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}