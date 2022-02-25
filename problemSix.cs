using System;

namespace euler
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            int sum1 =0;
            int sum2 = 0;
            for(int i = 1;i<=number;i++){
                sum1+=i*i;
                sum2 +=i;
            }

            Console.WriteLine("The answer is : "+((sum2*sum2)-sum1));
        }
    }
}
