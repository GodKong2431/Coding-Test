using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;

        
        foreach (char c in order.ToString())
        {
            if((c != '0') && (c % 3 == 0))
            {
                answer++;
            }
        }
        
        return answer;
    }
}