# A .NET Core CLI template on Gitpod

This is a [.NET Core CLI](https://docs.microsoft.com/en-us/dotnet/core/introduction) template configured for ephemeral cloud development environments on [Gitpod](https://www.gitpod.io/).

## Next Steps

Click the button below to start a new development environment:

[![Open in Gitpod](https://gitpod.io/button/open-in-gitpod.svg)](https://gitpod.io/#https://github.com/gitpod-io/template-dotnet-core-cli-csharp)

## Get Started With Your Own Project

### A new project

Click the above "Open in Gitpod" button to start a new workspace. Once you're ready to push your first code changes, Gitpod will guide you to fork this project so you own it.

### An existing project

To get started with .NET Core CLI on Gitpod, add a [`.gitpod.yml`](./.gitpod.yml) file which contains the configuration to improve the developer experience on Gitpod. To learn more, please see the [Getting Started](https://www.gitpod.io/docs/getting-started) documentation.

## Notes

This is Gitpod's repository for C# files. It includes all the configurations required to run C# files. 

Run a C# file like so:
- `dotnet run`

This command will run all extant C# files. However, it will look for a function called Main(). This is called the entry point.

### Basics

#### .NET

.NET is a common reference when discussing C#. It is framework like Django, used for building web applications

#### Lines

Lines of code must be ended with semi-colons. Where is this basically optional in JS, it is mandatory in C# - the linter will complain.

#### Variables

Variables must be given a data type when they are declared. The most common are:
- string someText - for strings
- int aNumber - for integers
- double aDecimal - for decimal / floating point numbers to better precision
- decimal aDecimal - for monetary values
- char aCharacter - for single characters
- bool True - true and false boolean values
- DateTime - moments in time

A less common datatype is:
- long aBigNumber - for integers between -9-billion and +9-billion
- float aDecimal - for decimal / floating point numbers - double is more commonly used thanks to better precision


This is because C# is strongly-typed

C# is also statically-typed - meaning that the compiler will check that the data-types are correct before the code executes.

Variables are named using camelCase or snake_case, as in Python. Using hyphens is prohibited.



We can declare variables in 2 ways:
`int myAge`
<br>

`myAge = 32`

Or

`string countryName = "Netherlands";`

The first is similar to declaring variables in JS and then reassigning them later

The second is more concise

When naming variables, we cannot use reserved keywords that refer to inbuilt methods and such, like decimal, in, lock, etc

Variables can be reassigned using ++ and -- for incrementing by 1

or with variable = variable + 5 for more values

or with variable += 5



##### Type conversion

C# supports type conversion. However, it must be done carefully. Type conversion only proceeds if the new data-type can hold more data than the old data-type.

For example, an int can be converted to a double, since the double can hold more data.

If the new data-type holds less data than the old data-type, we can force the conversion using explicit type conversion. See the code for how this is done

Type conversion is necessary when we are reading user inputs - Console.ReadLine always returns a string

Type Conversion is tricky - Convert methods exist for some but not all operations.

##### Numerical data types

The int data-type is used to represent integers - whole numbers

Decimal numbers can be represented with float, double and decimal

Usually, we use double, since it is more precise than float, and faster than decimal

Decimal is the most precise, so it is used for financial applications

Decimal data type must be suffixed with m, just before the semi-colon. This indicates that the variable is a decimal, not a double

When performing arithmetical operations, we must pay close attention to the data-types involved

Operations involving integers will always return integers

If we have a calculation with a double and an integer, the result will be a double

##### Strings

When using long strings, such as blocks of text that hold quote marks, we can use the escape character, \ before a quote mark so that it is not read

We can force new lines the same way, using \n

We can concatenate strings using addition symbols

Variables can be injected into strings via string interpolation. To do so, use the same syntax as JS string literals - a $ before the string and {} to enclose the variable inside 

C# has methods that can be used on strings:
- Length - returns the number of characters in a string
- IndexOf returns the position of a particular character or substring as an index, and -1 if the argument does not exist. The substring is passed as a character
- Substring grabs a slice of a string. We must pass a starting position, and can optionally pass a length as well
- ToUpper and ToLower uppercase and lowercase a string


#### In-built functions

Console.WriteLine("") prints some text to the console

Console.ReadLine() awaits input some the user. There are 2 ways to use this:
- Without assigning to a variable. This requires the user to press Enter
- Assigned to a variable - this allows the program to capture some input and store it in the variable

Type Conversion can be done using the Convert methods

C# has a Math module, like JS:
- Math.Abs() returns the positive version of the number
- Math.Ceiling() rounds up
- Math.Floor() rounds down

- Math.Pow() takes 2 arguments and raises the first number to the second number
- Math.Sqrt() finds the square root

- Math.Min() takes 2 or more arguments and returns the lowest value
- Math.Max() does the same and returns the highest


#### Functions

Functions are defined using the keywords `static void`, followed by the function name and ()

Unlike Python, which reads and executes a file from top to bottom, a C# file is read entirely and then executed, meaning that functions can be called sequentially.

We can invoke functions by name, as long as they are in the same class.


#### Booleans

Boolean variables are declared with the `bool` flag

boolean variables can be assigned `true` and `false` as values

boolean variables can also be assigned mathematical equations and calculations, as well as returns from functions. These will then evaluate to true or false depending on the result

We can also do some wackt stuff, like:
`bool answer = (true == false);`
This evaluates to false, since true is not equal to false

#### Comparison operators

- `==`
- `!=`
- `<`
- `>`
- `<=`
- `>=`

#### Boolean operators
C# uses the same boolean operators as JavaScript 

- `&&` - AND - both/all things must evaluate to true for true to be returned
- `||` - OR - any one of the things must evaluate to true for true to be returned
- `!` - NOT/opposite - reverses any boolean expression, so that expressions that would evaluate to true return as false:
    - `bool notExample = !(1 < 3);` 
    - this returns as false, since 1 is less than 3, but the NOT operator reverses that

Boolean expressions are often very complex, where several simple expressions are connected with logical operators

#### Conditionals

Like JS, IF conditionals are placed inside brackets

Conditionals use the keywords `if`, `else` and `else if`

C# also supports Switch statements, which follows the same syntax as JS

Switch statements are preferable to writing long chains of IF/ELSE IF statements. Rather than going through IF/ELSE IF statements to find the first one that evaluates to true, a switch statement will check to see if the value of the variable matches any of the cases it contains

The value in the brackets after the switch keyword is always the variable whose value we are checking

Switch statements should have a `default` case at the bottom

C# also supports ternary operators for compact binary decisions

#### Methods

Console.WriteLine() and Math.Min() are methods. When we use these methods, we are said to be calling or invoking them. 

We can store the returned output of a method call inside a variable

Methods are C#'s version of JS functions and Python defs. 

We preface a method name with `static void`. Methods are named using PascalCase. As with JS, the body of the method is written inside curly braces

In C#, when we use the `dotnet run` terminal command, the primary method called Main() is executed. For a method to be executed, it must be called in the Main() method, or by a function that is itself called by Main(), or however far back the chain of execution goes.

We can pass arguments to method calls. When the method is defined, we can specify a number of parameters. These parameters are variables, and as such must be declared with their data-type.

Parameters have block-level scope, so they can only be used inside their method

We can use optional parameters when defining methods. This means that we do not have to call a method with all of its parameters. This is useful in situations where we may not be able to pass some of the required variables to a method

To do this, we can use the equals sign to assign a default value to parameters. If a parameter is not fulfilled, the default value is used instead.

If a method has several optional parameters, then when we pass a variable, that variable will fill the first valid parameter. We can instead specify exactly what optional parameter will be filled with `YourMethodName(d: 4)`, in a case where YourMethodName has optional parameters a, b, c, and d. These are called named arguments. In this case, optional parameter d will be filled with the passed value of 4.

Required parameters that do not have default values are called positional arguments. 

When calling methods, we must call named arguments before positional arguments.

##### Method overloading

An extension of the optional parameters concept is method overloading. This is where methods return different outputs depending on what and how many arguments were passed to them.

The Math.Round() method is an excellent example.

We can call Math.Round(double, int). This round the double to int decimal places, so Math.Round(3.1415, 2) returns 3.14

We can also call Math.Round(double). This rounds double to the nearest whole number. This is the default, so to speak.

These methods are separate methods, each declared with `static void`. The difference is in the number of parameters they take. 