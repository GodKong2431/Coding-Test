using System;

public class Solution {
    public string solution(string my_string, int[] indices) {
        string answer = my_string;
        int[] sortArr = indices;
        Array.Sort(sortArr);
        Array.Reverse(sortArr);
        foreach(int c in sortArr)
        {
            answer = answer.Remove(c, 1);
        }
        return answer;
    }
}