using System;

public class Solution {
    public int solution(int[,] board, int k) 
    {
        int answer = 0;
        for(int i = 0; i < board.GetLength(0); i++)
        {
            for(int j = 0; j < board.GetLength(1); j++)
            {
                if(i + j <= k)
                {
                    answer += board[i, j];
                }
            }
        }
        return answer;
    }
    
//     public int Sum(int num, int k)
//     {
//         if (num > k)
//             return 0;

//         int current = num * (num+1);

//         return current + Sum(num + 1, k);
//     }
}