// Random random = new Random();
// int current = random.Next(1, 11);

// do { // do-while ensures loop will iterate at least once
//     current = random.Next(1, 11);

//     // ensures 8 or higher will not be outputted to console
//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } 

// while (current != 7);

// // while iterates based on boolean, can possibly not do iteration
// while (current >= 3) {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");


// mini rpg battle challenge
int hero = 10;
int monster = 10;

Random dice = new Random();

do {
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");