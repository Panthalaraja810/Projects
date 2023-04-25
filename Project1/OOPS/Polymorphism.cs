using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.OOPS
{
    internal class Polymorphism
    {
    }

    internal class Main1
    {
        public void vehcile()
        {
            Console.WriteLine("A car is vehicle");
        }
    }

    internal class Main2
    {
        public void vehicle()
        {
            Console.WriteLine("A bike is also vehicle");
        }
    }

    internal class Main3
    {
        public void vehicle()
        {
            Console.WriteLine("Cycle is also vehicle");
        }
    }

    internal class Vehicles
    {
        public static void aain(String[] args)
        {
            Main1 main1 = new Main1();
            Main2 main2 = new Main2();
            Main3 main3 = new Main3();  

            main1.vehcile();
            main2.vehicle();
            main3.vehicle();    
        }
    }



    //Method overloading
    internal class Company
    {
        public String Ename;
        public int Eid;

     

       public void employees(String Ename)
        {
            Console.WriteLine(Ename);
        }
        public void employees(int Eid, String Ename)
        {
            Console.WriteLine(Eid + " " + Ename);
        }

        public static void aain(String[] args)
        {

            Company company = new Company();
            company.employees("Abhishek");
            company.employees(101, "Abhishek");
        }


    }

   

    //method overriding
    internal class Cars
    {
        public void start()
        {
            Console.WriteLine("Car starts");
        }
    }

    internal class Bikes: Company 
    {
        public void start()
        {
            Console.WriteLine("Bike started");
        }
    }

    internal class Implementation
    {
        public static void aain(String[] args)
        {
            Bikes bike = new Bikes();
            bike.start();
        }
    }




}
