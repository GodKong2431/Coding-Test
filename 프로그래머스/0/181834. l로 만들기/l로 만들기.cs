using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        char l = 'l';
        foreach(char c in myString)
        {
            if((int)c < (int)l)
            {
                answer += l;
            }
            else
            {
                answer += c;
            }
        }
        return answer;
    }
}