using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Algortihms
{
    public class Fibonnacci
    {
        public Dictionary<int,double> memo= new Dictionary<int,double>();
        public void Fibonnacci_main(){
            Console.WriteLine("--------------Fibonnacci - Memoization---------");
            Console.WriteLine(FiboMemoization(8));
            Console.WriteLine("--------------Fibonnacci - Tabulation---------");
            Console.WriteLine(FiboTabulation(8));
        }

        public double FiboMemoization(int n){
            if(n<=1){
                return n;
            }else if(memo.ContainsKey(n)){
                return memo[n];
            }else{
                double value = FiboMemoization(n-2)+FiboMemoization(n-1);
                memo[n]=value;
                return value;
            }
        }

        public double FiboTabulation(int n ){
            int[] fib = new int[n+1];
            fib[0]=0;
            fib[1]=1;
            for(int i=2;i<=n;i++){
                fib[i]=fib[i-2]+fib[i-1];
            }
            return fib[n];
        }
    }
}