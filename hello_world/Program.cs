// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("The current time is: ");
Console.WriteLine(DateTime.Now);

// Data Types
Console.WriteLine("----------- Data Types ------------");

Console.WriteLine('b'); //Character literals -- can only be a single character

Console.WriteLine(123); // Integer literals

Console.WriteLine(0.25F); // Float -- f or F works -- precision ~6-9 digits
// Least precise so use on fixed fractional values to avoid unexpected computational errors

Console.WriteLine(2.62165); // Double -- just type in normal decimal number -- precision ~15-17 digits

Console.WriteLine(12.39814126m); // Decimal -- m or M works -- precision 28-29 digits

Console.WriteLine(true);
Console.WriteLine(false);

//Variable Declaration
Console.WriteLine("---------- Variable Declaration ----------");

char charA;
charA = 'a';
Console.WriteLine(charA);

int intOne = 1;
Console.WriteLine(intOne);

string firstName;
firstName = "Bob1";
Console.WriteLine(firstName);
firstName = "Bob2";
Console.WriteLine(firstName);
firstName = "Bob3";
Console.WriteLine(firstName);

Console.WriteLine("----------------------------------------------");
Console.WriteLine("Hello, " + firstName + "!");
Console.Write("You are ");
Console.Write(charA);
Console.WriteLine(" lucky guest!");
Console.WriteLine("Have " + intOne + " on us. :)");
Console.WriteLine("~~~~~Pretend this is a free coupon~~~~~ yay");