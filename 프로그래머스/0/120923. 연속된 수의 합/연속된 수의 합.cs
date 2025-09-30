using System;

public class Solution 
{
    public int[] solution(int num, int total) 
    {
        int[] answer = new int[num];
        int firstNum = total / num;
        int sum = 0;
        while(true)
        {
            for(int i = 0; i < num;i++)
            {
                answer[i] = firstNum + i;
                sum += firstNum + i;
            }
            
            if(sum == total)
            {
                return answer;
            }
            
            firstNum--;
            sum=0;
        }

    }
}