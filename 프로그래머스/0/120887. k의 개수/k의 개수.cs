using System;
using System.Linq;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        
        for(; i <= j; i++)
        {
            int count = i.ToString().Count(c => c == (char)('0' + k));
            answer += count;
        }
        
        return answer;
    }
}