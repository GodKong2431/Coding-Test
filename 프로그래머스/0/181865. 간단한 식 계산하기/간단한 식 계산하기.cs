using System;

public class Solution {
    public int solution(string binomial) {
        string[] answer = binomial.Split(' ');
        int num1 = int.Parse(answer[0]);
        int num2 = int.Parse(answer[2]);
        if(answer[1] != "*")
        {
            return answer[1] == "+" ? num1 + num2 : num1 - num2;
        }
        
        return num1 * num2;
    }
}