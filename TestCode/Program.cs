// See https://aka.ms/new-console-template for more information
Random condition = new Random();
string flip = condition.Next(1,3) == 1 ? "heads" : "tails";
Console.WriteLine($"The coins face is {flip}");