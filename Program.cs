using System;

namespace dotnetcore
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello Adam");
            Input();
            // we can call the static void Input() here
        }

        static void Input(){
            Console.WriteLine("How old are you?");
            string anInput = Console.ReadLine();
            Console.WriteLine($"You are {anInput} years old!");
            Ghost();
        }

        static void Ghost()
        {
            // ASCII art of a ghost
            Console.WriteLine(" .-.");
            Console.WriteLine("(o o)");
            Console.WriteLine("| 0 |");
            Console.WriteLine("|   |");
            Console.WriteLine("'~~~'");
            Console.WriteLine("A Ghost");
            Dog();
        }

        static void Dog()
        {
            // Create Variables
            string name = "Shadow";
            string breed = "Golden Retriever";
            int age = 5;
            double weight = 65.22;
            bool spayed = true;

            // Print variables to the console
            Console.WriteLine(name);
            Console.WriteLine(breed);
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(spayed);
            TypeConversion();
        }

        static void TypeConversion(){
            /*
            double myDouble = 3.2;
 
            // Round myDouble to the nearest whole number

            int myInt = myDouble;
            This throws an error, since an int holds less data than a double 
            
            int myInt = 3;
            // Turn it into a double
            double myDouble = myInt;

            This works fine, since a double holds more data than an int

            */

            // We can force type conversion like so:

            double myDouble = 3.2;
 
            // Round myDouble to the nearest whole number
            int myInt = (int)myDouble;
            // This cuts off the decimal point, giving 3
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
            Conversion();
        }

        static void Conversion(){
            // Ask user for fave number
            Console.Write("Enter your favorite number!: ");
            /*
                int faveNumber = Convert.ToInt32(Console.ReadLine());
                This doesn't work, Codecademy wrong!
                Should look like:
            */
            
            string faveNumberString = Console.ReadLine();
            // Turn that answer into an int
            int faveNumberInt = Convert.ToInt32(faveNumberString);
            Console.WriteLine(faveNumberString);
            Maths();
        }

        static void Maths(){
            Console.WriteLine(Math.Abs(-75));
            // returns 75

            Console.WriteLine(Math.Ceiling(25.7));
            // returns 26

            Console.WriteLine(Math.Floor(25.6));
            // returns 25
            
            Console.WriteLine(Math.Pow(4, 2));
            // returns 16

            Console.WriteLine(Math.Sqrt(25));
            // returns 5

            Console.WriteLine(Math.Min(25, 39));
            // returns 25

            Console.WriteLine(Math.Max(25, 39));
            // returns 39
        }  
    }
}
