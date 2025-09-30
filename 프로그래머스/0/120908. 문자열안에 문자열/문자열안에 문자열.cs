using System;

public class Solution {
    public int solution(string str1, string str2) {
        int count = 0;
        for(int i = 0; i <= str1.Length - str2.Length; i++)
        {
            count = 0;
            for(int j = 0; j < str2.Length; j++)
            {
                if(str2[j] == str1[i + j])
                    count++;
            }
            if(count == str2.Length)
                return 1;
        }
        
        if(str1.Length == str2.Length)
        {
            count = 0;
            for(int i = 0; i < str2.Length; i++)
            {
                if(str2[i] == str1[i])
                    count++;
            }
            if(count == str2.Length)
                return 1;
        }
        return 2;
    }
}