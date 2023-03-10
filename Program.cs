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

            Switch();
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
            GetInput();
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

        static void GetInput(){
            // grabs input
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            // calls method
            DisplayOutput(name);
        }

        static void DisplayOutput(string name){
            // called by method above
            Console.WriteLine($"Your name is {name}");
            // pass name to OptionalParameters()
            OptionalParameters(name);
            // Call OptionalParameters without passing any arguments. This is fine, since the method has a default value
            OptionalParameters();
        }

        static void OptionalParameters(string name = "John Doe"){
            Console.WriteLine($"Hello {name}");
            // Will print John Doe when no name is passed
            // Will print name when a name is passed
            GetMoreInput();
        }

        static void GetMoreInput(){
            Console.WriteLine("Enter some more information");
            Console.WriteLine("Enter job");
            string job = Console.ReadLine();

            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age");
            string age = Console.ReadLine();

            // This passes one variable to the method, and will fill up the job parameter, since it is the first valid parameter
            DisplayMoreOutput(age);
            // We can override this with:
            DisplayMoreOutput(age: age);
            // This forces the variable to fill up the age variable
        }

        static void DisplayMoreOutput(string job = "coder", string name = "John Doe", string age = "30"){
            Console.WriteLine($"Your job is {job}, your name is {name}, your age is {age}");

            MethodOverloading();
        }

        static void MethodOverloading()
        {
            //These three method calls are each to different methods, as determined by the number of arguments
            // calls first method, which accepts 2 parameters, since the method call has 2 arguments
            NamePets("Barty", "Lisa");

            // calls second method, which accepts 3 arguments
            NamePets("Barty", "Lisa", "Ratchet");

            // calls third method, which accepts 0 arguments
            NamePets();
        }

        static void NamePets(string nameOne, string nameTwo){
            Console.WriteLine($"Your pets {nameOne} and {nameTwo} will be joining your voyage across space!");
        }

        static void NamePets(string nameOne, string nameTwo, string nameThree){
            Console.WriteLine($"Your pets {nameOne}, {nameTwo} and {nameThree} will be joining your voyage across space!");
        }

        static void NamePets(){
            Console.WriteLine("Aw, you have no spacefaring pets :(");

            // Here we call the Decorate Planet method. Its output will be returned here
            Console.WriteLine(DecoratePlanet("Jupiter"));
            OutMethod();
        }

        static string DecoratePlanet(string name){
            //This is how we structure a method that returns some output
            return ($"*.*.* Welcome to {name} *.*.*");
        }

        static void OutMethod()
        {
            //This is a demonstration of the out keyword, using the Int32.TryParse method
            
            string ageAsString = "102";
            string nameAsString = "Granny";

            // We want to convert ageAsString to an integer
            int ageAsInt;
            bool outcome = Int32.TryParse(ageAsString, out ageAsInt);
            // outcome will be true in this case, and the method will set ageAsInt as the converted value

            // Log these out
            Console.WriteLine(outcome);
            Console.WriteLine(ageAsInt);

            // We now try the same thing as above
            int nameAsInt;
            bool outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
            // outcome2 will be false in this case, as nameAsString cannot be converted into an integer. nameAsInt will be reassigned a value of 0

            Console.WriteLine(outcome2);
            Console.WriteLine(nameAsInt);

            CustomOut();
            
        }  

        static void CustomOut(){
            // This is a demonstration of a custom use of out
            // Define variables
            string statement = "HELLO";
            bool flag;

            // call Whisper method, setting the out variable
            Console.WriteLine(Whisper(statement, out flag));

            LongWordFinder();
        }

        static string Whisper(string phrase, out bool whispered){
            //Whisper method, lowercases a string
            phrase = phrase.ToLower();
            // also sets whispered to true, which makes flag in the method caller true
            whispered = true;
            return phrase;
        }

        static void LongWordFinder(){
            // Array to be used as first argument
            string[] adjectives = {"rocky", "mountainous", "cosmic", "extraterrestrial"};
            
            // Call Array.Find() and 
            // Pass in the array and IsLong method as arguments
            string firstLongAdjective = Array.Find(adjectives, IsLong);
            
            Console.WriteLine($"The first long word is: {firstLongAdjective}.");
            // prints mountainous, since that is the first element at which IsLong returns as true

            LambdaExpression();
        }

        public static bool IsLong(string word){
            //This is a checker method, which returns true or false depending on the length of the word.
            return word.Length > 8;
        }

        public static void LambdaExpression(){
            string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      
            bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");
            // bool makesContact = Array.Exists(spaceRocks, s => s == "meteorite");
            // This is a shorter way of constructing the lambda expression
            // s here functions sort of like a temporary variable in loops

            // The conventional code below is the normal way of doing this, calling a separate HitGround method
            // bool makesContact = Array.Exists(spaceRocks, HitGround);

            if (makesContact)
            {
                Console.WriteLine("At least one space rock has reached the Earth's surface!");
            } 
            } 
            
            // Separate method for an expression-bodied definition
            // static bool HitGround(string s)
            // {
            //   return s == "meteorite";
            // }
        
        static void Arrays() {

            //This is how we initialise an array
            string[] summerStrut = new string[] {"Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles"};
            
            //The simpler way of array definition and initialisation
            int[] ratings = {1, 3, 5, 5, 4, 3, 5, 1};
            
            //Indexing
            string song = summerStrut[1];
            int songRating = ratings[1];
            Console.WriteLine($"You rated {song} {songRating} stars");

            // Array indexing to update values
            summerStrut[7] = "I Like It";
            ratings[7] = 1;

            int position = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {position + 1} is rated 3 stars");
            //prints song number 2 is rated 3 stars

            string tenChars = Array.Find(summerStrut, song => song.Length > 10);
            Console.WriteLine($"The first song to have a name of more than 10 character is {tenChars}");
            //prints Raspberry Beret

            Array.Sort(summerStrut);
            Console.WriteLine(summerStrut[0]);
            //Print Despacito
            Console.WriteLine(summerStrut[7]);
            //Prints Rebel Rebel

            // instantiate a new array of 8 elements
            string[] summerStrutCopy = new string[8];

            //Copy arrays
            Array.Copy(summerStrut, summerStrutCopy, 8);

            //print
            Console.WriteLine(summerStrutCopy);

            //reverse array
            Array.Reverse(summerStrut);
            Console.WriteLine(summerStrut[0]);
            
            //replace all values with 0
            Array.Clear(ratings, 0, 8);
            Console.WriteLine(ratings[0]);
        }
        

    }
}
