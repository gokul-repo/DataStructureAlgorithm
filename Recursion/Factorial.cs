using System;

namespace DataStructureAlgorithm.Recursion
{
    public class Factorial
    {
         public void main(){
            Console.WriteLine("Factorial");
            Console.WriteLine("Recursion");
            int factorial = Fact(5);
            Console.WriteLine(factorial);
            Console.WriteLine("Iterative");
            factorial = FactIterative(5);
            Console.WriteLine(factorial);
        }

        public int Fact(int n){
            if(n >0){
                return Fact(n-1)*n;
            }
            return 1;
        }

         public int FactIterative(int n){
           int fact =1;
           for (int i=1;i<=n;i++){
               fact=fact*i;
           }
           return fact;
        }

    }
}