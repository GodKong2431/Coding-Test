using System;

public class Solution {
    public string solution(string n_str) {
        string answer = "";
        bool IsZero = true;
        foreach(char c in n_str)
        {
            if(c != '0')
            {
                IsZero = false;
            }

            if(!IsZero)
            {
                answer += c;
            }
        }
        return answer;
    }
}