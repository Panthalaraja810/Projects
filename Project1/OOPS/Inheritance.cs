using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.OOPS
{
    public class Inheritance
    {
        


    }

    public class Vehicle
    {
        public String Brand;

        public Vehicle(String Brand)
        {
            this.Brand = Brand;
        }

       
        public void myBrand(String Bran)
        {
            Console.WriteLine("my brand is: "+Brand);
        }


    }

    public class Car : Vehicle 
    {
        public String vehName;

       public Car(String vehName):base("BMW")
        {

            this.vehName = vehName;
        }


        public void bike()
        {
            Console.WriteLine("my vehicle: "+ vehName);
        }


    }

    public class Execution
    { 
    public static void aain(String[] args)
        {
        Car car = new Car("CAR");    
            car.bike();
            car.myBrand("hundai");
        }
    }


}
