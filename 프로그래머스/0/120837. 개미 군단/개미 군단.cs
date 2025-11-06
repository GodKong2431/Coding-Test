using System;

public class Solution {
    public int solution(int hp) {
        int answer = 0;
        int currentHP = hp;
        
        if(currentHP >= 5)
        {
            answer += currentHP / 5;
            currentHP = currentHP % 5;
        }
        
        if(currentHP >= 3)
        {
            answer += currentHP / 3;
            currentHP = currentHP % 3;
        }
        

        answer += currentHP;

        
        return answer;
    }
}