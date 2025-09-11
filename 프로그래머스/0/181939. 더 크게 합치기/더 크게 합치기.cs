using System;

public class Solution {
    public int solution(int a, int b) 
    {
        int answer = 0;
        int aSumB = int.Parse(a.ToString() + b.ToString());
        int bSumA = int.Parse(b.ToString() + a.ToString());
        
        if (aSumB > bSumA)
        {
            answer = aSumB;
        }
        else
        {
            answer = bSumA;
        }
        
        
        return answer;
    }
}