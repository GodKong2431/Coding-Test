using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        
        if(!arr.Contains(2))
            return new int[]{-1};
        
        int size = (Array.LastIndexOf(arr, 2) - Array.IndexOf(arr, 2))+1;
        int[] answer = new int[size];
        
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] =  arr[i + Array.IndexOf(arr, 2)];
        }
        
        return answer;
    }
}