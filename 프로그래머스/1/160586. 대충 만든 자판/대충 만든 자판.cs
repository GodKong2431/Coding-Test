using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        
        Dictionary<char, int> minkeys = new Dictionary<char, int>();
        
        foreach (string key in keymap)
        {
            for (int i = 0; i < key.Length; i++)
            {
                char c = key[i];
                int count = i + 1;

                if (!minkeys.ContainsKey(c) || minkeys[c] > count)
                {
                    minkeys[c] = count;
                }
            }
        }
        
        for (int i = 0; i < targets.Length; i++)
        {
            int sum = 0;
            bool possible = true;

            foreach (char c in targets[i])
            {
                if (!minkeys.ContainsKey(c))
                {
                    possible = false;
                    break;
                }
                sum += minkeys[c];
            }

            answer[i] = possible ? sum : -1;
        }
        
        return answer;
    }
}