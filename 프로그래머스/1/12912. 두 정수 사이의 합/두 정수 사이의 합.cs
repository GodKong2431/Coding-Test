using System;
public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        int sNum = Math.Min(a, b);
        int bNum = Math.Max(a, b);
        
        for(int i = sNum; i <= bNum; i++)
        {
            answer += i;
        }
        
        return answer;
    }
}