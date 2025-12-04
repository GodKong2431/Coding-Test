using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        for(int i = 0; i <= myString.Length - pat.Length; i++)
        {
            if(myString.Substring(i, pat.Length).Contains(pat))
                answer++;
        }
        return answer;
    }
}