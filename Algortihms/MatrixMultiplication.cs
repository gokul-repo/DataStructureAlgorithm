using System;

namespace DataStructureAlgorithm.Algortihms
{
    public class MatrixMultiplication
    {
        public void MM_Main(){
            int[,] matrixA = new int[,]{{1,1,1,1},
                               {2,2,2,2},
                               {3,3,3,3},
                               {4,4,4,4}};
            int[,] matrixB = new int[,]{{4,4,4,4},
                               {3,3,3,3},
                               {2,2,2,2},
                               {1,1,1,1}};
            var matrixC = MatrixMultiply(matrixA,matrixB,4);
            Print(matrixC,4);
        }

        public int[,] MatrixMultiply(int[,] A,int[,] B,int n){
            int[,] C = new int[n,n];

            for(int i=0;i<n;i++){
                for(int j=0;j<n;j++){
                    C[i,j]=0;
                    for(int k=0;k<n;k++){
                        C[i,j]=C[i,j]+A[i,k]*B[k,j];
                    }
                }
            }
            return C;
        }

        public void Print(int[,] A, int n){
            for(int i=0;i<n;i++){
                for(int j=0;j<n;j++){
                    Console.Write(A[i,j]+"  ");
                }
                Console.WriteLine();
            }
        }
    }
}