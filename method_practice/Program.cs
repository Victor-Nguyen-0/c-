//Stateful vs Stateless methods

//Random dice = new Random();
Random dice = new(); // can now instantiate object without have to repeat the type name (target-typed constructor invocation)
int diceRoll = dice.Next(1,7); // upper bound is exclusive
Console.WriteLine(diceRoll);

// Overloaded method

int diceRoll1 = dice.Next(); // no boundary, 0 - 2,147,483,647 (max value an int can store)
int diceRoll2 = dice.Next(101); // upper boundary 101, 0-100
int diceRoll3 = dice.Next(50, 101); // 50-100

Console.WriteLine($"First roll: {diceRoll1}");
Console.WriteLine($"Second roll: {diceRoll2}");
Console.WriteLine($"Third roll: {diceRoll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);