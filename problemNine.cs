using System;

namespace euler
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            
            int m = 2;
            int sum=0;
            
            while (sum!=1000) {
                for (int n = 1; n < m; ++n)
                {
                    a = m * m - n * n;
                    b = 2 * m * n;
                    c = m * m + n * n;

                    sum = a+b+c;
                    
                    if (sum==1000){
                        Console.WriteLine(a + " " + b + " " + c+" abc "+a*b*c+" a+b+c "+sum);
                        break;
                    }
                }
                m++;
            }
        }
    }
}
