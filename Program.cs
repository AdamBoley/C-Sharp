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
        }
    }
}
