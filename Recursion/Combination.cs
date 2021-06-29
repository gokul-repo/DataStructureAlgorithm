using System;

namespace DataStructureAlgorithm.Recursion
{
    public class Combination
    {
         public void main(){
            Console.WriteLine("Combination nCr");
            Console.WriteLine("Recursion");
            int output = ncr(4,2);
            Console.WriteLine(output);

        }

        public int ncr(int n, int r){
            if(r==0 || n==r){
                return 1;
            }
            return ncr(n-1,r-1) +ncr(n-1,r);
        }
    }
}