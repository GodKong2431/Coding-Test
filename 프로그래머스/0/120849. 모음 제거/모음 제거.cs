using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        string vowels = "aeiou";
        
        foreach(char c in my_string)
        {
            bool _isVowels = false;
            for(int i = 0; i < vowels.Length; i++)
            {
                if(c == vowels[i])
                {
                    _isVowels = true;
                }
            }
            if(_isVowels == false)
            {
                answer += c;
            }
        }
        
        
        return answer;
    }
}