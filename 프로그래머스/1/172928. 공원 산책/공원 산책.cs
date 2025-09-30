using System;

public class Solution 
{
    public int[] solution(string[] park, string[] routes) 
    {
        int[] answer = new int[2];
        for(int i = 0; i < park.Length; i++) 
        {
            for(int j = 0; j < park[0].Length; j++) 
            {
                if(park[i][j] == 'S') 
                {
                    answer[0] = i;
                    answer[1] = j;
                }
            }
        }
        
        foreach(string s in routes) 
        {
            string[] routeSplit = s.Split(' ');
            string direction = routeSplit[0];
            int distance = int.Parse(routeSplit[1]);
            bool can = true;
            
            switch(direction) 
            {
                case "E" :
                    for(int i = 1; i <= distance; i++) 
                    {
                        if(i + answer[1] >= park[0].Length || park[answer[0]][i+answer[1]] == 'X')
                        {
                            can = false;
                            break;
                        }
                    }
                    if(can) 
                        answer[1] += distance;
                    break;
                    
                    
                case "W" :
                    for(int i = 1; i <= distance; i++) 
                    {
                        if(answer[1] - i < 0 || park[answer[0]][answer[1] - i] == 'X') 
                        {
                            can = false;
                            break;
                        }
                    }
                    if(can) 
                        answer[1] -= distance;
                    break;
                    
                    
                case "S" :
                    for(int i = 1; i <= distance; i++) 
                    {
                        if(answer[0] + i >= park.Length || park[answer[0]+i][answer[1]] == 'X')
                        {
                            can = false;
                            break;
                        }
                    }
                    if(can) 
                        answer[0] += distance;
                    break;
                    
                    
                case "N":
                    for(int i = 1; i <= distance; i++) 
                    {
                        if(answer[0] - i < 0 || park[answer[0] - i][answer[1]] == 'X')
                        {
                            can = false;
                            break;
                        }
                    }
                    if(can) 
                        answer[0] -= distance;
                    break;
                    
                    
            }
        }
        return answer;
    }
}