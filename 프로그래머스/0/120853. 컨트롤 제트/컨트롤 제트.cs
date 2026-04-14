using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int temp = 0;
        
        string[] strarr = s.Split(' ');
        foreach(string str in strarr)
        {
            if(int.TryParse(str, out int num))
            {
                temp = num;
                answer += temp;
            }
            else
            {
                answer -= temp;
            }
        }
        return answer;
    }
}