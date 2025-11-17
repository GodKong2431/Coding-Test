public class Solution {
    public bool solution(int x) {
        bool answer = true;
        string temp = x.ToString();
        int sum = 0;
        foreach(char c in temp)
        {
            sum += c - '0';
        }
        
        if(x % sum == 0)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        
        return answer;
    }
}