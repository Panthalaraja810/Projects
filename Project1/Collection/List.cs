using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Collection
{

    public class List
    {
        public static void aain(String[] args) //main method
        {
            var brand = new List<String>(); //creating object of List
            brand.Add("Toyota"); //adding the elements to array
            brand.Add("toyota");
            brand.Add("Audi");
            brand.Remove("toyota");

            foreach (var i in brand)  //for each loop
            {
                Console.WriteLine(i + " ");
            }
        }

    }

    public class ListEx2
    {
        public static void aain(string[] args)
        {

            var brand = new List<string> { "abhishek", "sds", "dsfsd", "sdfds" }; //another way of creating object of List and initializing the values

            for (int i = 0; i < brand.Count; i++) //for loop
            {
                Console.Write(brand[i] + " ");  //printing the array values
            }
        }
    }
}
