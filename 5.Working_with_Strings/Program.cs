using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will \n wrap to next line");
            Console.WriteLine("This will \" print out the quotation mark.");

            string firstname = "Dinah";
            string lastname = "Skosana";
            //concatination
            Console.WriteLine(firstname + " " + lastname);

            //function with strings
            Console.WriteLine(firstname.Length);

            //Method on string
            Console.WriteLine(firstname.ToUpper());

            //Method with a parameter eg contains(), its case sensitive
            Console.WriteLine(lastname.Contains("Sko"));

            //access characters using index
            Console.WriteLine(firstname[0]);

            //index Of will tell u iff the value is there and at what position
            Console.WriteLine("index of a is");
            Console.WriteLine(lastname.IndexOf("a"));
            //can use double quotes too

            //substring, to grab from an index onwards
            Console.WriteLine(firstname.Substring(1));

            //you can also give index and length ie how many chars you want to grab
            Console.WriteLine(firstname.Substring(1, 2));

            Console.Read();



        }
    }
}
