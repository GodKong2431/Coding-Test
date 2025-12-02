using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;

        foreach(int num in num_list)
        {
            int count = 0;
            int tempNum = num;
            while(tempNum != 1)
            {
                if(tempNum % 2 == 0)
                    tempNum /= 2;
                else
                    tempNum = (tempNum-1) / 2;
                
                
                count++;
            }
            
            answer += count;
        }
        
        
        return answer;
    }
}