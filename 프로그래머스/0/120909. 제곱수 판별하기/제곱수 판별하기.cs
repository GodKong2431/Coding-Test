using System;

public class Solution {
    public int solution(int n) {
        for(int i = 0; i < n; i++)
        {
            int temp = i*i;
            
            if(temp > n)
            {
                return 2;
            }
            
            if(temp == n)
            {
                return 1;
            }
        }
        
        return 0;
    }
}