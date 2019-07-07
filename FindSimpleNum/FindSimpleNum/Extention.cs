using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSimpleNum
{
    public static class Extention
    {
        public static void FindSimpleNumber(this int num)
        {

         
                int count = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;

                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("This Is simple Number");


                }
                else
                {
                    Console.WriteLine("This İs Not Simple");

                }
            

            //int count = 0;
            //for (int i = 1; i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        count++;
                  
            //    }
            //}
            //if (count == 2)
            //{
            //    Console.WriteLine("This Is simple Number");
      

            //}
            //else
            //{
            //    Console.WriteLine("This İs Not Simple");
         
            //}
        }
    }
}
