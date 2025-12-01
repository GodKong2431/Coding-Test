public class Solution {
    public long solution(long n) {
        long answer = 1;
        long Num = 0;
        while(Num <= n)
        {
            Num = answer * answer;
            
            if(Num == n)
            {
                return (answer+1) * (answer+1);
            }
            
            answer++;
        }
        
        
        return -1;
    }
}