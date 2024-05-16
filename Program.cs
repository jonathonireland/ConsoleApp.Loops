// See https://aka.ms/new-console-template for more information

// Simple For Loop Demo
// Print Hello World 10 Times

// Global variable / Global scope

Console.WriteLine($"How many times do you want Hello World! repeated?");
int count = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}
Console.WriteLine($"Loop Completed");
// Ask User how many times they wish to print hello world and print accordingly.