using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Collection
{
    internal class HashSet
    {
        public static void Main(String[] args)
        {
            var set = new HashSet<String>();

            set.Add("first");
            set.Add("second");
            set.Add("third");

            set.Remove("first");

            foreach (var item in set) 
            {
            Console.WriteLine(item);
            }

            if(set.Contains("third"))
            {
                Console.WriteLine("second is present");
            }
           



        }

    }
}
