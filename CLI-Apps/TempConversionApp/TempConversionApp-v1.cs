/*
Command line temperature conversion app
Using input handling, type conversion, math operations,
*/

Console.WriteLine("Enter a temperature in fahrenheit: ");
int fahrenheit = Convert.ToInt32(Console.ReadLine());
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine(fahrenheit + "°F is equal to " + (int)celsius + "°C");