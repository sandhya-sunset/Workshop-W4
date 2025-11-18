// Object using default constructor
using Task_4;

Player p1 = new Player();
Console.WriteLine("Player 1 -> Name: " + p1.playerName + ", Level: " + p1.level + ", Health: " + p1.health);

// Object using parameterized constructor
Player p2 = new Player("Sandhya", 7, 120);
Console.WriteLine("Player 2 -> Name: " + p2.playerName + ", Level: " + p2.level + ", Health: " + p2.health);