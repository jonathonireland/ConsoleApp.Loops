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

// While Loop

int counter = 0;

while (counter < 10)
{
    Console.WriteLine($"Hello, World! - {counter}");
    counter+=2;
}

// Ask the user for a number and find the total number that is entered. Print 
// final sum when the user enters -1 to exit.

int sum = 0;
int num = 0;

while(num != -1)
{
    Console.WriteLine("Please enter number to be summed. (-1 to stop or exit)");
    num = Convert.ToInt32(Console.ReadLine());
    if(num != -1)
    {
        sum += num;
    }
}
Console.WriteLine($"Your sum is: {sum}");

Console.WriteLine("********************** While Loop Completed *************************");