using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Collection
{
    internal class SortedDictionary
    {
        public static void aain(string[] args)
        {
            var dictionary = new SortedDictionary<String, int>();

            dictionary.Add("animal", 3);  //adds key-value pairs to the dictionary
            dictionary.Add("dodge", 5);
            dictionary.Add("cricket", 2);
            dictionary.Add("basket", 1);

            dictionary.Remove("dodge"); //remove a particular key-value pair from the dictionary

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            if (dictionary.ContainsKey("dodge")) //containsKey used to check whether the key is present in the dictionary or not
            {
                Console.WriteLine("Key present");
            }
            else
            {
                Console.WriteLine("key not present");
            }

            foreach (var item in dictionary)
            {
                Console.Write(item.Key + " ");  //key method is used to take the keys in the dictionary
                Console.Write(item.Value);    //value method is used to take the values in the dictionary
                Console.WriteLine();
            }

            Console.WriteLine(dictionary.Count + " count"); //print the number of key-value pairs present in the dictionary

            dictionary.Clear(); //clears all the key-value pairs in the dictionary
        }
    }
}
