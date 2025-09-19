using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> stk = new List<int> { };
        int i = 0;
        for (; i < arr.Length;)
        {
            if (stk.Count == 0)
            {
                stk.Add(arr[i]);
                i++;
            }
            else if (stk.Count > 0 && stk[stk.Count - 1] < arr[i])
            {
                stk.Add(arr[i]);
                i++;
            }
            else stk.RemoveAt(stk.Count - 1);
        }
        return stk.ToArray();
    }
}