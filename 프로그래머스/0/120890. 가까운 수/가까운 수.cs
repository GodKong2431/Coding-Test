using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int abs = int.MaxValue;
        foreach(int num in array)
        {
            int sub = Math.Abs(num - n);
            if(abs >= sub)
            {
                if(abs == sub && answer < num)
                {
                    continue;
                }
                abs = sub;
                answer = num;
            }
        }
        return answer;
    }
}