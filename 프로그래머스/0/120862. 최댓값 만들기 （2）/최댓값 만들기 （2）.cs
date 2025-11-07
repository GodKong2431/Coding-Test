using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        
        int numbersLength = numbers.Length;
        Array.Sort(numbers);
        
        answer = numbers[numbersLength-1] * numbers[numbersLength-2];
        
        if(answer < numbers[0] * numbers[1])
            answer = numbers[0] * numbers[1];
        
        
        return answer;
    }
}