using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) 
    {
        Stack<int> stack = new Stack<int>();
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(flag[i])
            {
                for(int j = 0; j < arr[i] * 2; j++)
                    stack.Push(arr[i]);
            }
            else
            {
                if(stack.Count < arr[i]) 
                    continue;
                    
                for(int j = 0; j < arr[i]; j++) 
                    stack.Pop(); 
            }
        }
        
        int[] answer = stack.ToArray();
        Array.Reverse(answer);
        return answer;
    }
}