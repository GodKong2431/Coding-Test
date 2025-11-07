using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> numList = new List<int>();
        
        for(int i = 1; i <= n; i++)
        {
            
            if(n % i == 0 && !numList.Contains(i))
            {
                numList.Add(i);

            }
        }
        
        
        int[] answer = numList.ToArray();
        Array.Sort(answer);
        return answer;
    }
}