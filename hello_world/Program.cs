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

// Formatting literal strings
Console.WriteLine("---------- Literal String Formatting ----------");

Console.WriteLine("Hello\nWorld!"); // \n will add (N)ew line
Console.WriteLine("Hello\tWorld!"); // \t will add (t)ab

Console.WriteLine("Hello \"World\"!"); // for quotes in strings -- use \" \" sequence

Console.WriteLine("c:\\file\\path"); // double \\ for file path using single \

//Verbatim string literal -- keeps all whitespace and characters, use @ before literal string
Console.WriteLine(@" space     test   
    how many spaces         will this look like");

// Unicode escape characters
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // \uXXXX 4 number sequence -- doesnt work on my machine :) 

// String concatenation
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

// String interpolation
Console.WriteLine($"Hello {firstName}!"); // less lines, using $ to bring up interpolation template
//can do multiple variables and strings
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");