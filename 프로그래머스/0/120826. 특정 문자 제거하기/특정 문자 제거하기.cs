using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        
        char letterToC = letter[0];
        
        foreach(char c in my_string)
        {
            if(c != letterToC)
            {
                answer += c;
            }
        }
        
        return answer;
    }
}