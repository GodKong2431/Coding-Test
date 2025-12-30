using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int num in array) {
            if (counts.ContainsKey(num)) {
                counts[num]++;
            } else {
                counts[num] = 1;
            }
        }

        int maxCount = 0;
        int same = -1;
        bool sameCheck = false;

        foreach (var pair in counts) {
            if (pair.Value > maxCount) {
                maxCount = pair.Value;
                same = pair.Key;
                sameCheck = false;
            } else if (pair.Value == maxCount) {
                sameCheck = true;
            }
        }

        if (sameCheck) {
            return -1;
        } else {
            return same;
        }
    }
}