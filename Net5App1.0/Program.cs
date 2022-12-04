using System;

namespace Net5App1._0
{
    class Program
    {
        
        // Entry point of our program
        static void Main(string[] args)
        {
            
            int age = 15;
            //declaring a variable
            int num1;
            //assinging a value to a variable
            num1 = 13;

            int num2 = 23;
            int sum = num1 + num2;

            Console.WriteLine("Hello World!");//Prints and displays on console
            Console.WriteLine("Hello Tim!");
            
            Console.WriteLine(age);
            //using concantination
            Console.WriteLine("num1 " + num1 + " + num2 " + num2 + " is " + sum);


            Console.Read();//Takes a single input of string and returns the ASCII(American Standard Code for Information Interchange) value
        }
    }
}
