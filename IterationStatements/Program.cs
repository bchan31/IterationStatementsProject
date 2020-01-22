using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE -- TODO -- FINAL

            //DONE -- Create a List called "numbers"
            var numbers = new List<int>();
            //DONE -- Create a variable of type int with an initializer of 0
            var i = 0;

            //DONE -- Create a do-while loop
            do
            {
                //DONE -- Increment your variable by 1
                i++;
                //DONE -- Then add your variable to "numbers"
                numbers.Add(i);
            } while (i < 100);
            // While your variable is less than 100



            //DONE -- Create a while loop
            //DONE -- While your variable is less than 200
            while(i < 200)
            {
                //DONE -- Increment your variable by 1
                i++;
                //DONE -- Then add your variable to "numbers"
                numbers.Add(i);
            }

            Console.WriteLine("Increase:");

            //DONE -- Create a foreach loop
            //DONE -- Write your variable to the console
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Decrease:");

            for(int x = 199; x <= numbers.Count && x >= 0; x--)
            {
                Console.WriteLine(numbers[x]);
            }

            //DONE -- Create a for loop
            //DONE -- in your initializer set the value of i to 199
            //DONE -- in your conditional, as long as i is less than or equal to the length of "numbers"
            //DONE -- and as long as i is greater than or equal to 0
            //DONE -- Decrement i by 1
            //DONE -- Write to the console "numbers" at index i

            Console.Read();
        }
    }
}
