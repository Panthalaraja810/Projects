using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project1.DataTypes
{
    public struct Person : IMan
    {
        public String Name;
        public int Age;
        public int weight;

        public void test()
        {
            Console.WriteLine("new implementation");
        }

    }
    public class StructEx 
    {
        public static void ain(string[] args)
        {
            Person P1;

            P1.Name = "Abhishek";
            P1.Age = 26;
            P1.weight = 88;

            Console.WriteLine("Name is: " + P1.Name + " Age is: " + P1.Age + " weight is: " + P1.weight);
        }
    }

    public class Human
    {

    }

    public interface IMan //struct can inherit another interface type
    {
        public void test();


    }

    public class MainEx4
    {
        public static void ain(string[] args)
        {
            Person p =new Person();
            p.test();
        }
    }


}
