using System;

public class Solution {
    public string solution(string[] my_strings, int[,] parts) {
        string answer = "";
        int index = 0;
        foreach(string str in my_strings)
        {
            int start = parts[index, 0];
            int length = parts[index, 1] - start + 1;
            answer += str.Substring(start, length);
            index++;
            
        }
        return answer;
    }
}