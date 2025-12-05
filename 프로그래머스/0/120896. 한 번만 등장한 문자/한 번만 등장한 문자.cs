using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";
        SortedDictionary<char, int> count = new SortedDictionary<char, int> ();
        
        foreach(char c in s)
        {
            if(count.ContainsKey(c))
                count[c]++;
            else
                count.Add(c, 1);
        }
        
        foreach(var val in count)
        {
            if(val.Value == 1)
            {
                answer += val.Key;
            }
        }
        
        
        return answer;
    }
}