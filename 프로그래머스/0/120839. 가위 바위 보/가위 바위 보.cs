using System;

public class Solution {
    public string solution(string rsp) {
        string answer = "";
        
        foreach(char c in rsp)
        {
            if(c == '0')
            {
                answer += "5";
            }
            else if(c == '2')
            {
                answer += "0";
            }
            else
            {
                answer += "2";
            }
        }
        
        return answer;
    }
}