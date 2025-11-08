using System;

public class Solution {
    public int solution(string myString, string pat) 
    {
        if(myString.Length - pat.Length < 0)
        {
            return 0;
        }
        
        for(int i = 0; i <= myString.Length - pat.Length; i++)
        {
            for(int j = 0; j < pat.Length; j++)
            {
                if(myString[i + j] == pat[j])
                {
                    break;
                }
                if(j+1 == pat.Length)
                {
                    return 1;
                }
            }
        }
        
        return 0;
    }
}