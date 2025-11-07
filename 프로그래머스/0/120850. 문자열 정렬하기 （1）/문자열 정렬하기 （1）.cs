using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string) {
        List<int> num_List = new List<int>();
        
        foreach(char c in my_string)
        {
            bool isNum = int.TryParse(c.ToString(), out int num);
            
            if(isNum == true)
            {
                num_List.Add(num);
            }
        }
        int[] answer = num_List.ToArray();
        Array.Sort(answer);
        return answer;
    }
}