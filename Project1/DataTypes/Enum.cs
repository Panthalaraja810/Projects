using Project1.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.DataTypes
{
    enum Days
    {
        Monday = 1999,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
    public class Days1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine((int)Days.Monday);
        }
    }
}

