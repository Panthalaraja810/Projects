using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Collection
{
    internal class SortedSet
    {
        public static void aain(string[] args)
        {
          var  hashset =new HashSet<string>();  //creating a SortedSet of type String

            hashset.Add("first");  //adding items to set
            hashset.Add("second");
            hashset.Add("third");
            hashset.Add("fourth");
            hashset.Add("second");  //adding a duplicate item

            hashset.Remove("first"); //removing a item from the set

            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }

            if(hashset.Contains("first") ) //check whether the particular item is present or not
            {
                Console.WriteLine("first item present");
            }
            else
            {
                Console.WriteLine("first item not present");
            }

            hashset.Clear(); //Removing all the items from set

            
            hashset.Add("fifth");
            hashset.Add("second");

            foreach(string s in hashset)
            {
                Console.WriteLine(s);  //printing the items in the set
            }

        }
    }
}
