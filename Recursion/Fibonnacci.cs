using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Recursion
{
    public class Fibonnacci
    {
        static Dictionary<int,long> _memo = new Dictionary<int, long>();
         public void main(){
            Console.WriteLine("Fibonnoci");
            Console.WriteLine("Recursion");
            int fibo = Fibbo(5);
            Console.WriteLine(fibo);    
            Console.WriteLine("Recursion with Memoization");
            var fibo1 = FibboMemoization(50);
            Console.WriteLine(fibo1);        
        }

        public int Fibbo(int n){
            if (n<=1){
                return n;
            }            
            return Fibbo(n-2)+Fibbo(n-1);
        }

         public long FibboMemoization(int n){
            if (n<=1){
                return n;
            } else if (_memo.ContainsKey(n))
                return _memo[n];

            var value = FibboMemoization(n - 2) + FibboMemoization(n - 1);
            _memo[n] = value;
            return value;           
            
        }

    }
}