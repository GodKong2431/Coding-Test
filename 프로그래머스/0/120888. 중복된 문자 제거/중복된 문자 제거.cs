using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach(char c in my_string)
        {
            if(answer.Contains(c))
            {
                continue;
            }
            answer += c;
        }
        return answer;
    }
}