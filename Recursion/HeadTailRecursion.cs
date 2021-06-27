using System;

namespace DataStructureAlgorithm.Recursion
{
    public class HeadTailRecursion
    {
        public void main(){
            Console.WriteLine("Head Recursion :");
            HeadRecursion(5);
            Console.WriteLine();
            Console.WriteLine("Tail Recursion :");
            TailRecursion(5);
            Console.WriteLine();
             Console.WriteLine("Tree Recursion :");
            TreeRecursion(4);
            Console.WriteLine();
            Console.WriteLine("Indirect Recursion :");
            IndirectRecursionA(20);
            Console.WriteLine();
            Console.WriteLine("Nested Recursion :");
            int n=NestedRecursionA(95);
            Console.WriteLine(n);
        }

        public void HeadRecursion(int n){
            if(n>0){
                Console.Write(n + " ");
                HeadRecursion(n-1);
            }
        }

        public void TailRecursion(int n){
            if(n>0){
                TailRecursion(n-1);
                Console.Write(n + " ");                
            }
        }

         public void TreeRecursion(int n){
            if(n>0){
                Console.Write(n + " "); 
                TreeRecursion(n-1);
                TreeRecursion(n-1);                              
            }
        }

        public void IndirectRecursionA(int n){
            if(n>0){
                Console.Write(n+ " ");
                IndirectRecursionB(n-1);
            }
        }

        public void IndirectRecursionB(int n){
            if(n>1){
                Console.Write(n+ " ");
                IndirectRecursionA(n/2);
            }
        }

        public int NestedRecursionA(int n){
            if(n>100){
                return n-10;
            }
            return NestedRecursionA(NestedRecursionA(n+11));
        }


    }
}