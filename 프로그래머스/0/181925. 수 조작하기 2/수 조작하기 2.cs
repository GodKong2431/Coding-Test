using System;

public class Solution {
    public string solution(int[] numLog) {
        string answer = "";
        for(int i = 0; i < numLog.Length-1; i++)
        {
            if (numLog[i]+1 == numLog[i+1]) answer+='w';
            else if(numLog[i]-10 == numLog[i+1]) answer+='a';
            else if(numLog[i]+10 == numLog[i+1]) answer+='d';
            else if(numLog[i]-1 == numLog[i+1]) answer += 's';
        }
        return answer;
    }
}