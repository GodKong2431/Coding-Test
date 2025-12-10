using System;

public class Solution {
    public int solution(string[] order) {
        int answer = 0;
        int americano = 4500;
        int cafeLatte = 5000;
        
        foreach(string str in order)
        {
            string temp = str.Replace("ice", "").Replace("hot", "");
            
            switch(temp)
            {
                case "americano":
                    answer += americano;
                    break;
                case "cafelatte":
                    answer += cafeLatte;
                    break;
                case "anything": 
                    answer += americano;
                    break;
            }  
        }
        
        return answer;
    }
}