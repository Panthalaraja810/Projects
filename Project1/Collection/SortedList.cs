using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Collection
{
    internal class SortedList
    {
        public static void aain(String[] args)
        {
            var list = new SortedList<int, string>(); //object of sorted list

            list.Add(101,"djasd");
            list.Add(102, "abhishek");
            list.Add(100, "fsdsds");
            list.Add(001, null);
            list.Add(0, "sdfg");
            // list.Add(100, "dwdd"); // will throw ArgumentException because we cannot have duplicate key in SortedList



            list.Remove(101);    //remove the element based on key

            foreach (var i in list)   //for each for iteration
            { 
            Console.WriteLine(i.Key+" "+i.Value);  //printing the values in console
            }
        }
    }


    

}
