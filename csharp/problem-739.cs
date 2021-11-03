//Runtime: 1068ms
//Memory Usage: 49.1MB

/*
Given an array of integers temperatures represents the daily temperatures, 
return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. 
If there is no future day for which this is possible, keep answer[i] == 0 instead.

 

Example 1:

Input: temperatures = [73,74,75,71,69,72,76,73]
Output: [1,1,4,2,1,1,0,0]
*/


public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        int days = 0;
            int[] answer = new int[temperatures.Length];
            for(int i = 0; i < temperatures.Length; i++)
            {
                days = 0;
                for(int j = i + 1; j < temperatures.Length; j++)
                {
                    if (temperatures[i] < temperatures[j])
                    {
                        days++;
                        answer[i] = days;
                        break;
                    }
                    else
                        days++;
                }
            }
            return answer;
    }
}
