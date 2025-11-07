using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string answer = "";
        foreach(char c in my_string)
        {
            if(c == alp[0])
            {
                answer += Char.ToUpper(c);
            }
            else
            {
                answer += c;
            }
            
        }
        return answer;
    }
}