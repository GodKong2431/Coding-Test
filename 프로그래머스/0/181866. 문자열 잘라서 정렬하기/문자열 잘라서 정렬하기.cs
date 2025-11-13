using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string myString) {
        string[] answer = myString.Split('x');
        List<string> list = new List<string>(answer);


        while (list.Remove(""))
        {
        
        }

        string[] newArray = list.ToArray();
        Array.Sort(newArray);
        return newArray;
    }
}