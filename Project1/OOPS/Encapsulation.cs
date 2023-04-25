using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Project1.OOPS
{
    internal class Encapsulation
    {
        private String Ename ="Raja";
        public static double Salary { get; set; } //getters and setters for the variable Salary

    }

    internal class EncapEx
    {
        public static void aain(String[] args)
        {

            Console.WriteLine(Encapsulation.Salary);  //printing salry before setting the value 
            Encapsulation.Salary = 80000;       //intializing value
            Console.WriteLine(Encapsulation.Salary); //printing the Salary after the setter

            
        }
    }
}
