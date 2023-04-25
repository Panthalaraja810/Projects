using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.OOPS
{
    public interface  IInterface
    {

        public void Parent();
    }

    public class NewImp : IInterface 
    { 
        public void Parent()
        {
            Console.WriteLine("New implementation for Interface");
        }

        public static void Main(String[] args)
        {
            NewImp newImp = new NewImp();   
            newImp.Parent();
        }
    }
}
