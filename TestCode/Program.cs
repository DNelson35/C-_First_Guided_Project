﻿// See https://aka.ms/new-console-template for more information
// Random condition = new Random();
// string flip = condition.Next(1,3) == 1 ? "heads" : "tails";
// Console.WriteLine($"The coins face is {flip}");

// string permission = "Admin|Manager";
// int level = 55;

// bool admin = permission.Contains("Admin");
// bool adminLevel = level > 55? true : false;

// bool manager = permission.Contains("Manager");
// bool managerLevel = level >= 20 ? true : false;


// if(admin && adminLevel){
//     Console.WriteLine("Welcome Super Admin");
// } else if(admin && !adminLevel){
//     Console.WriteLine("Welcome, Admin user.");
// } else if(manager && managerLevel){
//     Console.WriteLine("Contact an Admin for access.");
// } else {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// Switch statement
// string fruit = "apple";

// switch(fruit){
//     case "apple":
//     Console.WriteLine(fruit);
//     break;
//     case "banana":
//     Console.WriteLine(fruit);
//     break;
//     default:
//     Console.WriteLine("not a valid fruit");
//     break;
// }

// for loops in c#

// for(int i = 0; i < 10; i++){
//     Console.WriteLine(i);
// }

// while loops
// int i = 0;
// while( i < 5){
//     Console.WriteLine("hey");
//     i++;
// }

// FizzBuzz

for(int i = 1; i < 100; i++){
    if((i % 3 == 0) && (i % 5 == 0)){
        Console.WriteLine($"{i} - FizzBuzz");
    }else if(i % 3 == 0){
        Console.WriteLine($"{i} - Fizz");
    }else if(i % 5 == 0){
        Console.WriteLine($"{i} - Buzz");
    } else{
        Console.WriteLine($"{i}");
    }
}

