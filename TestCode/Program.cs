// See https://aka.ms/new-console-template for more information
// Random condition = new Random();
// string flip = condition.Next(1,3) == 1 ? "heads" : "tails";
// Console.WriteLine($"The coins face is {flip}");

string permission = "Admin|Manager";
int level = 55;

bool admin = permission.Contains("Admin");
bool adminLevel = level > 55? true : false;

bool manager = permission.Contains("Manager");
bool managerLevel = level >= 20 ? true : false;


if(admin && adminLevel){
    Console.WriteLine("Welcome Super Admin");
} else if(admin && !adminLevel){
    Console.WriteLine("Welcome, Admin user.");
} else if(manager && managerLevel){
    Console.WriteLine("Contact an Admin for access.");
} else {
    Console.WriteLine("You do not have sufficient privileges.");
}