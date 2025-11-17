using System;

public class Solution {
    public long solution(long n) {
        char[] charArr = (n.ToString()).ToCharArray();
        
        Array.Sort(charArr);
        Array.Reverse(charArr);
        
        string answer = new string(charArr);
        return long.Parse(answer);
    }
}