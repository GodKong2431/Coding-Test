using System;

public class Solution {
    public int solution(int a, int d, bool[] included) {
        int[] aSNum = new int[included.Length];
        int answer = 0;
        for (int i = 0; i < included.Length; i++)
        {
            aSNum[i] = a + (d * i);
            if (included[i] == true)
            {
                answer += aSNum[i];
            }
        }
        
        return answer;
    }
}