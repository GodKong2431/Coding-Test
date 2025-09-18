using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> answer = new List<int>();
        int Num = n;
        answer.Add(Num);
        while(Num != 1)
        {
            if(Num % 2 == 0)
            {
                Num /= 2;
                answer.Add(Num);
            }
            else
            {
                Num = (Num * 3) +1;
                answer.Add(Num);
            }
        }
        return answer.ToArray();
    }
}