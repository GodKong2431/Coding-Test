using System;

public class Solution {
    public int solution(int num1, int num2) {
        double divNum = (double)num1 / num2 * 1000;
        int answer = (int)divNum;
        return answer;
    }
}