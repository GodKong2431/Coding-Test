using System;
using System.Linq;

public class Solution {
    public int solution(string before, string after) {
        string sortBefore = new string(before.OrderBy(c => c).ToArray());
        string sortAfter = new string(after.OrderBy(c => c).ToArray());
        
        
        for(int i = 0; i < sortBefore.Length; i++)
        {
            if(sortBefore[i] != sortAfter[i])
                return 0;
        }
        return 1;
    }
}