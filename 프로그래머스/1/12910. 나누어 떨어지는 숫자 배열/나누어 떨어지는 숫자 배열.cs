using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> numlist = new List<int> ();
        
        foreach(int num in arr)
        {
            if(num % divisor == 0)
            {
                numlist.Add(num);
            }
        }
        
        if(numlist.Count == 0)
        {
            numlist.Add(-1);
        }
        int[] answer = numlist.ToArray();
        Array.Sort(answer); 

        return answer;
    }
}