using System;

public class Solution {
    public int solution(int[] box, int n) {
        int answer = 1;
        foreach(int num in box)
        {
            answer *= num / n;
        }
        return answer;
    }
}