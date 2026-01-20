using System;
using System.Collections;
using System.Linq;

public class Solution {
    public int solution(int n) {
        bool[] isPrime = new bool[n + 1];
        Array.Fill(isPrime, true);

        if (n >= 0) isPrime[0] = false;
        if (n >= 1) isPrime[1] = false;

        for (int i = 2; i * i <= n; i++) 
        {
            if (isPrime[i]) 
            {
                for (int j = i * i; j <= n; j += i) 
                {
                    isPrime[j] = false;
                }
            }
        }

        int count = 0;
        for (int i = 0; i <= n; i++) 
        {
            if (isPrime[i]) 
            {
                count++;
            }
        }

        return count;
    }
}