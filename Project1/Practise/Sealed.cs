using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Practise
{
     public sealed class MainEx2
    {
        String name = "Abishek";

        public void over()
        {
            Console.WriteLine(name);
        }

        
        public static void aain(String[] args)
        {
            MainEx2 main = new MainEx2();
            main.name = "asds";
            main.over();

        }

    }

   
}
