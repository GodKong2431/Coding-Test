using System;

public class Solution 
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2) 
    {
        int[] answer = new int[2] {0, 0};
        int denom = denom1 * denom2;
        int numer = (numer1 * denom2) + (numer2 * denom1);
        int num = 1;


        for (int i = 2; i <= Math.Min(denom, numer); i++)
        {
            if ((denom % i == 0) && (numer % i == 0))
            {
                num = i;
            }
        }
        answer[0] = numer / num;
        answer[1] = denom / num;

        return answer;
    }
}