using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_With_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(50);
            //printing out numbers without calculation that is as a string
            Console.WriteLine("6 + 4");
            //addition
            Console.WriteLine(6 + 4);
            //division but excluding the decimals
            Console.WriteLine(5 / 2);
            //division including decimals
            Console.WriteLine(5 / 2.0); //float 
            //finding the remainder
            Console.WriteLine(5 % 2);
            //console display 
            Console.WriteLine("the division of 5 by 2 is " + 5 / 2 +" "+ "remainder is " + 5 % 2);

            int num1 = 37;
            num1 += 1;
            //num1 = num1 + 1 OR num1++ is the same as num1 += 1
            Console.WriteLine("num1 = " + num1);

            //absolute values
            Console.WriteLine("The absolute value of -5 is" + Math.Abs(-5));
            //minimum,maximum and averages etc
            Console.WriteLine("Minimum of 23 and 50 is " + Math.Min(23, 50));
            //the power function
            Console.WriteLine("5 to the power of 3 is " + Math.Pow(5, 3));

            Console.ReadLine();
        }
    }
}
