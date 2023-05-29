// See https://aka.ms/new-console-template for more information
using Humanizer;

Console.WriteLine("Please enter your name");
var name = Console.ReadLine();
Console.WriteLine("Please enter your role");
var role = Console.ReadLine();
Console.WriteLine("Please enter your age");
var age = int.Parse(Console.ReadLine());

Console.WriteLine($"My name is {name}, my role is {role}, and I am {age.ToWords()} years old");
Console.WriteLine($"Mi nombre es {name}, mi role es {role}, y tengo {age.ToWords(new System.Globalization.CultureInfo("es"))} anios");