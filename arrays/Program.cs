// //old 
// string[] fraudulentOrderIDs = new string[3]; 
// //    [] here tells compiler its an array; [3] indicates number of elements in array

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000"; // testing to see if you can use index out of bounds of array: no

// Previous was old way of making an array, there is new method starting from C# 12 to initialize one

string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Reassigning value of an array
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Using Length property of an array
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");