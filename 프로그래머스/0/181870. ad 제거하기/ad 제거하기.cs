using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] strArr) {
        List<string> strList = new List<string>();
        foreach(string str in strArr)
        {
            if(!str.Contains("ad"))
            {
                strList.Add(str);
            }
        }
        
        return strList.ToArray();
    }
}