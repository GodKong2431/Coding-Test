using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        
        int length = numbers.Length;
        int[] answer = new int[length];
        
        if(direction == "right")
        {
            int temp = numbers[length-1];
            for(int i = 0; i < length - 1; i++)
            {
                answer[i+1] = numbers[i];
            }
            answer[0] = temp;
        }
        else
        {
            int temp = numbers[0];
            for(int i = 0; i < length - 1; i++)
            {
                answer[i] = numbers[i+1];
            }
            answer[length-1] = temp;
        }
        
        return answer;
    }
}