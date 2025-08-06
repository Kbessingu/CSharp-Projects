/*
Simple command line Dice app
Using Random class, calling methods, string interpolation
*/

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine($"You Rolled a: {roll}");

