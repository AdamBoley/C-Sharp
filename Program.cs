﻿using System;

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
            Converter();
        }

        static void Converter(){
            // This is a program that finds the number of gold, silver and bronze coins in an amount
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert");
            string amount = Console.ReadLine();
            double amountToConvert = Math.Floor(Convert.ToDouble(amount));
            Console.WriteLine($"{amountToConvert} pence is equal to...");
            
            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(amountToConvert / goldValue);
            double remainder = amountToConvert % goldValue;

            double silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");
        }

        static void Switch(){
            // Switch statement to pick a movie
            Console.WriteLine("Pick a genre:");
            string genre = Console.ReadLine();
            switch (genre) {
                case "Drama":
                    Console.WriteLine("Citizen Kane");
                    break;
                case "Comedy":
                    Console.WriteLine("Duck Soup");
                    break;
                case "Adventure":
                    Console.WriteLine("King Kong");
                    break;
                case "Horror":
                    Console.WriteLine("Psycho");
                    break;
                case "Science Fiction":
                    Console.WriteLine("2001: A Space Odyssey");
                    break;
                default:
                    Console.WriteLine("No movie found");
                    break;
                }
        }

        static void Ternary(){
            // program for determining whether to pick a pepper using a ternary conditional
            int pepperLength = 4;
            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";
            Console.WriteLine(message);
        }

        static void PasswordChecker(){
            // won't actually work
            // Uses a custom method Tools.Contains
            /*
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKKMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "?!@#~=-+/*.,";

            Console.WriteLine("Enter a password:");
            string password = Console.ReadLine();
            int score = 0;
            if (password.Length >= minLength){
                score ++;
            }
            if (Tools.Contains(password, uppercase)){
                score++;
            }
            if (Tools.Contains(password, lowercase)){
                score++;
            }
            if (Tools.Contains(password, digits)){
                score++;
            }
            if (Tools.Contains(password, specialChars)){
                score++;
            }
            Console.WriteLine(score);

            switch (score){
                case 5:
                Console.WriteLine("Password is very strong");
                break;
                case 4:
                Console.WriteLine("Password is very strong");
                break;
                case 3:
                Console.WriteLine("password is strong");
                break;
                case 2:
                Console.WriteLine("password is medium");
                break;
                case 1:
                Console.WriteLine("password is weak");
                break;
                default:
                Console.WriteLine("password meets no criteria");
                break;
                }
                */
        }
    }
}
