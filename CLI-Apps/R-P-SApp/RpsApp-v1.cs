/*
Command line rock paper scissors app
Using if, else if, switch statements and nesting code
*/

Random roll = new Random();
int rollCPU = roll.Next(1, 4);
int rollPlayer = roll.Next(1, 4);

string Player = "";
string Computer = "";

switch (rollPlayer)
{
    case 1:
        Player = "Rock";
        if (Computer == "Rock")
        {
            Console.WriteLine("It's a tie!");
        }
        else if (Computer == "Paper")
        {
            Console.WriteLine("Computer wins!");
        }
        else if (Computer == "Scissors")
        {
            Console.WriteLine("Player wins!");
        }
        break;

    case 2:
        Player = "Paper";
        if (Computer == "Rock")
        {
            Console.WriteLine("Player wins!");
        }
        else if (Computer == "Paper")
        {
            Console.WriteLine("It's a tie!");
        }
        else if (Computer == "Scissors")
        {
            Console.WriteLine("Computer wins!");
        }
        break;

    case 3:
        Player = "Scissors";
        if (Computer == "Rock")
        {
            Console.WriteLine("Player wins!");
        }
        else if (Computer == "Paper")
        {
            Console.WriteLine("Computer wins!");
        }
        else if (Computer == "Scissors")
        {
            Console.WriteLine("It's a tie!");
        }
        break;
}
switch (rollCPU)
{
    case 1:
        Computer = "Rock";
        if (Player == "Rock")
        {
            Console.WriteLine("It's a tie!");
        }
        else if (Player == "Paper")
        {
            Console.WriteLine("Player wins!");
        }
        else if (Player == "Scissors")
        {
            Console.WriteLine("Computer wins!");
        }
        break;

    case 2:
        Computer = "Paper";
        if (Player == "Rock")
        {
            Console.WriteLine("Computer wins!");
        }
        else if (Player == "Paper")
        {
            Console.WriteLine("It's a tie!");
        }
        else if (Player == "Scissors")
        {
            Console.WriteLine("Player wins!");
        }
        break;

    case 3:
        Computer = "Scissors";
        if (Player == "Rock")
        {
            Console.WriteLine("Player wins!");
        }
        else if (Player == "Paper")
        {
            Console.WriteLine("Computer wins!");
        }
        else if (Player == "Scissors")
        {
            Console.WriteLine("It's a tie!");
        }
        break;
}
Console.WriteLine($"{Player} vs {Computer}");
