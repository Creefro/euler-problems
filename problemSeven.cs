using System;

namespace euler
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            int div=2;
            int temp;
            int sayac=0;
            
            while(sayac!=10001){

                temp=number;

                while (number !=1)
                {
                    if(number%div!=0) div++;
                    else number = number/div;
                }
                if(temp==div){
                    sayac++;
                    Console.WriteLine(temp+" sayisi "+sayac+". asal sayıdır.");
                }
                div = 2;
                number=temp;
                number++;
		}
        }
    }
}
