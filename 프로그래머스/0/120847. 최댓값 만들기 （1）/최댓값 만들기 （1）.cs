using System;

public class Solution {
    public int solution(int[] numbers) {
        int firstNum = 0;
        int secondNum = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            if(firstNum < numbers[i])
            {
                secondNum = firstNum;
                firstNum = numbers[i];
            }
            else if(firstNum >= numbers[i] && secondNum < numbers[i])
                secondNum = numbers[i];
        }
        return secondNum * firstNum;
    }
}