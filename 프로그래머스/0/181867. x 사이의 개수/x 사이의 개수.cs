using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string myString) {
        List<int> answer = new List<int>();
        int count = 0;
        foreach(char c in myString)
        {
            
            if(c == 'x')
            {
                answer.Add(count);
                count = 0;
            }
            else
            {
                count++;
            }
        }
        answer.Add(count);
        
        return answer.ToArray();
    }
}