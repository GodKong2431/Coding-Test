using System;

public class Solution {
    public string solution(int age) {
        string str = age.ToString();
        string answer = "";
        foreach(char c in str)
        {
            answer += Convert.ToChar(c + '1');
        }
        
        return answer;
    }
}