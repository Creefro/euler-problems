using System;

namespace euler
{
    class Program
    {
        static void Main(string[] args)
        {
            int r,sum=0,temp;

            for(int birinciSayi=999;birinciSayi>=100;birinciSayi--){
                for(int ikinciSayi=91;ikinciSayi>10;ikinciSayi--){
                    int n=11*birinciSayi*ikinciSayi;
                    
                    temp=n;    

                    
                    while(n>0){    
                        r=n%10;  //getting remainder
                        sum=(sum*10)+r;    
                        n=n/10;    
                    }

                    if(temp==sum){
                        Console.WriteLine("palindrom: "+temp);
                    }
                    
                }
            } 
        }
    }
}
