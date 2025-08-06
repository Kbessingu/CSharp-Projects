/*
Simple command line calculator app
Using variables, math operations, output and string interpolation
*/

double num1 = 10;
double num2 = 5;

double addition = num1 + num2;
double substaction = num1 - num2;
double multiplication = num1 * num2;
double division = num1 / num2;

Console.WriteLine($"{num1} + {num2} = {addition}");
Console.WriteLine($"{num1} - {num2} = {substaction}");
Console.WriteLine($"{num1} * {num2} = {multiplication}");
Console.WriteLine($"{num1} / {num2} = {division}");
