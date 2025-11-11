using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        
        int num1 = 0;
        int num2 = 0;
        
        for(int i = 0; i < num_list.Length; i+=2)
        {
            num1 += num_list[i];
        }
        for(int i = 1; i < num_list.Length; i+=2)
        {
            num2 += num_list[i];
        }
        
        if(num1 != num2)
        {
            return num1 < num2 ? num2 : num1;
        }
        
        
        return num1;
    }
}