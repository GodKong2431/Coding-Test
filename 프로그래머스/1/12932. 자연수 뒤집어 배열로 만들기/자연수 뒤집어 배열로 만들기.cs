using System;

public class Solution {
    public int[] solution(long n) {
        char[] numArr = n.ToString().ToCharArray();
        
        Array.Reverse(numArr);
        
        int[] answer = new int[numArr.Length];
        for(int i = 0; i < numArr.Length; i++)
        {
            answer[i] = numArr[i] - '0';
        }
        return answer;
    }
}