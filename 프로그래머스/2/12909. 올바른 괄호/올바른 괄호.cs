using System;

public class Solution {
    public bool solution(string s) {
        bool answer = true;
        int open = 0;
        int close = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
                open++;
            else if(open > 0 && s[i] == ')')
                open--;
            else if(s[i] == ')')
                close++;
        }
        return open == 0 && close == 0? true: false;
            

    }
}