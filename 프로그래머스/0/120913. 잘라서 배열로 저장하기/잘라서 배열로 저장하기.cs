using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string my_str, int n) {
        List<string> answer = new List<string>();

        for (int i = 0; i < my_str.Length; i += n) {
            int length = Math.Min(n, my_str.Length - i);
            answer.Add(my_str.Substring(i, length));
        }

        return answer.ToArray();
    }
}