using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //359. Logger Rate Limiter
    //https://leetcode.com/problems/logger-rate-limiter/
    public class Logger {
     Dictionary<string,int> myDict;
    /** Initialize your data structure here. */
    public Logger() {
        myDict = new Dictionary<string,int>();
    }
    
    /** Returns true if the message should be printed in the given timestamp, otherwise returns false.
        If this method returns false, the message will not be printed.
        The timestamp is in seconds granularity. */

    // Time - O(1)
    //Space - O(n)
    public bool ShouldPrintMessage(int timestamp, string message) {
        if(myDict.ContainsKey(message)){
            int msgTime = myDict[message];
            if(timestamp >= msgTime){
                myDict[message]=timestamp+10;
                return true;
                
            }else{
                return false;
            }
            
        }else{
            myDict.Add(message,timestamp+10);
            return true;
        }
        
    }
}
}