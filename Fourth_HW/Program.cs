/* Task1. Write a loop that takes two numbers (A and B) 
as input and raises the number A to the natural power of B.*/

/*
int Pow(int A, int B)
{
    int result = 1;

    for(int current = 1; current <= B; current++)
    {
        result = result*A;
    }

    return result;
}
Console.WriteLine("This program raises the number A to the power of B");
Console.Write("Input a number A:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B:  ");
int b = Convert.ToInt32(Console.ReadLine());

double result = Pow(a, b);
Console.WriteLine(Pow(a, b));
*/

/*Task2. Write a program that accepts a number as input
 and outputs the sum of the digits in the number.*/

/*
 int DigitSum(int num)
 {
    int var;
    for(var = 0; num != 0; num /= 10)
    {
        var += num % 10;
    }
    return var;
 }
 Console.WriteLine("This program accepts a number as input and outputs the sum of the digits in the number.");
 Console.Write("Please input a number:  ");
 int number = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"The sum of the digits of the entered number is { DigitSum(number) }");
*/

/*Task3. Write a program that sets an array of m elements and displays them on the screen*/

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        
        Console.Write($"Please enter an {i + 1} element of array:  ");
        
        array[i] = Convert.ToInt32(Console.ReadLine());

        
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();
}

Console.Write("Input a lenght of array:  ");
int lenght = Convert.ToInt32(Console.ReadLine());


CreateArray(lenght);

int[] newArray = CreateArray(lenght);
ShowArray(newArray);