using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class FileName2
    {
        static int num1;
        static int num2;
       public void arithmeticEx(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
       
        public void primeNumber(int num)
        {
            Console.Write("Enter the value: ");
           
            Boolean isPrime = true;

            for(int i=2; i<num/2; i++)
            { 
                if(num%2==0) { 
                isPrime = false;
                }
            }

            if(isPrime==true)
            {
                Console.Write(num+" is a prime");
            }
            else
            {
                Console.Write(num + " is not prime");
            }


        }
    }
}
