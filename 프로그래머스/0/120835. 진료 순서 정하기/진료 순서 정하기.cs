using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] emergency) {
        return emergency
            .Select(x => emergency.Count(e => e > x) + 1)
            .ToArray();
    }
}