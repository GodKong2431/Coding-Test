public class Solution {
    public int solution(string s) {
        string answer = "";
        bool isNnum = true;
        
        foreach(char c in s)
        {
            if(c == '-') isNnum = false;  
            else
            {
                if(c == '+') isNnum = true;    
                else answer += c;
            }
        }
        return isNnum == true ? (int.Parse(answer)) : (int.Parse(answer)) * -1;
    }
}