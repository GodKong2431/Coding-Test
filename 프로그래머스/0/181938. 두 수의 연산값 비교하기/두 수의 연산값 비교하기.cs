using System;

public class Solution {
    public int solution(int a, int b) 
    {
        
        int answer = 0;
        int aNum = int.Parse(a.ToString() + b.ToString());
        int bNum = a * b * 2;
        
        if(aNum == bNum)
        {
            return a + b;
        }
        
        return Math.Max(aNum, bNum);
    }
}