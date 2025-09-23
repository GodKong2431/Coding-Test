using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        int sum = 0;
        foreach (int i in sides)
        {
            sum += i;
            if(answer < i)
            {
                answer = i;
            }
        }
        
        return answer < (sum-answer) ? 1 : 2;
    }
}