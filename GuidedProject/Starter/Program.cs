using System;

// initialize variables - graded assignments 
int i = 0;
int currentAssignments = 5;
int[] sophiaAssignments = {90, 86, 87, 98, 100};
int[] andrewAssignments = {92, 89, 81, 96, 90};
int[] emmaAssignments = {90, 85, 87, 98, 68};
int[] loganAssignments = {90, 95, 87, 88,  96};

string[] students = {"Sophia", "Andrew", "Emma", "logan"};

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;


sophiaSum = sophiaAssignments.Sum();
andrewSum = andrewAssignments.Sum();
emmaSum = emmaAssignments.Sum();
loganSum = loganAssignments.Sum();

int[] studentSums = {sophiaSum, andrewSum, emmaSum, loganSum};

decimal[] studentScores = studentSums.Select(sum => (decimal)sum / currentAssignments).ToArray();

Console.WriteLine("Student\t\tGrade\n");
foreach(string student in students) {
    string grade = i == 0 ? "A-" : i == 1 ? "B+" : i == 2 ? "B" : "A-";
    Console.WriteLine($"{student}\t\t{studentScores[i]}\t{grade}");
    i++;
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
