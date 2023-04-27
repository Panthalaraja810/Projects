using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Collection
{
    internal class HashSet
    {
        public static void aain(String[] args)
        {
            var set = new HashSet<String>(); //create a new hashset of string

            set.Add("first");    //add some strings to the Hashset
            set.Add("second");
            set.Add("third");
            set.Add("snake");

            set.Remove("first");  //remove a string from the hashset

            foreach (var item in set)  //iterating through hashset
            {
            Console.WriteLine(item);  //printing the elements in hashset
            }

            if(set.Contains("third"))  //contains method will check if the string is present in set or not
            {
                Console.WriteLine("second is present");
            }

            Console.WriteLine(set.Count+" number of items before clear");
           
            set.Clear(); //clear the hashset

           

            Console.WriteLine(set.Count+" number of items after clear");  //print the number of items present in the Hashset

        }

    }
}
