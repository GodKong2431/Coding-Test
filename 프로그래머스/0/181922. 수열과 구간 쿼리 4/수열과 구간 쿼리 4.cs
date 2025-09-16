using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[arr.Length];
        Array.Copy(arr, answer, arr.Length);
        for (int i = 0; i < queries.GetLength(0);i++)
        {
            int Num = (queries[i,1]+1) - queries[i,0];
            for (int j = queries[i,0]; j < queries[i,1]+1;j++)
            {

                    if(j%queries[i,2] == 0)
                    {
                        answer[j] += 1;
                    }

            }
        }
        return answer;
    }
}