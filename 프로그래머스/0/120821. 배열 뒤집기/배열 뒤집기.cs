using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length];
        int count = num_list.Length - 1;
        foreach(int i in num_list)
        {
            answer[count--] = i;
        }
        return answer;
    }
}