using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int[,] answer = new int[num_list.Length / n,n];
        
        int index1 = 0;
        int index2 = 0;
        
        foreach(int num in num_list)
        {
            answer[index2, index1] = num;
            ++index1;
            if(index1 == n)
            {
                index1 = 0;
                index2++;
            }
        }
        return answer;
    }
}