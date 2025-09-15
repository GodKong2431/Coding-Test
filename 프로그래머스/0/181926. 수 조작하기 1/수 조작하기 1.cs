using System;

public class Solution {
    public int solution(int n, string control) {
        int answer = n;
        for (int i = 0; i < control.Length; i++)
        {
            if(control[i] == 'w')
            {
                answer+=1;
            }
            else if(control[i] == 's')
            {
                answer-=1;
            }
            else if(control[i] == 'd')
            {
                answer+=10;
            }
            else 
            {
                answer-=10;
            }
        }
        return answer;
    }
}