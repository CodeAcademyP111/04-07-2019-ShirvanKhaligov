using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSimpleNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Number");
          



            try
            {   int b = Convert.ToInt32(Console.ReadLine());
                b.FindSimpleNumber();
                

            }
            catch
            {
                Console.WriteLine("ERROR:" +
                    "Just Enter the Number");
            }


           
            Console.ReadLine();
        }
    }
}
