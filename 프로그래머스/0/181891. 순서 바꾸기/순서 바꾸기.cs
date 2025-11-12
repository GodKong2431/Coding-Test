using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length];
        for(int i = 0; i < num_list.Length-n; i++)
        {
            answer[i] = num_list[n+i];
        }
        
        Array.Copy(num_list, 0, answer, num_list.Length-n, n);
        
        return answer;
    }
}