using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int mapLengthX = board[0] / 2;
        int mapLengthY = board[1] / 2;
        int[] answer = new int[]{0,0};
        
        foreach(string str in keyinput)
        {
            switch(str)
            {
                case "up":
                    if(answer[1]+1 <= mapLengthY)
                        answer[1]+=1;
                    break;
                case "down":
                    if(answer[1]-1 >= -mapLengthY)
                        answer[1]-=1;
                    break;
                case "left":
                    if(answer[0]-1 >= -mapLengthX)
                        answer[0]-=1;
                    break;
                case "right":
                    if(answer[0]+1 <= mapLengthX)
                        answer[0]+=1;
                    break;
            }
        }
        return answer;
    }
}