using System;

namespace DataStructureAlgorithm.Recursion
{
    public class TaylorSeries
    {
        public static double p = 1;
        public static double f = 1;
        public static double sum = 1;

         public void main()
        {
            Console.WriteLine("Taylor Series");
            Console.WriteLine("Recursion");
            var output = CalculateTaylorSeries(4,15);
            Console.WriteLine(output);  
             Console.WriteLine("Recursion - Horner's rule");
            output = CalculateTaylorSeriesHornerRule(4,15);
            Console.WriteLine(output);   
        }

        //In this method we do operations in returning time
        //Number of multiplications are more here
        public double CalculateTaylorSeries(int x,int n){
            if(n==0){
                return 1;
            }            
            var result = CalculateTaylorSeries(x,n-1);
            p=p*x;
            f=f*n;
            return result+p/f;
        }

        //In this method we do opertions in calling time
        //Horners rules help to educe number of multiplications from O(n^2) to O(n)
        public double CalculateTaylorSeriesHornerRule(int x,int n){
            if(n==0){
                return sum;
            }            
           sum = 1+x * sum/n;                        
           return CalculateTaylorSeriesHornerRule(x,n-1);
        }
    }
}