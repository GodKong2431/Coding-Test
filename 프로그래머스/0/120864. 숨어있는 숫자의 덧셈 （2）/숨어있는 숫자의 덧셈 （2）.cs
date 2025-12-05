using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string temp = "";
        foreach(char c in my_string)
        {
            if(int.TryParse(c.ToString(), out int n))
            {
                temp += c;
            }
            else
            {
                int.TryParse(temp, out int num);
                answer += num;
                temp = "";
            }
        }
        int.TryParse(temp, out int end);
        answer += end;
        return answer;
    }
}