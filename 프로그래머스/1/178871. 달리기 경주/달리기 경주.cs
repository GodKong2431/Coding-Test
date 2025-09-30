using System;
using System.Collections.Generic;

public class Solution 
{
    public string[] solution(string[] players, string[] callings) 
    {
        Dictionary<string, int> answer = new Dictionary<string, int>();
        int index = 0;
        string temp = "";
        for(int i = 0; i < players.Length; i++)
        {
            answer.Add(players[i], i);
        }

        for(int i = 0; i < callings.Length; i++)
        {
            index = answer[callings[i]];
            
            answer[players[index]]--;
            answer[players[index-1]]++;
            
            temp = players[index];
            players[index] = players[index - 1];
            players[index - 1] = temp;
            
            
        }

        return players;
    }
}