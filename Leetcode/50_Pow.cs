namespace DataStructureAlgorithm.Leetcode
{
    //50. Pow(x, n)
    //https://leetcode.com/problems/powx-n/
    public class Pow
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return MyPow(x, n - 1) * x;

        }

        // Handling negative power and also fast approach
        public double MyPow1(double x, int n)
        {

            double N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }
            return pow(x, N);

        }
        public double pow(double x, double n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n % 2 == 0)
            {
                return pow(x * x, n / 2);
            }
            else
            {
                return x * pow(x * x, (n - 1) / 2);
            }

        }

    }
}