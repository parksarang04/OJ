using System;

public class Solution {
    public int solution(int n) {
        string a = n.ToString();
        int answer = 0;
        for(int i=0; i<a.Length; i++)
        {
            answer += n%10;
            n/=10;
        }
        return answer;
    }
}