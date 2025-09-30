using System;
using System.Collections.Generic;
public class Solution 
{
    public int solution(string dirs) 
    {
        int answer = 0;
        int[,,,] map = new int[11,11,11,11]; 
        int curX = 5;
        int curY = 5;

        for(int i = 0; i < dirs.Length; i++)
        {
            int startX = curX; 
            int startY = curY; 
            switch(dirs[i])
            {
                case 'R':
                    if (curX +1 > 10) 
                    {
                        continue;
                    }
                    curX++;
                    break;
                case 'L':
                    if (curX -1< 0) 
                    {
                        continue;   
                    }
                    curX--;
                    break;
                case 'U':
                    if (curY + 1 > 10) 
                    {
                        continue;
                    }
                    curY++;
                    break;
                case 'D':
                    if (curY -1< 0) 
                    {
                        continue;
                    }
                    curY--;
                    break;
            }

            if (map[startX,startY,curX,curY] == 1 || map[curX,curY,startX,startY] == 1)  
                continue;
            
             map[startX,startY,curX,curY] = 1;
             map[curX,curY,startX,startY] = 1;
             answer++; 
        }
        return answer;
    }
}