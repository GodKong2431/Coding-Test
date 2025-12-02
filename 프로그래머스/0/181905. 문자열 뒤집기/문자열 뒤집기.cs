using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = "";
        int count = 0;
        for(int i = 0; i < my_string.Length; i++)
        {
            if(s <= i && i <= e)
            {
                answer += my_string[e - count++];
            }
            else
            {
                answer += my_string[i];
            }
        }
        
        return answer;
    }
}