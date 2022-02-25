using System;

namespace euler
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 600851475143;
            int div=2;
            while (number !=1)
            {
                //Console.WriteLine(Convert.ToString(number));
                if(number%div!=0) div++;
                else{
                     Console.WriteLine(Convert.ToString(div));
                    number = number/div;}
            };
        }
    }
}
