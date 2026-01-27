using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        string firstLine = Console.ReadLine();
        if (firstLine == null) return;
        
        int k = int.Parse(firstLine);
        
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < k; i++) {
            int num = int.Parse(Console.ReadLine());

            if (num == 0) {
                stack.Pop();
            } else {
                stack.Push(num);
            }
        }

        Console.WriteLine(stack.Sum());
    }
}