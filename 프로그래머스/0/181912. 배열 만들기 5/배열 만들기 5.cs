using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        List<int> answer = new List<int> ();
        foreach(string str in intStrs)
        {
            string temp = "";
            for(int i = s; i < s+l; i++)
            {
                temp += str[i];
            }
            
            int tempNum = int.Parse(temp);
            
            if(tempNum > k)
            {
                answer.Add(tempNum);
            }
        }
        return answer.ToArray();
    }
}