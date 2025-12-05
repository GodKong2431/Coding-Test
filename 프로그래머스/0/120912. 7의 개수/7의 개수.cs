using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        foreach(int num in array)
        {
            answer += num.ToString().Count(n => n == '7');
        }
        
        return answer;
    }
}