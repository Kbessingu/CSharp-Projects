/*
Command line Dice app with 3 rolls without stacking bonus( bug fixed )
Using if, else, else if, logic operators( ||, && ) and nesting code
*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("\nYou rolled triples! +6 bonus to total");
        total += 6;
    }
    else
    {
        Console.WriteLine("\nYou rolled doubles! +2 bonus to total!");
        total += 2;
    }

    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16)
{
    Console.WriteLine("\nYou Win 5 Steam keys");
}
else if (total >= 10)
{
    Console.WriteLine("\nYou win 3 Steam key");
}
else if (total == 7)
{
    Console.WriteLine("\nYou win 10 Steam keys");
}
else
{
    Console.WriteLine("\nYou lose!");
}
