using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StingMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello how are  you";
            Console.WriteLine(str1);

            string str2 = "I am good";
            string str3 = String.Concat(str1, str2);
            Console.WriteLine(str3);

            Console.WriteLine(str3.LastIndexOf('g'));

            Console.WriteLine( str1.IndexOf("how"));
            Console.WriteLine( str1.IndexOf("h"));


            string str4 = "";
            Console.WriteLine(String.IsNullOrEmpty(str4)); 

            string mystring="anjali";
            Console.WriteLine(mystring.GetHashCode());

            string s = "Checks if the String ends with The given string";
            Console.WriteLine(s.EndsWith("string"));
            Console.WriteLine(s.EndsWith("given"));
            Console.WriteLine(s.StartsWith("Checks"));

            Console.WriteLine(s.IndexOf("given"));
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());

            string[] obj = { "we", "are", "learning" };
            string s1 = string.Join("--",obj);
            Console.WriteLine(s1);

            Console.WriteLine(s.Contains("we"));

            Console.WriteLine(s.Replace(" ","="));







        }

    }
}
