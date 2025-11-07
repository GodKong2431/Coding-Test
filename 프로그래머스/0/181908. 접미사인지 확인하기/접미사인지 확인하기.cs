using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        int answer = 0;
        
        int strindex = my_string.Length - is_suffix.Length;
        if(strindex < 0)
        {
            return 0;
        }
        
        for(int i = strindex; i < my_string.Length; i++)
        {
            if(my_string[i] != is_suffix[i - strindex])
                return 0;
        }
        return 1;
    }
}