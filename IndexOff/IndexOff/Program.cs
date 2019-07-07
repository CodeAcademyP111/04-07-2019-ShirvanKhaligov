using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The String ");
            string str = Console.ReadLine();
            //char a = Char.(Console.ReadLine());
            Console.WriteLine("Please Enter The Char");

            char b = (char)Console.Read();

            Console.WriteLine(str.IndexOff(b));





        }
    }
    public static class LastIndex
    {
        public static int IndexOff(this string word, char d)
        {
            int count = -1;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == d)
                    count = i;
            }

            return count;
        }
    }
}
