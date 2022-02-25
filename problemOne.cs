using System;

namespace euler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = 1000;
            for (int i =1;i<number;i++){
                if(i%3==0 || i%5 == 0){
                    sum += i;
                }
            }
            Console.WriteLine(Convert.ToString(sum));
        }
    }
}
