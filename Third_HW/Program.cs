/* Exercise 1. Write a program that accepts a number as input and checks whether it is a palindrome.*/

/*
bool palindrome(int x)
{
    int rightSide = 0;
    int leftSide = x;
    while (x > 0)
    {
        rightSide = rightSide*10 + x % 10;
        x = x / 10;
    }
    return rightSide == leftSide;
}

Console.Write("This program is designed to determine the palindrome number. Please enter the number to be checked. ");
int n = Convert.ToInt32(Console.ReadLine());
if (palindrome(n))
{
    Console.WriteLine($" The number {n} is a palindrome");
}
else
{   Console.WriteLine($" The number {n} is not a palindrome");
    
}
*/

/* Exsercise 2. Write a program that takes the coordinates 
of two points as input and finds the distance between them in 3D space.*/

/*

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2 , 2) + Math.Pow(z1 - z2, 2));
}

Console.Write("This program calculates the length of a segment in 3D space according to the coordinates specified by the user");
Console.Write("Please enter x1 coordinate ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter y1 coordinate ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter z1 coordinate ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter x2 coordinate ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter y2 coordinate ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter z2 coordinate ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Distance(x1, y1, z1, x2, y2, z2));
*/

/* Exsercise 3. Write a program that takes a number (N) as input
 and outputs a table of cubes of numbers from 1 to N. */

/*
 void Cube(int N)
 {
    int count = 1;

    while(count <= N)
    {
    int c = count*count*count;
    Console.WriteLine($" {count} > {c} ");
    count++;
    }
 }

 Console.Write(" This program takes a number (N) as input and outputs a table of cubes of numbers from 1 to N.");
 Console.Write(" Please enter a number N ");
 int num = Convert.ToInt32(Console.ReadLine());
 Cube(num);

 */