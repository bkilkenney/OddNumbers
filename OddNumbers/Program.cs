using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //print out odd nums from 1 through 99 inclusive
            //start at 1, make condition <= 99, and add 2 instead of 1 after each loop

            int counter;
            for (counter = 1; counter <= 99; counter += 2) 
            {
               System.Console.WriteLine(counter); 
            }
        }
    }
}
