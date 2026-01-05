using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        
        foreach(char c in s)
        {
            char tmep = c;
            int count = 0;
            while (count < index)
            {
                tmep++;
                if (tmep > 'z')
                    tmep = 'a';

                if (!skip.Contains(tmep))
                {
                    count++;
                }
            }
            answer += tmep;
        }
        return answer;
    }
}