using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int minNum = arr.Min();
        if(arr.Length == 1)
            return new int[]{-1};
        return arr.Where(x => x != minNum).ToArray();
    }
}