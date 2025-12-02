using System;

public class Solution {
    public string solution(string myString, string pat) {
        string answer = "";
        
        for(int i = 0; i < myString.LastIndexOf(pat); i++)
        {
            answer += myString[i];
        }
        
        return answer + pat;
    }
}