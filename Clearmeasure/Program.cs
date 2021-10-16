using System;

namespace Clearmeasure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int max_counter = 100; //default max value
            //verify an input was give, that the input is an integer, and that the value is less that the maximum int value. If so, set the max value to the input given
            if(args.Length >= 1)
            {
                bool inputisint = int.TryParse(args[0], out int result);
                if (inputisint)
                {
                    if(result <= int.MaxValue)
                        max_counter = result;
                }
            }
            //print out the fizzbuzz values
            for (int i = 1; i <= max_counter; i++)
            {
                if (i %3 == 0 & i %5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i %5 == 0)
                    {
                        Console.WriteLine("buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
            }
        }
    }
}

//Package this into a class that can be shared with asp, .net, wpf
//Be able to take in int.max as the upper bound

// Ensure that it doesn't run out of memory. 

//Upload to github, send the url to Rayne.
