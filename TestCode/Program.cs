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
Dictionary<string, int[]> students = new Dictionary<string, int[]>();

students.Add("Sam", new int[] {90, 30, 40});
students.Add("Timmy", new int[] {20, 100, 100, 100});

foreach (KeyValuePair<string, int[]> pair in students)
{
    Console.WriteLine($"Student: {pair.Key}, Grades: {string.Join(", ", pair.Value)}");
}