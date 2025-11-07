using System;

public class Solution {
    public int[] solution(int[] arr, int k) {
        int[] answer = arr;
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(k % 2 != 0)
            {
                answer[i] *= k; 
            }
            else
            {
                answer[i] += k; 
            }
        }
            
        
        return answer;
    }
}