/*
* Name: James Cummings
* Course: CSCI 1250, Section 001
* Assignment: Lab 3, Badge Generator
* Date: September 30, 2026
* Description: Badge Generator
*/

// Pt. 1 The Name
Console.WriteLine("==================================");
Console.WriteLine("Welcome to Badge Office");
Console.WriteLine("==================================");
Console.WriteLine("Full name: ");
string fullName = Console.ReadLine();

fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");

string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

string displayName = firstName.ToUpper() + " " + lastName.ToUpper();
string username = firstName.Substring(0, 1).ToLower() + lastName.ToLower();
string initials = firstName.Substring(0, 1).ToUpper() + "." + lastName.Substring(0, 1).ToUpper() + ".";
int lastNameLength = lastName.Length;

Console.WriteLine("Name on badge: " + displayName);
Console.WriteLine("Username: " + username);
Console.WriteLine("Initials: " + initials);
Console.WriteLine("Letters in last name: " + lastNameLength);

// Pt 2: The Numbers
Random rng = new Random();
int studentId = rng.Next(100000, 1000000);
int locker = rng.Next(1, 501);

Console.WriteLine("Student ID: " + studentId);
Console.WriteLine("Locker: " + locker);

Console.WriteLine("Student ID: " + studentId);
Console.WriteLine("Locker: " + locker);

// Pt 3: The Walk
Console.WriteLine("Dorm x:  ");
double dormX = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Dorm y: ");
double dormY = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Class x: ");
double classX = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Class y: ");
double classY = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Walking speed in feet per second: ");
double walkingSpeed = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(
    Math.Pow(classX - dormX, 2) +
    Math.Pow(classY - dormY, 2)
);

int totalSeconds = (int)(distance / walkingSpeed);

int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

Console.WriteLine("Distance: " + Math.Round(distance, 1) + " feet");
Console.WriteLine("Walk time: " + minutes + " minutes " + seconds + " seconds");

double walkSeconds = distance / walkingSpeed;

Console.WriteLine("Distance: " + Math.Round(distance, 1) + " feet");
Console.WriteLine("Walk time: " + minutes + " minutes " + seconds + " seconds");

// Pt 4: Badge

int checkDigit = studentId % 9;

Console.WriteLine("==================================");
Console.WriteLine("STUDENT BADGE");
Console.WriteLine("==================================");
Console.WriteLine("NAME".PadRight(10) + displayName);
Console.WriteLine("USERNAME".PadRight(10) + username);
Console.WriteLine("ID".PadRight(10) + studentId + "-" + checkDigit);
Console.WriteLine("LOCKER".PadRight(10) + locker);
Console.WriteLine("WALK".PadRight(10) + minutes + " min " + seconds + " sec");
Console.WriteLine("==================================");