using System;

public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        
        int num1 = intervals[0, 1] - intervals[0, 0] + 1;
        int num2 = intervals[1, 1] - intervals[1, 0] + 1;

        int[] answer = new int[num1 + num2];
        
        Array.Copy(arr, intervals[0, 0], answer, 0, num1);
        Array.Copy(arr, intervals[1, 0], answer, num1, num2);

        return answer;
    }
}