using System;

namespace DataStructureAlgorithm.Algortihms
{    
    public class MatrixChainMultiplication
    {
        public int[,] dp = new int[100,100];
        public void MatrixChainMultiplication_Main(){
            //int[] arr = new int[] { 1, 2, 3, 4, 3 };
            int[] arr = new int[] { 5, 4, 6, 2, 7 };
            int n = arr.Length;
            Console.WriteLine("USing Recursion : " + MatrixChainMultiplication_Recursion(arr,1,n-1));
            for(int i =0;i<100;i++){
                for(int j=0;j<100;j++){
                    dp[i,j]=-1;
                }
            }
            Console.WriteLine("USing Memoization : " + MatrixChainMultiplication_Memoization(arr,1,n-1));
             Console.WriteLine("USing Tabulation : " + MatrixChainMultiplication_Tabulation(arr));
        }

        public int MatrixChainMultiplication_Recursion(int[] arr,int i, int j){
            if(i==j){
                return 0;                
            }
            int min=int.MaxValue;
            for(int k=i;k<j;k++){
                int count = MatrixChainMultiplication_Recursion(arr,i,k) + MatrixChainMultiplication_Recursion(arr,k+1,j)+ arr[i-1]*arr[k]*arr[j];
                if(count<min){
                    min = count;
                }
            }
            return min;            

        }

        public int MatrixChainMultiplication_Memoization(int[] arr,int i,int j){
            if(i==j){
                return 0;
            }else if(dp[i,j]!=-1){
                return dp[i,j];
            }else{
                dp[i, j] = Int32.MaxValue;
                for(int k=i;k<j;k++){
                    dp[i,j]= Math.Min(dp[i,j],MatrixChainMultiplication_Memoization(arr,i,k)+MatrixChainMultiplication_Memoization(arr,k+1,j)+ arr[i-1]*arr[k]*arr[j]);
                }
            }
            return dp[i,j];
        }       

         public int MatrixChainMultiplication_Tabulation(int[] arr){             
             int n = 5;
             int[,] m = new int[n,n];
             for(int i=1;i<n;i++){
                 m[i,i]= 0;
             }
             int j=0;
             int min=0;
             int count=0;
             for(int d=1;d<n-1;d++){
                 for(int i=1;i<n-d;i++){
                     j=i+d;
                     min=int.MaxValue;
                     for(int k=i;k<=j-1;k++){
                         count=m[i,k]+m[k+1,j]+(arr[i-1]*arr[k]*arr[j]);{
                             if(count<min){
                                 min=count;
                             }
                         }
                     }
                     m[i,j]=min;
                 }
             }
            return m[1,n-1];           
        }    

    }
}