// See https://aka.ms/new-console-template for more information
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

// for(int i = 1; i < 100; i++){
//     if((i % 3 == 0) && (i % 5 == 0)){
//         Console.WriteLine($"{i} - FizzBuzz");
//     }else if(i % 3 == 0){
//         Console.WriteLine($"{i} - Fizz");
//     }else if(i % 5 == 0){
//         Console.WriteLine($"{i} - Buzz");
//     } else{
//         Console.WriteLine($"{i}");
//     }
// }
//  Little console game
// using System.Security;
// Random rand = new Random();
// int health = 10;
// int playerHealth = 10;
// int attack = rand.Next(1, 11);
// int monsterAttack = rand.Next(1, 11);

// do{
//     if(playerHealth > 0){
//         health -= attack;
//     }
//     Console.WriteLine($"Player did {attack} damage");
//     Console.WriteLine($"Monster health {health}");
//     if(health > 0){
//         playerHealth -= monsterAttack;
//         Console.WriteLine($"Monster did {monsterAttack} damage");
//         Console.WriteLine($"Player health {playerHealth}");
//     }
//    string winner = playerHealth <= 0? "Moster Wins" : health <= 0? "player Wins": "";

//     if(winner != ""){
//         Console.WriteLine($"{winner}");
//     }
//     attack = rand.Next(1, 11);
//     monsterAttack = rand.Next(1, 11);
// }while(health > 0 && playerHealth > 0 );

// string? readResult;

// bool validEntry = false;

// Console.WriteLine("Enter a string containing at least three characters:");

// do {
//     readResult = Console.ReadLine();
//     if(readResult != null){
//         if(readResult.Length >= 3){
//             validEntry = true;
//         } else {
//             Console.WriteLine("Please enter a valid entry must be no more or less than 3 characters");
//         }
//     }
// }while(validEntry == false);

// int numericValue = 0;
// bool validNumber = false;

// validNumber = int.TryParse(readResult, out numericValue);

// dict 
// Dictionary<string, int[]> students = new Dictionary<string, int[]>();

// students.Add("Sam", new int[] {90, 30, 40});
// students.Add("Timmy", new int[] {20, 100, 100, 100});

// foreach (KeyValuePair<string, int[]> pair in students)
// {
//     Console.WriteLine($"Student: {pair.Key}, Grades: {string.Join(", ", pair.Value)}");
// }

// safe convert string to int
// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// array methods

// string[] pallets = {"B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");

// // Array.Sort(pallets);
// // to reverse order sort then reverse
// // Array.Reverse(pallets);
// Array.Clear(pallets, 0, 2);

// foreach(string pallet in pallets) {
//     Console.WriteLine($"-- {pallet}");
// }

// Array.Resize(ref pallets, 6);

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// reverse a string using char array

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);

// Console.WriteLine(result);

// string[] items = result.Split(',');

// foreach(string item in items){
//     Console.WriteLine($"-- {item}");
// }

// Reverse each word in a string modifying 
// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] stringArr = pangram.Split(' ');

// for(int i = 0; i < stringArr.Length; i++){
//    char[] wordArr = stringArr[i].ToCharArray();
//    Array.Reverse(wordArr);
//    stringArr[i] = new String(wordArr);
// }
// string reveredwordString = String.Join(" ", stringArr);
// Console.WriteLine(reveredwordString);

// // reverse each word none modifying;
// string[] message = pangram.Split(' ');
// string[] newMessage = new string[message.Length];

// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);

//  string input = "Pad this";
//  string padBoth = input.PadLeft(10, '-').PadRight(15, '-');
//  Console.WriteLine(padBoth);

// loading animation in console
// char[] animation = { '|', '/', '-', '\\' };

// for (int i = 0; i < 20; i++)
// {
//    foreach (char c in animation)
//    {
//        Console.Write("\r" + c);
//        Thread.Sleep(100);
//    }
// }

// void randomeNumbers(){
//     Random rand = new Random();
//     for(int i = 0; i < 4; i++){
//         int num = rand.Next(1, 100);
//         Console.Write($"{num} ");
//     }
//     Console.WriteLine();
// }

// randomeNumbers();
// // for(int i = 0; i < 4; i++){
// //     randomeNumbers();
// // }

// guess game

// using System.Runtime.CompilerServices;

// Random rand = new Random();
// int currentGuess;
// bool playing = true;
// string? userSelected;

// Console.WriteLine("Do you want to play a guessing game? (y/n): ");
// userSelected = Console.ReadLine();

// if(userSelected != null && userSelected == "y"){
//     Console.WriteLine("lets Play");
//     int computerPick = rand.Next(1, 10);
//     while(playing == true){
//         Console.WriteLine("Pick a number");
//         string? userPick;
//         userPick = Console.ReadLine();
//         if(int.TryParse(userPick, out currentGuess)){
//             userGuess(userPick, computerPick);
//         }
//     }   
// }else{
//     Console.WriteLine("Ok goodbye");
// }

// void userGuess(string userPick, int computerPick){
//     if (currentGuess == computerPick){
//         Console.WriteLine($"You Win computer picked {computerPick}");
//         playing = false;
//     } else {
//         Console.WriteLine($"Sorry try again {userPick} is the wrong number");
//     }
// }

// using System.Globalization;

// int[] schedule = {800, 1200, 1600, 2000};

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
// {
//     int diff = 0;
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     } 
//     else 
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }

//     for (int i = 0; i < times.Length; i++) 
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
// }

// catching exceptions
// int errorVal = 0;

// try 
// {
//     decimal number = 3m / errorVal;
// } 
// catch {
//     Console.WriteLine("Error:");
// }

using System.Xml.Schema;

int displayNumber(int a, int b){
     int total = a + b;
    return total;
}

Console.WriteLine(displayNumber(1, 5));