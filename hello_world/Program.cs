// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.Write("The current time is: ");
// Console.WriteLine(DateTime.Now);

// // Data Types
// Console.WriteLine("----------- Data Types ------------");

// Console.WriteLine('b'); //Character literals -- can only be a single character

// Console.WriteLine(123); // Integer literals

// Console.WriteLine(0.25F); // Float -- f or F works -- precision ~6-9 digits
// // Least precise so use on fixed fractional values to avoid unexpected computational errors

// Console.WriteLine(2.62165); // Double -- just type in normal decimal number -- precision ~15-17 digits

// Console.WriteLine(12.39814126m); // Decimal -- m or M works -- precision 28-29 digits

// Console.WriteLine(true);
// Console.WriteLine(false);

// //Variable Declaration
// Console.WriteLine("---------- Variable Declaration ----------");

// char charA;
// charA = 'a';
// Console.WriteLine(charA);

// int intOne = 1;
// Console.WriteLine(intOne);

// string firstName;
// firstName = "Bob1";
// Console.WriteLine(firstName);
// firstName = "Bob2";
// Console.WriteLine(firstName);
// firstName = "Bob3";
// Console.WriteLine(firstName);

// Console.WriteLine("----------------------------------------------");
// Console.WriteLine("Hello, " + firstName + "!");
// Console.Write("You are ");
// Console.Write(charA);
// Console.WriteLine(" lucky guest!");
// Console.WriteLine("Have " + intOne + " on us. :)");
// Console.WriteLine("~~~~~Pretend this is a free coupon~~~~~ yay");

// // Formatting literal strings
// Console.WriteLine("---------- Literal String Formatting ----------");

// Console.WriteLine("Hello\nWorld!"); // \n will add (N)ew line
// Console.WriteLine("Hello\tWorld!"); // \t will add (t)ab

// Console.WriteLine("Hello \"World\"!"); // for quotes in strings -- use \" \" sequence

// Console.WriteLine("c:\\file\\path"); // double \\ for file path using single \

// //Verbatim string literal -- keeps all whitespace and characters, use @ before literal string
// Console.WriteLine(@" space     test   
//     how many spaces         will this look like");

// // Unicode escape characters
// // Kon'nichiwa World
// Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // \uXXXX 4 number sequence -- doesnt work on my machine :) 

// // String concatenation
// string firstName2 = "Bob";
// string greeting = "Hello";
// Console.WriteLine(greeting + " " + firstName2 + "!");

// // String interpolation
// Console.WriteLine($"Hello {firstName}!"); // less lines, using $ to bring up interpolation template
// //can do multiple variables and strings
// int version = 11;
// string updateText = "Update to Windows";
// Console.WriteLine($"{updateText} {version}!");

// Basic Operations
Console.WriteLine("---------- Basic Operations ----------");

// Implicit Conversion -- compiler will implciitly convert variables into strings when concatenating if able
string firstName3 = "Bob";
int daysWorked = 7;
Console.WriteLine(firstName3 + " has worked " + daysWorked + 9 + " days."); // here it assumes everything is a string so the int variable and number won't add together
Console.WriteLine(firstName3 + " has worked " + (daysWorked + 9) + " days."); // here the parenthesis will form an operator and indicate an actual operation to be performed
// The + operator here is overloaded. Basically a polymorphism that lets it concatenate strings or add integers in an operation

// Casting -- type of data conversion that instructs compiler to temporarily treat a value as if it were a different data type
int first = 7;
int second = 5;
decimal quotient = (decimal)first / second; // second cast for second variable is redundant 
Console.WriteLine(quotient);

// % operator for remainders after division
Console.WriteLine($"Remainder should be 1: {3%2}");

// Order of Operations -- PEMDAS -- also pay attention to ints vs decimal/floats
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

// Increment/Decrement is same as other languages --> ++ or -- or += or -= 
int value3 = 1;
value3++;
// Increment/Decrement can be placed before or after variable with differing effects
Console.WriteLine("First: " + value3); // Shows 2 -- current value
Console.WriteLine($"Second: {value3++}"); // Returns 2 first, then increments, should 3 now but not outputted
Console.WriteLine("Third: " + value3); // Returns the 3
Console.WriteLine("Fourth: " + (++value3)); // Increments first, then returns 4

// Operations that output ints will use the whole integer and cut off the rest
Console.WriteLine(1/2); //  should be 0.5, but int will cut off and it will show 0
Console.WriteLine(1.0/2); // 1.0 designates it as a double now, so it should output 0.5 //// can also use decimal m and float f