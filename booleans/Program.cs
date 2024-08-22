string value1 = " a";
string value2 = "A ";

// Trim removes white space, ToLower makes characters in string lowercase
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

string pangram = "The quick brown fox jumps over the lazy dog.";

// Contains parses for block of string inside stirng
Console.WriteLine(pangram.Contains("fox"));

// ! -- unary negation operator (not operator) -- reverses statements
Console.WriteLine(!pangram.Contains("cow"));


// conditional operator ?: -- <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
int saleAmount = 1001;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");