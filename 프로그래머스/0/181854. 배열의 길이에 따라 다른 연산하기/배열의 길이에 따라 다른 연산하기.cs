using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int[] answer = arr;
        
        int index = arr.Length % 2 == 0 ? 1:0;
        
        for(int i = index; i < arr.Length; i+=2)
        {
            answer[i] += n;
        }
        return answer;
    }

}