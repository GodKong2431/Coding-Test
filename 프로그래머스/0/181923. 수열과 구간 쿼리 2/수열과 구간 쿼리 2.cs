using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] arr, int[,] queries) 
    {
        int[] answer = new int[queries.GetLength(0)];
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int min = arr.Max() + 1;
            for (int j = queries[i, 0]; j < queries[i, 1]+1; j++)
            {
                if (arr[j] > queries[i,2] && min > arr[j])
                {
                    answer[i] = arr[j];
                    min = arr[j];
                }          
            }
            if(answer[i] == 0)
            {
                 answer[i] = -1;
            }
        }
         return answer;
    }
}