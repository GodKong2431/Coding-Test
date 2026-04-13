using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int temp = 0;
        for(int i = 1; temp < n; i++)
        {
            temp = 1;
            for(int j = i; j > 0; j--)
            {
                temp *= j;

                answer = i;
                if(temp > n)
                {
                    answer -= 1;
                }
            }
        }

        return answer;
    }
}