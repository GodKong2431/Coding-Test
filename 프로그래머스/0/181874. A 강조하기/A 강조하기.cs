using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        foreach(char c in myString)
        {
            if(c == 'a' || c == 'A')
            {
                answer += Char.ToUpper(c);
            }
            else
            {
                answer += Char.ToLower(c);
            }
        }
        return answer;
    }
}