using System;

namespace euler
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b=0;
            int sum = 0;
            int even=0;
            do
            {
                sum = a+b;
                a=b;
                b= sum;

                if(sum %2==0){
                    even += sum;
                }
            }while(sum<=4000000);
            Console.WriteLine(Convert.ToString(even));
        }
    }
}
