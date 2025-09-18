using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) 
    {
        List<int> answer = new List<int>();
        
        for (int i = l;i <= r;i++)
        {
            string str = i.ToString();
            bool isZeroFive = false;
            for(int j = 0 ; j < str.Length; j++)
            {
                if(str[j] == '0' || str[j] == '5')  
                    isZeroFive = true;
                else
                {
                    isZeroFive = false;
                    break;
                }
            }
            if(isZeroFive)
                answer.Add(i);
        }
        if (answer.Count == 0)
            answer.Add(-1);
        
        return answer.ToArray();
    }
}