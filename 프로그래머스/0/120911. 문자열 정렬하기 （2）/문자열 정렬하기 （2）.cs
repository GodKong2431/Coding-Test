using System;

public class Solution {
    public string solution(string my_string) 
    {
        string answer = my_string.ToLower();
        char[] c = answer.ToCharArray();
        
        Array.Sort(c);
        answer = new string(c);
        return answer;
    }
}