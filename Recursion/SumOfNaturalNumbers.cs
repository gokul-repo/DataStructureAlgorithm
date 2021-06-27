using System;

namespace DataStructureAlgorithm.Recursion
{
    public class SumOfNaturalNumbers
    {
        public void main(){
            Console.WriteLine("Sum Of Natural Numbers");
            Console.WriteLine("Recursion");
            int sum = SumOfNumbers(10);
            Console.WriteLine(sum);
            Console.WriteLine("Iterative");
            sum = SumOfNumbersIterative(10);
            Console.WriteLine(sum);
        }

        public int SumOfNumbers(int n){
            if(n>0){
                return SumOfNumbers(n-1)+n;
            }
            return 0;
        }

         public int SumOfNumbersIterative(int n){
             int sum=0;
             for(int i =1;i<=n;i++){
                 sum=sum+i;
             }
             return sum;
            
        }
    }
}