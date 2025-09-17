using System;
using System.Linq;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        string answer = "";
        
        for (int i = 0; i < Math.Min(my_string.Length,is_prefix.Length); i++)
        {
            answer += my_string[i];
        }
        

        return answer == is_prefix ? 1:0;

    }
}