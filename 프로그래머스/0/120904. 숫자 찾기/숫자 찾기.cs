using System;

public class Solution {
    public int solution(int num, int k) {
        string strNum = num.ToString();
        
        for(int i = 0; i < strNum.Length; i++)
        {
            if(strNum[i] == k.ToString()[0])
            {
                return i+1;
            }
        }
        
        return -1;
    }
}