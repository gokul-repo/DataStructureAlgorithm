using System;

namespace DataStructureAlgorithm.Recursion
{
    public class TowerOfHanoi
    {
        public void main()
        {
            Console.WriteLine("Tower of Hanoi");
            TOH(3, 1, 2, 3);
        }

        public void TOH(int n, int A, int B, int C){
            if(n>0){
                TOH(n-1,A,C,B);
                Console.WriteLine("Moved disc from {0} to {1} ", A,C);
                TOH(n-1,B,A,C);
            }
        }

    }
}