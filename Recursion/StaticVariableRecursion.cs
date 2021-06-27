using System;

namespace DataStructureAlgorithm.Recursion
{
    public class StaticVariableRecursion
    {
        static int staticVar=0;
         public void main(){
            Console.WriteLine("Normal Recursion :");
            int n = Recursion(5);
            Console.WriteLine(n);
            Console.WriteLine("Without Static variable Recursion :");            
            n= WithoutStaticVarRecursion(5);
            Console.WriteLine(n);
            Console.WriteLine("With Static variable Recursion :");
            n= WithStaticVarRecursion(5);
            Console.WriteLine(n);
        }

        public int Recursion(int n){
            if (n >0){
                return Recursion(n-1)+n;
            }
            return 0;
        }

        public int WithoutStaticVarRecursion(int n){
            int x=0;
            if(n>0){
                x++;
                return WithoutStaticVarRecursion(n-1)+x;
            }
            return 0;

        }

        public int WithStaticVarRecursion(int n){            
            if(n>0){
                staticVar++;
                return WithStaticVarRecursion(n-1)+staticVar;
            }
            return 0;

        }
    }
}