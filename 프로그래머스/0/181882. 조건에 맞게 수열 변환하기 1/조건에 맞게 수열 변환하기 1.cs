using System;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[arr.Length];
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] < 50)
            {
                answer[i] = arr[i] % 2 != 0 ? arr[i] * 2 : arr[i];
            }
            else if(arr[i] >= 50)
            {
                answer[i] = arr[i] % 2 == 0 ? arr[i] / 2 : arr[i];
            }
        }
        
        return answer;
    }
}