using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.OOPS
{
    public abstract class Abstraction
    {
        public abstract void Employee();

        public void company()
        {
            Console.WriteLine("my company");
        }
    }

    public class Child: Abstraction
    {
        public override void Employee()
        {
            Console.WriteLine("overriden method");
        }

    }

    public class ImplementationEmployee
    {
        public static void aain(string[] args)
        {
            Child child = new Child();  
            child.Employee();
            child.company();

        }   
    }


}

