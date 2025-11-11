using System;

public class Solution {
    public string solution(string rny_string) {
        string answer = rny_string;
        if(answer.Contains("m"))
        {
            answer = answer.Replace("m","rn");
        }
        return answer;
    }
}