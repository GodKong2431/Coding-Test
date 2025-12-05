using System;
using System.Linq;

public class Solution {
    public string[] solution(string myStr) {
        
        char[] abc = new char[] {'a', 'b', 'c'};
        string[] answer = myStr.Split(abc).Where(str => str != "").ToArray();
        
        if(answer.Length == 0)
            answer = new string[] {"EMPTY"};
        
        return answer;
    }
}