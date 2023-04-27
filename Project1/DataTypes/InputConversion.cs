using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.DataTypes
{
    internal class InputConversion
    {
        public static void aain(String[] args)
        {
            String input = "1234564";
         int result =Convert.ToInt32(input);
        
            Console.WriteLine(result);
        }
    }

    public class OutputConversion
    {
        public static void Main(String[] args)
        {
            int i = 12;
            double d = 765.12;
            float f = 56.123F;

            Console.WriteLine(Convert.ToString(f));
            Console.WriteLine(Convert.ToInt32(d));
            Console.WriteLine(Convert.ToUInt32(f));
            Console.WriteLine(Convert.ToDouble(i));
            Console.WriteLine("sdfsf");
        }
    }
}




