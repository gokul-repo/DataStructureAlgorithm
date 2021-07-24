namespace DataStructureAlgorithm.Leetcode
{
    
    //1295. Find Numbers with Even Number of Digits
    //https://leetcode.com/problems/find-numbers-with-even-number-of-digits/

    public class FindNumbersWithEvenNumberDigits
    {
       public int FindNumbers(int[] nums) {
        int n = nums.Length;
        int count=0;
        for(int i = 0;i<n ;i++){
            int digitCount=0;
            int num=nums[i];
            while(num >0){
                num=num/10;
                digitCount++;
            }
            if(digitCount % 2==0){
                count++;
            }
        }
        return count;
    }  
    }
}