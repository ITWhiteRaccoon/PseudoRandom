using System;

namespace PseudoRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            ExMiddleSquare(5437, 9);
        }

        static void ExMiddleSquare(int seed, int iter)
        {
            for (int i = 0; i <= iter - 1; i++)
            {
                string strResult = ((int) Math.Pow(seed, 2)).ToString("D8");
                Console.WriteLine(strResult);
                seed = Convert.ToInt32(strResult.Substring(2, 4));
            }
        }
    }
}