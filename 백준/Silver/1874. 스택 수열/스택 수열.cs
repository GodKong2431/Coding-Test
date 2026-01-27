using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        Stack<int> stack = new Stack<int>();
        StringBuilder sb = new StringBuilder();
        
        int start = 1;
        
        for (int i = 0; i < n; i++)
        {
            int target = int.Parse(Console.ReadLine());

            if (target >= start)
            {
                while (target >= start)
                {
                    stack.Push(start);
                    sb.AppendLine("+");
                    start++;
                }
                stack.Pop();
                sb.AppendLine("-");
            }
            else
            {
                if (stack.Count > 0 && stack.Peek() == target)
                {
                    stack.Pop();
                    sb.AppendLine("-");
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
        }

        Console.WriteLine(sb.ToString());
    }
}