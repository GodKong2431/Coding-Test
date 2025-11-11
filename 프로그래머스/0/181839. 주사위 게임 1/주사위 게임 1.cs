using System;

public class Solution {
    public int solution(int a, int b) {
        int[] answer = new int[] {a, b};
        bool[] isAnswer = new bool[2]; 
        
        for(int i = 0; i < answer.Length; i++)
        {
            isAnswer[i] = answer[i] % 2 != 0 ? true : false; 
        }
        
        if(isAnswer[0] && isAnswer[1])
        {
            return (a*a)+(b*b);
        }
        if(isAnswer[0] || isAnswer[1])
        {
            return 2 * (a+b);
        }
        
        return (int)MathF.Abs(a-b);
    }
}