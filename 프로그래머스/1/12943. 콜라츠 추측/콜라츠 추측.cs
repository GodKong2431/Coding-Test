public class Solution {
    public int solution(int num) {
        int answer = 0;
        long temp = num;
        while(temp != 1)
        {
            if(temp % 2 == 0)
            {
                temp = DivTwo(temp);
                answer++;
            }
            else
            {
                temp = MulThreeSumOne(temp);
                answer++;
            }
            
            if(answer == 500)
            {
                return -1;
            }
        }
        return answer;
    }
    
    public long DivTwo(long num)
    {
        return num / 2;
    }
    public long MulThreeSumOne(long num)
    {
        return (num * 3) + 1;
    }
}