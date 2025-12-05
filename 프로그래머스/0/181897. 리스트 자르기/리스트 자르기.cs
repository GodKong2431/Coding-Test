using System;
using System.Collections.Generic;

public class Solution {
    public List<int> answer = new List<int>();
    
    public int[] solution(int n, int[] slicer, int[] num_list) {
        switch(n)
        {
            case 1:
                Case1(slicer, num_list);
                break;
            case 2:
                Case2(slicer, num_list);
                break;
            case 3:
                Case3(slicer, num_list);
                break;
            case 4:
                Case4(slicer, num_list);
                break;
        }
        return answer.ToArray();
    }
    
    public void Case1(int[] slicer, int[] num_list)
    {
        for(int i = 0; i <= slicer[1]; i++)
        {
            answer.Add(num_list[i]);
        }
    }
    public void Case2(int[] slicer, int[] num_list)
    {
        for(int i = slicer[0]; i < num_list.Length; i++)
        {
            answer.Add(num_list[i]);
        }
    }
    public void Case3(int[] slicer, int[] num_list)
    {
        for(int i = slicer[0]; i <= slicer[1]; i++)
        {
            answer.Add(num_list[i]);
        }
    }
    public void Case4(int[] slicer, int[] num_list)
    {
        for(int i = slicer[0]; i <= slicer[1]; i+=slicer[2])
        {
            answer.Add(num_list[i]);
        }
    }
}