using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        
        int num = my_string.Length - n;
        
        for(int i = num; i < my_string.Length; i++)
        {
            answer += my_string[i];
        }
        
        return answer;
    }
}